using Newtonsoft.Json;

namespace Datalex.IDMA.Web.Models.Api
{
    /// <summary>
    /// Represents the health check model
    /// </summary>
    [JsonObject]
    public class HealthCheckModel
    {
        /// <summary>
        /// Gets or sets the code
        /// </summary>
        [JsonProperty(PropertyName = "code")]
        public string Code { get; set; }
        
        /// <summary>
        /// Gets or sets the message
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }
    }
}