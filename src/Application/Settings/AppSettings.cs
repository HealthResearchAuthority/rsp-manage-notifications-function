using System.Diagnostics.CodeAnalysis;

namespace Rsp.ManageNotificationsFunction.Application.Settings;

[ExcludeFromCodeCoverage]
public class AppSettings
{
    public const string ServiceLabel = "managenotificationsfunction";
    public AzureAppConfiguration AzureAppConfiguration { get; set; } = null!;
    public MicrosoftEntra MicrosoftEntra { get; set; } = null!;

    /// <summary>
    ///     Gets or sets the URI of the ApplicationsService microservice.
    /// </summary>
    public Uri ApplicationsServiceUri { get; set; } = null!;

    /// <summary>
    ///     Gets or sets Managed Identity Client ID to enabling the framework to fetch a token for
    ///     accessing Applications Service.
    /// </summary>
    public string ManagedIdentityManageNotificationsClientID { get; set; } = null!;
}