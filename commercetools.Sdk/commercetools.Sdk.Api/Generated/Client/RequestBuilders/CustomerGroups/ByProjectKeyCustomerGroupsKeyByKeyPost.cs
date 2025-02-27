using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using commercetools.Base.Client;
using commercetools.Base.Serialization;


namespace commercetools.Sdk.Api.Client.RequestBuilders.CustomerGroups
{

    public partial class ByProjectKeyCustomerGroupsKeyByKeyPost : ApiMethod<ByProjectKeyCustomerGroupsKeyByKeyPost>, IApiMethod<ByProjectKeyCustomerGroupsKeyByKeyPost, commercetools.Sdk.Api.Models.CustomerGroups.ICustomerGroup>, commercetools.Sdk.Api.Client.IConflictingTrait<ByProjectKeyCustomerGroupsKeyByKeyPost>, commercetools.Sdk.Api.Client.IExpandableTrait<ByProjectKeyCustomerGroupsKeyByKeyPost>, commercetools.Sdk.Api.Client.IDeprecatable200Trait<ByProjectKeyCustomerGroupsKeyByKeyPost>, commercetools.Sdk.Api.Client.IErrorableTrait<ByProjectKeyCustomerGroupsKeyByKeyPost>
    {


        private ISerializerService SerializerService { get; }

        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Post;

        private string ProjectKey { get; }

        private string Key { get; }

        private commercetools.Sdk.Api.Models.CustomerGroups.ICustomerGroupUpdate CustomerGroupUpdate;

        public ByProjectKeyCustomerGroupsKeyByKeyPost(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string key, commercetools.Sdk.Api.Models.CustomerGroups.ICustomerGroupUpdate customerGroupUpdate)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.Key = key;
            this.CustomerGroupUpdate = customerGroupUpdate;
            this.RequestUrl = $"/{ProjectKey}/customer-groups/key={Key}";
        }

        public List<string> GetExpand()
        {
            return this.GetQueryParam("expand");
        }

        public ByProjectKeyCustomerGroupsKeyByKeyPost WithExpand(string expand)
        {
            return this.AddQueryParam("expand", expand);
        }


        public async Task<commercetools.Sdk.Api.Models.CustomerGroups.ICustomerGroup> ExecuteAsync()
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<commercetools.Sdk.Api.Models.CustomerGroups.ICustomerGroup>(requestMessage);
        }
        public override HttpRequestMessage Build()
        {
            var request = base.Build();
            if (SerializerService != null)
            {
                var body = this.SerializerService.Serialize(CustomerGroupUpdate);
                if (!string.IsNullOrEmpty(body))
                {
                    request.Content = new StringContent(body, Encoding.UTF8, "application/json");
                }
            }
            return request;
        }

    }
}
