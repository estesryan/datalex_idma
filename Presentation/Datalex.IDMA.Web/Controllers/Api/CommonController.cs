using AutoMapper;
using Datalex.IDMA.Services.Common;
using Datalex.IDMA.Web.Models.Api;
using System.Web.Http;

namespace Datalex.IDMA.Web.Controllers.Api
{
    /// <summary>
    /// Represents the common controller class
    /// </summary>
    [RoutePrefix("api")]
    public class CommonController : ApiController
    {
        private readonly ICommonService _commonService;

        #region Ctor
        public CommonController(ICommonService commonService)
        {
            this._commonService = commonService;
        }
        #endregion

        /// <summary>
        /// Health check endpoint
        /// </summary>
        /// <returns>HealthCheckModel</returns>
        [Route("health")]
        [HttpGet]
        public IHttpActionResult HealthCheck()
        {
            var result = this._commonService.HealthCheck();

            var model = Mapper.Map<HealthCheckModel>(result);
            return Ok(model);
        }

        /// <summary>
        /// Health check endpoint
        /// </summary>
        /// <returns>HealthCheckModel</returns>
        [Route("health/2")]
        [HttpGet]
        public IHttpActionResult HealthCheck2()
        {
            var result = this._commonService.HealthCheck();

            var model = Mapper.Map<HealthCheckModel>(result);
            return Ok(model);
        }
    }
}
