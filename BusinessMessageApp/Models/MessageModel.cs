using System.Text.Json.Serialization;

namespace BusinessMessageApp.Models
{
    public class MessageModel
    {

        [JsonPropertyName("clientToken")]
        public string ClientToken { get; set; }

        [JsonPropertyName("secret")]
        public string Secret { get; set; }
    }
}
