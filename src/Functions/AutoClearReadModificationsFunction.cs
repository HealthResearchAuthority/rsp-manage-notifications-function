using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;
using Rsp.Logging.Extensions;
using Rsp.ManageNotificationsFunction.Application.Constants;
using Rsp.ManageNotificationsFunction.Application.Contracts;

namespace Rsp.ManageNotificationsFunction.Functions;

public class AutoClearReadModificationsFunction(
    ILogger<AutoClearReadModificationsFunction> logger,
    IManageNotificationService manageNotificationService)
{
    // Function that runs daily at 7AM
    [Function("AutoClearReadModifications")]
    public async Task Run(
        [TimerTrigger("%AutoClearReadNotificationsTimerSchedule%"
            , RunOnStartup = true
            , UseMonitor = true)]
        TimerInfo myTimer)
    {
        try
        {
            await manageNotificationService.AutoClearReadNotifications();
        }
        catch (Exception ex)
        {
            logger.LogAsError(ErrorStatus.ServerError, ex.Message, ex);
        }
    }
}