using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using commercetools.Base.Client;
using commercetools.Base.Serialization;


namespace commercetools.Sdk.Api.Client.RequestBuilders.Channels
{

    public partial class ByProjectKeyChannelsByIDPost : ApiMethod<ByProjectKeyChannelsByIDPost>, IApiMethod<ByProjectKeyChannelsByIDPost, commercetools.Sdk.Api.Models.Channels.IChannel>, commercetools.Sdk.Api.Client.IConflictingTrait<ByProjectKeyChannelsByIDPost>, commercetools.Sdk.Api.Client.IExpandableTrait<ByProjectKeyChannelsByIDPost>, commercetools.Sdk.Api.Client.IDeprecatable200Trait<ByProjectKeyChannelsByIDPost>, commercetools.Sdk.Api.Client.IErrorableTrait<ByProjectKeyChannelsByIDPost>
    {


        private ISerializerService SerializerService { get; }

        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Post;

        private string ProjectKey { get; }

        private string ID { get; }

        private commercetools.Sdk.Api.Models.Channels.IChannelUpdate ChannelUpdate;

        public ByProjectKeyChannelsByIDPost(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string id, commercetools.Sdk.Api.Models.Channels.IChannelUpdate channelUpdate)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.ID = id;
            this.ChannelUpdate = channelUpdate;
            this.RequestUrl = $"/{ProjectKey}/channels/{ID}";
        }

        public List<string> GetExpand()
        {
            return this.GetQueryParam("expand");
        }

        public ByProjectKeyChannelsByIDPost WithExpand(string expand)
        {
            return this.AddQueryParam("expand", expand);
        }


        public async Task<commercetools.Sdk.Api.Models.Channels.IChannel> ExecuteAsync()
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<commercetools.Sdk.Api.Models.Channels.IChannel>(requestMessage);
        }
        public override HttpRequestMessage Build()
        {
            var request = base.Build();
            if (SerializerService != null)
            {
                var body = this.SerializerService.Serialize(ChannelUpdate);
                if (!string.IsNullOrEmpty(body))
                {
                    request.Content = new StringContent(body, Encoding.UTF8, "application/json");
                }
            }
            return request;
        }

    }
}
