using System.IO;
using System.Text.Json;
using System.Threading.Tasks;
using commercetools.Base.Registration;
using commercetools.Base.Serialization.JsonConverters;
using Type = System.Type;

namespace commercetools.Base.Serialization
{
    public class BaseSerializerService : ISerializerService
    {
        protected readonly JsonSerializerOptions _serializerOptions;
       
        public BaseSerializerService(
            ITypeRetriever typeRetriever)
        {
            _serializerOptions = new JsonSerializerOptions
            {
                IgnoreNullValues = true,
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            };
            _serializerOptions.Converters.Add(new CustomDateTimeConverter());
            _serializerOptions.Converters.Add(new DeserializeAsConverterFactory(
                _serializerOptions.PropertyNamingPolicy, _serializerOptions));
            _serializerOptions.Converters.Add(new TypeDiscriminatorConverterFactory(
                _serializerOptions.PropertyNamingPolicy, _serializerOptions));
        }

        public async Task<T> Deserialize<T>(Stream input)
        {
            //return JsonSerializer.Deserialize<T>(input, _serializerOptions);
            return await JsonSerializer.DeserializeAsync<T>(input, _serializerOptions);
        }
        
        public T Deserialize<T>(string input)
        {
            return JsonSerializer.Deserialize<T>(input, _serializerOptions);
        }
        
        public object Deserialize(Type returnType, string input)
        {
            return JsonSerializer.Deserialize(input, returnType, _serializerOptions);
        }

        public string Serialize<T>(T input)
        {
            return JsonSerializer.Serialize<T>(input, _serializerOptions);
        }
    }
}
