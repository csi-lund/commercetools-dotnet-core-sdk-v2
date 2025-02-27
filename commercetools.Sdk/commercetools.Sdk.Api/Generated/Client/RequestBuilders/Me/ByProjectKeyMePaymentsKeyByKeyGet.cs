using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using commercetools.Base.Client;


namespace commercetools.Sdk.Api.Client.RequestBuilders.Me
{

    public partial class ByProjectKeyMePaymentsKeyByKeyGet : ApiMethod<ByProjectKeyMePaymentsKeyByKeyGet>, IApiMethod<ByProjectKeyMePaymentsKeyByKeyGet, commercetools.Sdk.Api.Models.Me.IMyPayment>, commercetools.Sdk.Api.Client.IExpandableTrait<ByProjectKeyMePaymentsKeyByKeyGet>, commercetools.Sdk.Api.Client.IErrorableTrait<ByProjectKeyMePaymentsKeyByKeyGet>, commercetools.Sdk.Api.Client.IDeprecatable200Trait<ByProjectKeyMePaymentsKeyByKeyGet>
    {


        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Get;

        private string ProjectKey { get; }

        private string Key { get; }


        public ByProjectKeyMePaymentsKeyByKeyGet(IClient apiHttpClient, string projectKey, string key)
        {
            this.ApiHttpClient = apiHttpClient;
            this.ProjectKey = projectKey;
            this.Key = key;
            this.RequestUrl = $"/{ProjectKey}/me/payments/key={Key}";
        }

        public List<string> GetExpand()
        {
            return this.GetQueryParam("expand");
        }

        public ByProjectKeyMePaymentsKeyByKeyGet WithExpand(string expand)
        {
            return this.AddQueryParam("expand", expand);
        }


        public async Task<commercetools.Sdk.Api.Models.Me.IMyPayment> ExecuteAsync()
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<commercetools.Sdk.Api.Models.Me.IMyPayment>(requestMessage);
        }

    }
}
