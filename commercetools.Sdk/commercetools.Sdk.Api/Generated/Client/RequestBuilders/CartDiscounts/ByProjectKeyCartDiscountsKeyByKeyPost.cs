using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using commercetools.Base.Client;
using commercetools.Base.Serialization;


namespace commercetools.Sdk.Api.Client.RequestBuilders.CartDiscounts
{

    public partial class ByProjectKeyCartDiscountsKeyByKeyPost : ApiMethod<ByProjectKeyCartDiscountsKeyByKeyPost>, IApiMethod<ByProjectKeyCartDiscountsKeyByKeyPost, commercetools.Sdk.Api.Models.CartDiscounts.ICartDiscount>, commercetools.Sdk.Api.Client.IConflictingTrait<ByProjectKeyCartDiscountsKeyByKeyPost>, commercetools.Sdk.Api.Client.IExpandableTrait<ByProjectKeyCartDiscountsKeyByKeyPost>, commercetools.Sdk.Api.Client.IDeprecatable200Trait<ByProjectKeyCartDiscountsKeyByKeyPost>, commercetools.Sdk.Api.Client.IErrorableTrait<ByProjectKeyCartDiscountsKeyByKeyPost>
    {


        private ISerializerService SerializerService { get; }

        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Post;

        private string ProjectKey { get; }

        private string Key { get; }

        private commercetools.Sdk.Api.Models.CartDiscounts.ICartDiscountUpdate CartDiscountUpdate;

        public ByProjectKeyCartDiscountsKeyByKeyPost(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string key, commercetools.Sdk.Api.Models.CartDiscounts.ICartDiscountUpdate cartDiscountUpdate)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.Key = key;
            this.CartDiscountUpdate = cartDiscountUpdate;
            this.RequestUrl = $"/{ProjectKey}/cart-discounts/key={Key}";
        }

        public List<string> GetExpand()
        {
            return this.GetQueryParam("expand");
        }

        public ByProjectKeyCartDiscountsKeyByKeyPost WithExpand(string expand)
        {
            return this.AddQueryParam("expand", expand);
        }


        public async Task<commercetools.Sdk.Api.Models.CartDiscounts.ICartDiscount> ExecuteAsync()
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<commercetools.Sdk.Api.Models.CartDiscounts.ICartDiscount>(requestMessage);
        }
        public override HttpRequestMessage Build()
        {
            var request = base.Build();
            if (SerializerService != null)
            {
                var body = this.SerializerService.Serialize(CartDiscountUpdate);
                if (!string.IsNullOrEmpty(body))
                {
                    request.Content = new StringContent(body, Encoding.UTF8, "application/json");
                }
            }
            return request;
        }

    }
}
