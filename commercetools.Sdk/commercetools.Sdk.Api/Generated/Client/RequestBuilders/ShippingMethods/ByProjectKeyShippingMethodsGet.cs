using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using commercetools.Base.Client;


namespace commercetools.Sdk.Api.Client.RequestBuilders.ShippingMethods
{

    public partial class ByProjectKeyShippingMethodsGet : ApiMethod<ByProjectKeyShippingMethodsGet>, IApiMethod<ByProjectKeyShippingMethodsGet, commercetools.Sdk.Api.Models.ShippingMethods.IShippingMethodPagedQueryResponse>, commercetools.Sdk.Api.Models.IPagedQueryResourceRequest<ByProjectKeyShippingMethodsGet, commercetools.Sdk.Api.Models.ShippingMethods.IShippingMethodPagedQueryResponse>, commercetools.Sdk.Api.Client.IExpandableTrait<ByProjectKeyShippingMethodsGet>, commercetools.Sdk.Api.Client.ISortableTrait<ByProjectKeyShippingMethodsGet>, commercetools.Sdk.Api.Client.IPagingTrait<ByProjectKeyShippingMethodsGet>, commercetools.Sdk.Api.Client.IQueryTrait<ByProjectKeyShippingMethodsGet>, commercetools.Sdk.Api.Client.IErrorableTrait<ByProjectKeyShippingMethodsGet>, commercetools.Sdk.Api.Client.IDeprecatable200Trait<ByProjectKeyShippingMethodsGet>
    {


        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Get;

        private string ProjectKey { get; }


        public ByProjectKeyShippingMethodsGet(IClient apiHttpClient, string projectKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.ProjectKey = projectKey;
            this.RequestUrl = $"/{ProjectKey}/shipping-methods";
        }

        public List<string> GetExpand()
        {
            return this.GetQueryParam("expand");
        }

        public List<string> GetSort()
        {
            return this.GetQueryParam("sort");
        }

        public List<string> GetLimit()
        {
            return this.GetQueryParam("limit");
        }

        public List<string> GetOffset()
        {
            return this.GetQueryParam("offset");
        }

        public List<string> GetWithTotal()
        {
            return this.GetQueryParam("withTotal");
        }

        public List<string> GetWhere()
        {
            return this.GetQueryParam("where");
        }

        public ByProjectKeyShippingMethodsGet WithExpand(string expand)
        {
            return this.AddQueryParam("expand", expand);
        }

        public ByProjectKeyShippingMethodsGet WithSort(string sort)
        {
            return this.AddQueryParam("sort", sort);
        }

        public ByProjectKeyShippingMethodsGet WithLimit(int limit)
        {
            return this.AddQueryParam("limit", limit.ToString());
        }

        public ByProjectKeyShippingMethodsGet WithOffset(int offset)
        {
            return this.AddQueryParam("offset", offset.ToString());
        }

        public ByProjectKeyShippingMethodsGet WithWithTotal(bool withTotal)
        {
            return this.AddQueryParam("withTotal", withTotal.ToString());
        }

        public ByProjectKeyShippingMethodsGet WithWhere(string where)
        {
            return this.AddQueryParam("where", where);
        }

        public ByProjectKeyShippingMethodsGet WithPredicateVar(string varName, string predicateVar)
        {
            return this.AddQueryParam($"var.{varName}", predicateVar);
        }

        public async Task<commercetools.Sdk.Api.Models.ShippingMethods.IShippingMethodPagedQueryResponse> ExecuteAsync()
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<commercetools.Sdk.Api.Models.ShippingMethods.IShippingMethodPagedQueryResponse>(requestMessage);
        }

    }
}
