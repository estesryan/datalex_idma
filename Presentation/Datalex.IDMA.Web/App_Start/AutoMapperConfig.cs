using AutoMapper;
using Datalex.IDMA.Services.Common;
using Datalex.IDMA.Web.Models.Api;

namespace Datalex.IDMA.Web
{
    public static class AutoMapperConfig
    {
        public static void Register()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<HealthCheckResult, HealthCheckModel>();
            });
        }
    }
}