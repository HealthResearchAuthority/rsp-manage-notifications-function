namespace Rsp.ManageNotificationsFunction.Application.Contracts;

public interface IManageNotificationService
{
    Task AutoClearReadNotifications(int daysUntilAutoCleared);
}