namespace Datalex.IDMA.Services.Common
{
    public partial class CommonService : ICommonService
    {
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
