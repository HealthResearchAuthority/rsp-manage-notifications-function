using Refit;

namespace Rsp.ManageNotificationsFunction.Application.ServiceClients;

/// <summary>
///     Interface to interact with Manage Notifications API
/// </summary>
public interface IManageNotificationServiceClient
{
    /// <summary>
    ///     Automatically clears read user notifications
    /// </summary>
    [Get("/UserNotifications/autoclear-read-notifications")]
    Task<IApiResponse> AutoClearReadNotifications([Query] int daysUntilAutoCleared);
}