using Newtonsoft.Json;

namespace Datalex.IDMA.Web.Models.Api
{
    [JsonObject]
    public class HealthCheckModel
    {
        [JsonProperty(PropertyName = "code")]
        public string Code { get; set; }

        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }
    }
}