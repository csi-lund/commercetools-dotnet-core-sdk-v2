using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using commercetools.Base.Client;


namespace commercetools.Sdk.Api.Client.RequestBuilders.InStore
{

    public partial class ByProjectKeyInStoreKeyByStoreKeyCustomersByIDGet : ApiMethod<ByProjectKeyInStoreKeyByStoreKeyCustomersByIDGet>, IApiMethod<ByProjectKeyInStoreKeyByStoreKeyCustomersByIDGet, commercetools.Sdk.Api.Models.Customers.ICustomer>, commercetools.Sdk.Api.Client.IExpandableTrait<ByProjectKeyInStoreKeyByStoreKeyCustomersByIDGet>, commercetools.Sdk.Api.Client.IErrorableTrait<ByProjectKeyInStoreKeyByStoreKeyCustomersByIDGet>, commercetools.Sdk.Api.Client.IDeprecatable200Trait<ByProjectKeyInStoreKeyByStoreKeyCustomersByIDGet>
    {


        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Get;

        private string ProjectKey { get; }

        private string StoreKey { get; }

        private string ID { get; }


        public ByProjectKeyInStoreKeyByStoreKeyCustomersByIDGet(IClient apiHttpClient, string projectKey, string storeKey, string id)
        {
            this.ApiHttpClient = apiHttpClient;
            this.ProjectKey = projectKey;
            this.StoreKey = storeKey;
            this.ID = id;
            this.RequestUrl = $"/{ProjectKey}/in-store/key={StoreKey}/customers/{ID}";
        }

        public List<string> GetExpand()
        {
            return this.GetQueryParam("expand");
        }

        public ByProjectKeyInStoreKeyByStoreKeyCustomersByIDGet WithExpand(string expand)
        {
            return this.AddQueryParam("expand", expand);
        }


        public async Task<commercetools.Sdk.Api.Models.Customers.ICustomer> ExecuteAsync()
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<commercetools.Sdk.Api.Models.Customers.ICustomer>(requestMessage);
        }

    }
}
