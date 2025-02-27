using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using commercetools.Base.Client;


namespace commercetools.Sdk.Api.Client.RequestBuilders.Customers
{

    public partial class ByProjectKeyCustomersByIDDelete : ApiMethod<ByProjectKeyCustomersByIDDelete>, IApiMethod<ByProjectKeyCustomersByIDDelete, commercetools.Sdk.Api.Models.Customers.ICustomer>, commercetools.Sdk.Api.Client.IDataerasureTrait<ByProjectKeyCustomersByIDDelete>, commercetools.Sdk.Api.Client.IVersionedTrait<ByProjectKeyCustomersByIDDelete>, commercetools.Sdk.Api.Client.IConflictingTrait<ByProjectKeyCustomersByIDDelete>, commercetools.Sdk.Api.Client.IExpandableTrait<ByProjectKeyCustomersByIDDelete>, commercetools.Sdk.Api.Client.IErrorableTrait<ByProjectKeyCustomersByIDDelete>, commercetools.Sdk.Api.Client.IDeprecatable200Trait<ByProjectKeyCustomersByIDDelete>
    {


        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Delete;

        private string ProjectKey { get; }

        private string ID { get; }


        public ByProjectKeyCustomersByIDDelete(IClient apiHttpClient, string projectKey, string id)
        {
            this.ApiHttpClient = apiHttpClient;
            this.ProjectKey = projectKey;
            this.ID = id;
            this.RequestUrl = $"/{ProjectKey}/customers/{ID}";
        }

        public List<string> GetDataErasure()
        {
            return this.GetQueryParam("dataErasure");
        }

        public List<string> GetVersion()
        {
            return this.GetQueryParam("version");
        }

        public List<string> GetExpand()
        {
            return this.GetQueryParam("expand");
        }

        public ByProjectKeyCustomersByIDDelete WithDataErasure(bool dataErasure)
        {
            return this.AddQueryParam("dataErasure", dataErasure.ToString());
        }

        public ByProjectKeyCustomersByIDDelete WithVersion(long version)
        {
            return this.AddQueryParam("version", version.ToString());
        }

        public ByProjectKeyCustomersByIDDelete WithExpand(string expand)
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
