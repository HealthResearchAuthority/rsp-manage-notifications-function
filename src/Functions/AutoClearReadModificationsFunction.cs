using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;
using Rsp.Logging.Extensions;
using Rsp.ManageNotificationsFunction.Application.Constants;
using Rsp.ManageNotificationsFunction.Application.Contracts;
using Microsoft.Extensions.Configuration;

namespace Rsp.ManageNotificationsFunction.Functions;

public class AutoClearReadModificationsFunction(
    ILogger<AutoClearReadModificationsFunction> logger,
    IManageNotificationService manageNotificationService,
    IConfiguration configuration)
{
    // Function that runs daily at 7AM
    [Function("AutoClearReadModifications")]
    public async Task Run(
        [TimerTrigger("%AutoClearReadNotificationsTimerSchedule%",
            RunOnStartup = true,
            UseMonitor = true)]
        TimerInfo myTimer)
    {
        try
        {
            var daysUntilAutoCleared = configuration.GetValue<int>("AutoClearReadNotificationsDays");

            await manageNotificationService.AutoClearReadNotifications(daysUntilAutoCleared);
        }
        catch (Exception ex)
        {
            logger.LogAsError(ErrorStatus.ServerError, ex.Message, ex);
        }
    }
}