using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using commercetools.Base.Client;


namespace commercetools.Sdk.Api.Client.RequestBuilders.Messages
{

    public partial class ByProjectKeyMessagesByIDGet : ApiMethod<ByProjectKeyMessagesByIDGet>, IApiMethod<ByProjectKeyMessagesByIDGet, commercetools.Sdk.Api.Models.Messages.IMessage>, commercetools.Sdk.Api.Client.IExpandableTrait<ByProjectKeyMessagesByIDGet>, commercetools.Sdk.Api.Client.IErrorableTrait<ByProjectKeyMessagesByIDGet>, commercetools.Sdk.Api.Client.IDeprecatable200Trait<ByProjectKeyMessagesByIDGet>
    {


        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Get;

        private string ProjectKey { get; }

        private string ID { get; }


        public ByProjectKeyMessagesByIDGet(IClient apiHttpClient, string projectKey, string id)
        {
            this.ApiHttpClient = apiHttpClient;
            this.ProjectKey = projectKey;
            this.ID = id;
            this.RequestUrl = $"/{ProjectKey}/messages/{ID}";
        }

        public List<string> GetExpand()
        {
            return this.GetQueryParam("expand");
        }

        public ByProjectKeyMessagesByIDGet WithExpand(string expand)
        {
            return this.AddQueryParam("expand", expand);
        }


        public async Task<commercetools.Sdk.Api.Models.Messages.IMessage> ExecuteAsync()
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<commercetools.Sdk.Api.Models.Messages.IMessage>(requestMessage);
        }

    }
}
