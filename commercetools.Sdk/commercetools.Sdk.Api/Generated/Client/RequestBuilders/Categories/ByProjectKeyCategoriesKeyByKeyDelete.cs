using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using commercetools.Base.Client;


namespace commercetools.Sdk.Api.Client.RequestBuilders.Categories
{

    public partial class ByProjectKeyCategoriesKeyByKeyDelete : ApiMethod<ByProjectKeyCategoriesKeyByKeyDelete>, IApiMethod<ByProjectKeyCategoriesKeyByKeyDelete, commercetools.Sdk.Api.Models.Categories.ICategory>, commercetools.Sdk.Api.Client.IVersionedTrait<ByProjectKeyCategoriesKeyByKeyDelete>, commercetools.Sdk.Api.Client.IConflictingTrait<ByProjectKeyCategoriesKeyByKeyDelete>, commercetools.Sdk.Api.Client.IExpandableTrait<ByProjectKeyCategoriesKeyByKeyDelete>, commercetools.Sdk.Api.Client.IErrorableTrait<ByProjectKeyCategoriesKeyByKeyDelete>, commercetools.Sdk.Api.Client.IDeprecatable200Trait<ByProjectKeyCategoriesKeyByKeyDelete>
    {


        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Delete;

        private string ProjectKey { get; }

        private string Key { get; }


        public ByProjectKeyCategoriesKeyByKeyDelete(IClient apiHttpClient, string projectKey, string key)
        {
            this.ApiHttpClient = apiHttpClient;
            this.ProjectKey = projectKey;
            this.Key = key;
            this.RequestUrl = $"/{ProjectKey}/categories/key={Key}";
        }

        public List<string> GetVersion()
        {
            return this.GetQueryParam("version");
        }

        public List<string> GetExpand()
        {
            return this.GetQueryParam("expand");
        }

        public ByProjectKeyCategoriesKeyByKeyDelete WithVersion(long version)
        {
            return this.AddQueryParam("version", version.ToString());
        }

        public ByProjectKeyCategoriesKeyByKeyDelete WithExpand(string expand)
        {
            return this.AddQueryParam("expand", expand);
        }


        public async Task<commercetools.Sdk.Api.Models.Categories.ICategory> ExecuteAsync()
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<commercetools.Sdk.Api.Models.Categories.ICategory>(requestMessage);
        }

    }
}
