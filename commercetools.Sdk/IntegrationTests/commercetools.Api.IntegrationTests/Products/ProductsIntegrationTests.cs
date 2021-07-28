using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using commercetools.Api.Client;
using commercetools.Api.IntegrationTests.ProductTypes;
using commercetools.Api.Models.Common;
using commercetools.Api.Models.Products;
using commercetools.Api.Models.ProductTypes;
using commercetools.Base.Client;
using commercetools.Sdk.Api.Extensions;
using Xunit;
using static commercetools.Api.IntegrationTests.Products.ProductsFixture;

namespace commercetools.Api.IntegrationTests.Products
{
    [Collection("Integration Tests")]
    public class ProductsIntegrationTests
    {
        private readonly IClient _client;
        private readonly string _projectKey;
        
        public ProductsIntegrationTests(ServiceProviderFixture serviceProviderFixture)
        {
            var clientConfiguration = serviceProviderFixture.GetClientConfiguration("Client");
            this._client = serviceProviderFixture.GetService<IClient>();
            this._projectKey = clientConfiguration.ProjectKey;
        }

        [Fact]
        public async Task CreateUpdateDeleteProduct()
        {
            await ProductTypesFixture.WithProductType(_client, async productType =>
            {
                var draft = new ProductDraft()
                {
                    ProductType = new ProductTypeResourceIdentifier() { Id = productType.Id },
                    Name = new LocalizedString()
                    {
                        {"en", $"Name"},
                        {"de", $"Name_de"}
                    },
                    Slug = new LocalizedString()
                    {
                        {"en", $"Name"},
                        {"de", $"Name_de"}
                    },
                    Publish = true
                };
                var product = await _client.WithApi().WithProjectKey(_projectKey).Products().Post(draft).ExecuteAsync();
                Assert.NotNull(product.Id);
                
                var update = new ProductUpdate() { Version = product.Version, Actions = new List<IProductUpdateAction>()};
                update.Actions.Add(new ProductUnpublishAction());

                var updatedProduct = await _client.WithApi().WithProjectKey(_projectKey).Products().WithId(product.Id).Post(update).ExecuteAsync();
                Assert.NotEqual(product.Version, updatedProduct.Version);

                var deletedProduct = await _client.WithApi().WithProjectKey(_projectKey).Products().WithId(product.Id)
                    .Delete().WithVersion(updatedProduct.Version).ExecuteAsync();
                Assert.Equal(product.Id, deletedProduct.Id);
            });
        }
        
        [Fact]
        public async Task UploadProductImage()
        {
            await WithProduct(_client,
                draft => DefaultProductDraftWithMultipleVariants(draft, 2),
                async product =>
                {

                    Assert.NotNull(product);
                    Assert.Equal(2, product.MasterData.Staged.Variants.Count);
                    Assert.Empty(product.MasterData.Staged.Variants[1].Images);
                    var variantId = product.MasterData.Staged.Variants[1].Id;
                    

                    var logoPath = @"Resources/ct_logo_farbe.gif";
                    var file = new FileStream(logoPath, FileMode.Open, FileAccess.Read);

                    var updateProduct = await _client
                        .WithApi()
                        .WithProjectKey(_projectKey)
                        .Products()
                        .WithId(product.Id)
                        .Images()
                        .Post(file)
                        .WithFilename("logo.gif")
                        .WithVariant(variantId)
                        .WithStaged(true)
                        .AddHeader("content-type", "image/gif")
                        .ExecuteAsync();
                    
                    Assert.NotNull(updateProduct);
                    Assert.Single(updateProduct.MasterData.Staged.Variants[1].Images);
                    var img = updateProduct.MasterData.Staged.Variants[1].Images.FirstOrDefault();
                    Assert.NotNull(img);
                    Assert.Contains("logo", img.Url);
                });
        }
    }
}