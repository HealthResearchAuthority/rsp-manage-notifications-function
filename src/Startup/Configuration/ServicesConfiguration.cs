using System.Diagnostics.CodeAnalysis;
using Microsoft.Extensions.DependencyInjection;
using Rsp.ManageNotificationsFunction.Application.Contracts;
using Rsp.ManageNotificationsFunction.Infrastructure.HttpMessageHandlers;
using Rsp.ManageNotificationsFunction.Services;

namespace Rsp.ManageNotificationsFunction.Startup.Configuration;

[ExcludeFromCodeCoverage]
public static class ServicesConfiguration
{
    public static IServiceCollection AddServices(this IServiceCollection services)
    {
        services.AddTransient<IManageNotificationService, ManageNotificationService>();
        services.AddTransient<AuthHeadersHandler>();

        return services;
    }
}