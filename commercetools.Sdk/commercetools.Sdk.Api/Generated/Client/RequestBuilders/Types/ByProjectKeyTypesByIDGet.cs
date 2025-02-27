using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using commercetools.Base.Client;


namespace commercetools.Sdk.Api.Client.RequestBuilders.Types
{

    public partial class ByProjectKeyTypesByIDGet : ApiMethod<ByProjectKeyTypesByIDGet>, IApiMethod<ByProjectKeyTypesByIDGet, commercetools.Sdk.Api.Models.Types.IType>, commercetools.Sdk.Api.Client.IExpandableTrait<ByProjectKeyTypesByIDGet>, commercetools.Sdk.Api.Client.IErrorableTrait<ByProjectKeyTypesByIDGet>, commercetools.Sdk.Api.Client.IDeprecatable200Trait<ByProjectKeyTypesByIDGet>
    {


        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Get;

        private string ProjectKey { get; }

        private string ID { get; }


        public ByProjectKeyTypesByIDGet(IClient apiHttpClient, string projectKey, string id)
        {
            this.ApiHttpClient = apiHttpClient;
            this.ProjectKey = projectKey;
            this.ID = id;
            this.RequestUrl = $"/{ProjectKey}/types/{ID}";
        }

        public List<string> GetExpand()
        {
            return this.GetQueryParam("expand");
        }

        public ByProjectKeyTypesByIDGet WithExpand(string expand)
        {
            return this.AddQueryParam("expand", expand);
        }


        public async Task<commercetools.Sdk.Api.Models.Types.IType> ExecuteAsync()
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<commercetools.Sdk.Api.Models.Types.IType>(requestMessage);
        }

    }
}
