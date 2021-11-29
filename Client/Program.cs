using Blazored.Modal;
using Blazored.SessionStorage;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Syncfusion.Blazor;
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;
using Client.Providers;
using Share.Services;
using Blazored.Toast;

namespace Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

            builder.Services.AddBlazoredToast();

            builder.Services.AddOidcAuthentication(options => {
                builder.Configuration.Bind("Local", options.ProviderOptions);
                options.ProviderOptions.DefaultScopes.Add("email");
            });

            builder.Services.AddHttpClient<AppAuthClient>(option =>
            {
                option.BaseAddress = new Uri("https://localhost:44370/api/");
            });

            builder.Services.AddOidcAuthentication<RemoteAuthenticationState,
            RemoteUserAccount>(options =>
            {
                builder.Configuration.Bind("Local", options.ProviderOptions);

                options.ProviderOptions.DefaultScopes.Add("email");
            })
            .AddAccountClaimsPrincipalFactory<RemoteAuthenticationState, RemoteUserAccount, CustomAccountFactory>();

            builder.Services.AddSyncfusionBlazor();
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("NTI3NzMyQDMxMzkyZTMzMmUzMENjWmFkNktSdXQ0REpjVnRRUHJ5TUVNbXRBUGVDSzY2aWZvUXBmT05pVVE9");

            builder.Services.AddBlazoredSessionStorage();

            builder.Services.AddBlazoredModal();
            await builder.Build().RunAsync();
        }
    }
}
