namespace Datalex.IDMA.Services.Common
{
    /// <summary>
    /// Represents the common service class
    /// </summary>
    public partial class CommonService : ICommonService
    {
        /// <summary>
        /// Performs a health check
        /// </summary>
        /// <returns>HealthCheckResult</returns>
        public virtual HealthCheckResult HealthCheck()
        {
            return new HealthCheckResult()
            {
                Code = "0",
                Message = "success"
            };
        }
    }
}
