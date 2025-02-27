using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using commercetools.Base.Client;


namespace commercetools.Sdk.Api.Client.RequestBuilders.Zones
{

    public partial class ByProjectKeyZonesKeyByKeyGet : ApiMethod<ByProjectKeyZonesKeyByKeyGet>, IApiMethod<ByProjectKeyZonesKeyByKeyGet, commercetools.Sdk.Api.Models.Zones.IZone>, commercetools.Sdk.Api.Client.IExpandableTrait<ByProjectKeyZonesKeyByKeyGet>, commercetools.Sdk.Api.Client.IErrorableTrait<ByProjectKeyZonesKeyByKeyGet>, commercetools.Sdk.Api.Client.IDeprecatable200Trait<ByProjectKeyZonesKeyByKeyGet>
    {


        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Get;

        private string ProjectKey { get; }

        private string Key { get; }


        public ByProjectKeyZonesKeyByKeyGet(IClient apiHttpClient, string projectKey, string key)
        {
            this.ApiHttpClient = apiHttpClient;
            this.ProjectKey = projectKey;
            this.Key = key;
            this.RequestUrl = $"/{ProjectKey}/zones/key={Key}";
        }

        public List<string> GetExpand()
        {
            return this.GetQueryParam("expand");
        }

        public ByProjectKeyZonesKeyByKeyGet WithExpand(string expand)
        {
            return this.AddQueryParam("expand", expand);
        }


        public async Task<commercetools.Sdk.Api.Models.Zones.IZone> ExecuteAsync()
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<commercetools.Sdk.Api.Models.Zones.IZone>(requestMessage);
        }

    }
}
