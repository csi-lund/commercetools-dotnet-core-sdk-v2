using System.IO;
using commercetools.Api.Models.Products;
using Xunit;

namespace commercetools.Api.Serialization.Tests
{
    public class ProductTests : IClassFixture<SerializationFixture>
    {
        private readonly SerializationFixture serializationFixture;

        public ProductTests(SerializationFixture serializationFixture)
        {
            this.serializationFixture = serializationFixture;
        }
        
        [Fact]
        public async void TestProductsDeserialization()
        {
            //arrange
            var json = File.OpenRead("Resources/Products/products.json");
            var serializerService = this.serializationFixture.SerializerService;

            //act
            var productResult = await serializerService.Deserialize<IProductPagedQueryResponse>(json);

            //assert
            Assert.NotNull(productResult);
            Assert.True(productResult.Results.Count > 0);
        }
        
    }
}