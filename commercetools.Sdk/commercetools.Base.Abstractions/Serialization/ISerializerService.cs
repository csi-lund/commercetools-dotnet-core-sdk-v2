using System;
using System.IO;
using System.Threading.Tasks;

namespace commercetools.Base.Serialization
{
    public interface ISerializerService
    {
        string Serialize<T>(T input);

        Task<T> Deserialize<T>(Stream input);
        
        T Deserialize<T>(string input);
        
        object Deserialize(Type returnType, string input);
    }
}
