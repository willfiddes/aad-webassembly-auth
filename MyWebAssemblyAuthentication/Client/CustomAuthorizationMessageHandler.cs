using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;
using Microsoft.Extensions.Configuration;

public class CustomAuthorizationMessageHandler : AuthorizationMessageHandler
{

    public CustomAuthorizationMessageHandler(IAccessTokenProvider provider,
        NavigationManager navigation, IConfiguration configuration)
        : base(provider, navigation)
    {

        ConfigureHandler(
            authorizedUrls: new[] { $"{configuration["Api:BaseUrl"]}/fetchdata" },
            scopes: new[] { configuration["Api:Scopes"] });
    }
}