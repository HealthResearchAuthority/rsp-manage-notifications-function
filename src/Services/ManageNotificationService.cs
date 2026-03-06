using Rsp.ManageNotificationsFunction.Application.Contracts;
using Rsp.ManageNotificationsFunction.Application.ServiceClients;

namespace Rsp.ManageNotificationsFunction.Services;

public class ManageNotificationService(IManageNotificationServiceClient client)
    : IManageNotificationService
{
    public async Task AutoClearReadNotifications()
    {
        await client.AutoClearReadNotifications();
    }
}