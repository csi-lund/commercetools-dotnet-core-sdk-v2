using commercetools.Base.Client;
using commercetools.Base.Serialization;

namespace commercetools.Sdk.Api.Client.RequestBuilders.Me
{

    public class ByProjectKeyMeEmailConfirmRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        public ByProjectKeyMeEmailConfirmRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
        }

        public ByProjectKeyMeEmailConfirmPost Post(commercetools.Sdk.Api.Models.Customers.ICustomerEmailVerify customerEmailVerify)
        {
            return new ByProjectKeyMeEmailConfirmPost(ApiHttpClient, SerializerService, ProjectKey, customerEmailVerify);
        }

    }
}
