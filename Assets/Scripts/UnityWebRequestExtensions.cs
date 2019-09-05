using System.Collections.Generic;
using System.Linq;
using System.Text;
using JetBrains.Annotations;
using UnityEngine.Networking;

namespace ExtraUnityEngine
{
    [PublicAPI]
    public static class UnityWebRequestExtensions
    {
        public static UnityWebRequest ApplyRequestBody(this UnityWebRequest self, string requestBody)
        {
            return self.ApplyRequestBody(Encoding.UTF8.GetBytes(requestBody));
        }

        public static UnityWebRequest ApplyRequestBody(this UnityWebRequest self, IEnumerable<byte> requestBody)
        {
            return self.ApplyRequestBody(requestBody.ToArray());
        }

        public static UnityWebRequest ApplyRequestBody(this UnityWebRequest self, byte[] requestBody)
        {
            if (requestBody == default)
            {
                return self;
            }

            self.uploadHandler = new UploadHandlerRaw(requestBody);
            return self;
        }

        public static UnityWebRequest ApplyRequestHeader(this UnityWebRequest self, string name, string value)
        {
            self.SetRequestHeader(name, value);
            return self;
        }

        public static UnityWebRequest ApplyRequestHeaders(this UnityWebRequest self, IDictionary<string, string> requestHeaders)
        {
            if (requestHeaders == default || !requestHeaders.Any())
            {
                return self;
            }

            foreach (var pair in requestHeaders)
            {
                self.SetRequestHeader(pair.Key, pair.Value);
            }

            return self;
        }
    }
}
