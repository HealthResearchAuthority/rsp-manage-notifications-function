using System.Diagnostics.CodeAnalysis;

namespace Rsp.ManageNotificationsFunction.Application.Settings;

[ExcludeFromCodeCoverage]
public class AzureAppConfiguration
{
    public string Endpoint { get; set; } = null!;
    public string IdentityClientId { get; set; } = null!;
}