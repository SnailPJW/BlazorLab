using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Crud_Blazor;
using Crud_Blazor.Services;
using System.Net.Http;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

// builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddHttpClient("ServerAPI", client
    => client.BaseAddress = new Uri("https://webapplication120211215142021.azurewebsites.net/")
);
builder.Services.AddSingleton<IEmployeesService, EmployeesService>();
await builder.Build().RunAsync();
