using Rsp.ManageNotificationsFunction.Application.Contracts;
using Rsp.ManageNotificationsFunction.Application.ServiceClients;

namespace Rsp.ManageNotificationsFunction.Services;

public class ManageNotificationService(IManageNotificationServiceClient client)
    : IManageNotificationService
{
    public async Task AutoClearReadNotifications(int daysUntilAutoCleared)
    {
        await client.AutoClearReadNotifications(daysUntilAutoCleared);
    }
}