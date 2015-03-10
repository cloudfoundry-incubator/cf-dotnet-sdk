namespace CloudFoundry.CloudController.V2
{
    using System;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Threading.Tasks;
    using CloudFoundry.CloudController.Common.Exceptions;
    using CloudFoundry.CloudController.V2.Interfaces;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using PCLStorage;

    internal sealed class Utilities
    {
        private static JsonSerializerSettings jsonSettings = new JsonSerializerSettings
        {
            DateParseHandling = DateParseHandling.None
        };

        private Utilities()
        {
        }

        internal static T DeserializeJson<T>(string value)
        {
            using (StringReader stringReader = new StringReader(value))
            {
                using (JsonReader reader = new JsonTextReader(stringReader))
                {
                    reader.DateParseHandling = DateParseHandling.None;
                    var obj = JObject.Load(reader);
                    return Deserialize<T>(obj);
                }
            }
        }

        internal static T[] DeserializeJsonArray<T>(string value)
        {
            return JsonConvert.DeserializeObject<T[]>(value);
        }

        internal static T[] DeserializeJsonResources<T>(string value)
        {
            using (StringReader stringReader = new StringReader(value))
            {
                using (JsonReader reader = new JsonTextReader(stringReader))
                {
                    reader.DateParseHandling = DateParseHandling.None;
                    var obj = JObject.Load(reader);
                    if (obj["resources"] == null)
                    {
                        throw new CloudFoundryException("Value contains no resources");
                    }

                    return obj["resources"].Select(Deserialize<T>).ToArray();
                }
            }
        }

        internal static PagedResponseCollection<T> DeserializePage<T>(string value)
        {
            PagedResponseCollection<T> page = new PagedResponseCollection<T>();
            page.Properties = JsonConvert.DeserializeObject<PageProperties>(value, jsonSettings);
            page.Resources = DeserializeJsonResources<T>(value).ToList<T>();
            return page;
        }

        internal static T Deserialize<T>(JToken value)
        {
            if (value["entity"] != null)
            {
                var o = JsonConvert.DeserializeObject<T>(value["entity"].ToString());
                if (value["metadata"] != null)
                {
                    ((IResponse)o).EntityMetadata = JsonConvert.DeserializeObject<Metadata>(value["metadata"].ToString(), jsonSettings);
                }

                return (T)Convert.ChangeType(o, typeof(T), CultureInfo.InvariantCulture);
            }
            else
            {
                return JsonConvert.DeserializeObject<T>(value.ToString(), jsonSettings);
            }
        }

        internal static async Task<byte[]> ReadFile(IFile file)
        {
            byte[] bytes;
            using (Stream fileStream = await file.OpenAsync(FileAccess.Read))
            {
                bytes = new byte[fileStream.Length];
                int numBytesToRead = (int)fileStream.Length;
                int numBytesRead = 0;
                while (numBytesToRead > 0)
                {
                    int n = fileStream.Read(bytes, numBytesRead, numBytesToRead);
                    if (n == 0)
                    {
                        break;
                    }

                    numBytesRead += n;
                    numBytesToRead -= n;
                }
            }

            return bytes;
        }

        internal static async Task WriteFile(byte[] content, string fileName)
        {
            IFile destination = await FileSystem.Current.LocalStorage.CreateFileAsync(fileName, CreationCollisionOption.ReplaceExisting);
            using (Stream fileStream = await destination.OpenAsync(FileAccess.ReadAndWrite))
            {
                fileStream.Write(content, 0, content.Length);
            }
        }
    }
}