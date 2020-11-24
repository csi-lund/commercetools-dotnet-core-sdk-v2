using System;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;

namespace commercetools.Base.Client
{
    public class TokenSerializerService : ITokenSerializerService
    {
        private readonly JsonSerializerOptions jsonSerializerOptions;

        public TokenSerializerService()
        {
            jsonSerializerOptions = new JsonSerializerOptions
            {
                PropertyNamingPolicy = SnakeCaseNamingPolicy.Instance
            };
        }

        public async Task<T> Deserialize<T>(Stream input)
        {
            return await JsonSerializer.DeserializeAsync<T>(input, jsonSerializerOptions);
        }

        public object Deserialize(Type returnType, string input)
        {
            return JsonSerializer.Deserialize(input, returnType, jsonSerializerOptions);
        }

        public string Serialize<T>(T input)
        {
            return JsonSerializer.Serialize<T>(input, jsonSerializerOptions);
        }
    }
}
