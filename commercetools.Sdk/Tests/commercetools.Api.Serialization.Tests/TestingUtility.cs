using System.IO;
using System.Text;

namespace commercetools.Api.Serialization.Tests
{
    public class TestingUtility
    {
        public static MemoryStream StreamFromString(string content)
        {
            var stream = new MemoryStream(Encoding.UTF8.GetBytes(content));
            return stream;
        }
    }
}