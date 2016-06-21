using AutoMapper;
using Datalex.IDMA.Services.Common;
using Datalex.IDMA.Web.Models.Api;

namespace Datalex.IDMA.Web
{
    /// <summary>
    /// Represents the AutoMapper configuration class
    /// </summary>
    public static class AutoMapperConfig
    {
        /// <summary>
        /// Register mappings
        /// </summary>
        public static void Register()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<HealthCheckResult, HealthCheckModel>();
            });
        }
    }
}