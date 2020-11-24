using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;
using commercetools.Api.Models.Categories;
using commercetools.Api.Models.Common;
using commercetools.Api.Models.Orders;
using commercetools.Api.Models.Products;
using commercetools.Api.Models.ProductTypes;
using commercetools.Api.Models.Projects;
using commercetools.Api.Models.Reviews;
using commercetools.Api.Models.ShippingMethods;
using commercetools.Api.Models.States;
using commercetools.Api.Models.TaxCategories;
using commercetools.Api.Models.Types;
using commercetools.Base.Serialization;
using FluentAssertions;
using Newtonsoft.Json.Linq;
using Xunit;
using JsonException = System.Text.Json.JsonException;

namespace commercetools.Api.Serialization.Tests
{
    public class DeserializationTests : IClassFixture<SerializationFixture>
    {
        private readonly SerializationFixture serializationFixture;

        public DeserializationTests(SerializationFixture serializationFixture)
        {
            this.serializationFixture = serializationFixture;
        }
        
        [Fact]
        public async void TestProjectDeserialization()
        {
            //arrange
            var projectResponse = File.OpenRead("Resources/project.json");
            ISerializerService serializerService = this.serializationFixture.SerializerService;

            //act
            var project = await serializerService.Deserialize<IProject>(projectResponse);

            //assert
            Assert.NotNull(project);
            Assert.NotNull(project.ShippingRateInputType);
            Assert.IsType<CartScoreType>(project.ShippingRateInputType);
        }
        
        [Fact]
        public async void DeserializeLocalizedString()
        {
            ISerializerService serializerService = this.serializationFixture.SerializerService;
            
            var serialized = @"
                {
                    ""name"": {
                        ""en"": ""name-en"",
                        ""en-US"": ""name-en-us""
                    }
                }
            ";

            var stream = TestingUtility.StreamFromString(serialized);
            var product = await serializerService.Deserialize<ProductProjection>(stream);

            Assert.Equal("name-en", product.Name["en"]);
            Assert.Equal("name-en-us", product.Name["en-US"]);
        }
        
        [Fact]
        public async void DeserializeShippingMethod()
        {
            ISerializerService serializerService = this.serializationFixture.SerializerService;

            var serialized = File.OpenRead("Resources/ShippingMethods/ShippingMethod.json");

            var shippingMethod = await serializerService.Deserialize<ShippingMethod>(serialized);

            Assert.NotNull(shippingMethod);
            Assert.NotNull(shippingMethod.TaxCategory);
            var taxCategoryRef = shippingMethod.TaxCategory;
            Assert.NotNull(taxCategoryRef.Obj);
            Assert.Equal("3d018013-b53d-422a-933c-7294cf114323", taxCategoryRef.Obj.Id);
            Assert.Equal(ReferenceTypeId.TaxCategory, taxCategoryRef.TypeIdAsEnum);
        }
        
        [Fact]
        public async void DeserializeShippingMethods()
        {
            ISerializerService serializerService = this.serializationFixture.SerializerService;

            var serialized = File.OpenRead("Resources/ShippingMethods/ShippingMethodsAsPageQueryResult.json");
            var shippingMethodsResult = await serializerService.Deserialize<ShippingMethodPagedQueryResponse>(serialized);

            Assert.Equal(2, shippingMethodsResult.Count);
            Assert.Equal(20, shippingMethodsResult.Limit);
            Assert.Equal("7806c94b-bd59-47e0-b4b4-fd32ecd2f93d", shippingMethodsResult.Results[0].Id);
            Assert.Equal(ReferenceTypeId.TaxCategory, shippingMethodsResult.Results[0].TaxCategory.TypeIdAsEnum);
            Assert.Equal("3d018013-b53d-422a-933c-7294cf114323", shippingMethodsResult.Results[0].TaxCategory.Obj.Id);
        }
        
        [Fact]
        public async void DeserializeKnowEnum()
        {
            ISerializerService serializerService = this.serializationFixture.SerializerService;

            string serialized = @"
                {
                    ""type"": ""OrderState""
                }
            ";

            var stream = TestingUtility.StreamFromString(serialized);
            var state =  await serializerService.Deserialize<State>(stream);

            Assert.Equal("OrderState", state.Type);
            Assert.Equal(StateTypeEnum.OrderState, state.TypeAsEnum);
        }
        
        [Fact]
        public async void DeserializeUnKnowEnum()
        {
            ISerializerService serializerService = this.serializationFixture.SerializerService;

            string serialized = @"
                {
                    ""type"": ""Unknown""
                }
            ";

            var stream = TestingUtility.StreamFromString(serialized);
            var state = await serializerService.Deserialize<State>(stream);

            Assert.Equal("Unknown", state.Type);
            Assert.Throws<ArgumentException>(() => state.TypeAsEnum);
        }
        
        [Fact]
        public async void DeserializeOrder()
        {
            ISerializerService serializerService = this.serializationFixture.SerializerService;
            var orderSerialized = File.OpenRead("Resources/Orders/order.json");
            
            var order = await serializerService.Deserialize<Order>(orderSerialized);
            Assert.NotNull(order);
            Assert.Equal(PaymentState.Pending,order.PaymentStateAsEnum);
            Assert.Null(order.ShipmentState);
        }

        [Fact]
        public async void ReferenceDeserialization()
        {
            //Deserialize 2 of references to list of references with the correct instance type based on Type Id
            ISerializerService serializerService = this.serializationFixture.SerializerService;
            var serialized = File.OpenRead("Resources/Types/References.json");
            var references = await serializerService.Deserialize<List<IReference>>(serialized);
            Assert.IsType<CategoryReference>(references[0]);
            Assert.IsType<ProductReference>(references[1]);

            var serializedRev = File.OpenRead("Resources/Types/Review.json");
            var review = await serializerService.Deserialize<Review>(serializedRev);
            Assert.IsType<JsonElement>(review.Target);
        }

        [Fact]
        public async void DeserializeInvalidReference()
        {
            ISerializerService serializerService = this.serializationFixture.SerializerService;
            string serialized = @"{
                ""typeId"": ""unknown"",
                ""id"": ""123456""
            }";

            var stream = TestingUtility.StreamFromString(serialized);
            await Assert.ThrowsAsync<JsonException>(() => serializerService.Deserialize<IReference>(stream));
        }


        [Fact]
        public async void ResourceIdentifiersDeserialization()
        {
            //Deserialize 2 of resourceIdentifiers to list of resourceIdentifiers with the correct instance type based on Type Id
            ISerializerService serializerService = this.serializationFixture.SerializerService;
            var serialized = File.OpenRead("Resources/Types/References.json");
            var resourceIdentifiers = await serializerService.Deserialize<List<IResourceIdentifier>>(serialized);
            Assert.IsType<CategoryResourceIdentifier>(resourceIdentifiers[0]);
            Assert.IsType<ProductResourceIdentifier>(resourceIdentifiers[1]);
            var serializedRev = File.OpenRead("Resources/Types/Review.json");
            var review = await serializerService.Deserialize<Review>(serializedRev);
            Assert.IsType<JsonElement>(review.Target);

        }

        [Fact]
        public void ProductDraftSerializationUsingResourceIdentifier()
        {
            ISerializerService serializerService = this.serializationFixture.SerializerService;

            var productDraft = new ProductDraft
            {
                Name = new LocalizedString() {{"en", "name"}},
                Slug = new LocalizedString() {{"en", "slug"}},
                ProductType = new ProductTypeResourceIdentifier
                {
                    Key = "ProductTypeKey"
                },
                TaxCategory= new TaxCategoryResourceIdentifier
                {
                    Key = "TaxCategoryKey"
                },
                Categories = new List<ICategoryResourceIdentifier>()
                {
                    new CategoryResourceIdentifier()
                    {
                        Key = "CategoryKey"
                    }
                },
                State = new StateResourceIdentifier()
                {
                    Key = "StateKey"
                }
            };

            string result = serializerService.Serialize(productDraft);
            JToken resultFormatted = JValue.Parse(result);
            string serialized = File.ReadAllText("Resources/Types/ProductDraftWithResourceIdentifier.json");
            JToken serializedFormatted = JValue.Parse(serialized);
            serializedFormatted.Should().BeEquivalentTo(resultFormatted);
        }

        [Fact]
        public void ProductDraftSerializationUsingReference()
        {
            ISerializerService serializerService = this.serializationFixture.SerializerService;

            var productDraft = new ProductDraft
            {
                Name = new LocalizedString()
                {
                    {"en", "name"},
                    {"en-US", "name"}
                },
                Slug = new LocalizedString() {{"en", "slug"}},
                ProductType = new ProductTypeResourceIdentifier()
                {
                    Id = "ProductTypeId"
                },
                TaxCategory= new TaxCategoryResourceIdentifier()
                {
                    Id = "TaxCategoryId"
                },
                Categories = new List<ICategoryResourceIdentifier>
                {
                    new CategoryResourceIdentifier()
                    {
                        Id = "CategoryId"
                    }
                },
                State = new StateResourceIdentifier
                {
                    Id = "StateId"
                }
            };

            string result = serializerService.Serialize(productDraft);
            JToken resultFormatted = JValue.Parse(result);
            string serialized = File.ReadAllText("Resources/Types/ProductDraftWithReference.json");
            JToken serializedFormatted = JValue.Parse(serialized);
            serializedFormatted.Should().BeEquivalentTo(resultFormatted);
        }
        
        [Fact]
        public async void DeserializeCustomField()
        {
            ISerializerService serializerService = this.serializationFixture.SerializerService;

            string serialized = @"
                {
                    ""fields"": {
                        ""foo"": ""bar"",
                        ""Foos"": ""Bars""
                    }
                }
            ";

            var stream = TestingUtility.StreamFromString(serialized);
            var customFields = await serializerService.Deserialize<ICustomFields>(stream);

            Assert.Equal("bar", customFields.Fields["foo"]);
            Assert.Equal("Bars", customFields.Fields["Foos"]);
        }
    }
}