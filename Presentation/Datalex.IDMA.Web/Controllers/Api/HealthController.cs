using AutoMapper;
using Datalex.IDMA.Services.Common;
using Datalex.IDMA.Web.Models.Api;
using System.Web.Http;

namespace Datalex.IDMA.Web.Controllers.Api
{
    [RoutePrefix("api/health")]
    public class HealthController : ApiController
    {
        private readonly ICommonService _commonService;

        #region Ctor
        public HealthController(ICommonService commonService)
        {
            this._commonService = commonService;
        }
        #endregion

        [Route("")]
        public IHttpActionResult Get()
        {
            var result = this._commonService.HealthCheck();

            var model = Mapper.Map<HealthCheckModel>(result);
            return Ok(model);
        }
    }
}
