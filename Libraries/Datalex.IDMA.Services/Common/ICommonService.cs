namespace Datalex.IDMA.Services.Common
{
    /// <summary>
    /// Represents the common service interface
    /// </summary>
    public partial interface ICommonService
    {
        HealthCheckResult HealthCheck();
    }
}
