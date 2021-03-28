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

namespace BlazorRealTimeSignalR.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("NDgzNUAzMTM4MmUzNDJlMzBFNTFZdHBJQkROTWFMWDQ1dlBoWlNMWERoditkeXlFQVIxcCtuYnc4VTJNPQ==");
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.Services.AddSyncfusionBlazor();
            builder.RootComponents.Add<App>("#app");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

            await builder.Build().RunAsync();
        }
    }
}