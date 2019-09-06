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
        public static UnityWebRequest ApplyDownloadHandler(this UnityWebRequest self, DownloadHandler downloadHandler)
        {
            if (downloadHandler != default)
            {
                self.downloadHandler = downloadHandler;
            }

            return self;
        }

        public static UnityWebRequest ApplyUploadHandler(this UnityWebRequest self, UploadHandler uploadHandler)
        {
            if (uploadHandler != default)
            {
                self.uploadHandler = uploadHandler;
            }

            return self;
        }

        public static UnityWebRequest ApplyRequestBody(this UnityWebRequest self, string requestBody)
        {
            return string.IsNullOrEmpty(requestBody) ? self : self.ApplyRequestBody(Encoding.UTF8.GetBytes(requestBody));
        }

        public static UnityWebRequest ApplyRequestBody(this UnityWebRequest self, IEnumerable<byte> requestBody)
        {
            return requestBody == null ? self : self.ApplyRequestBody(requestBody.ToArray());
        }

        public static UnityWebRequest ApplyRequestBody(this UnityWebRequest self, byte[] requestBody)
        {
            return requestBody == default ? self : self.ApplyUploadHandler(new UploadHandlerRaw(requestBody));
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
