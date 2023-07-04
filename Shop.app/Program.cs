using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor.Services;
using Shop.app;
using Shop.app.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

//builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
//It works fine even if HttpClient is not Injected (commented ) ! BUGS will appear when execution ! 
builder.Services.AddHttpClient<IEmployerDataService, EmployerDataService>(client => client.BaseAddress = new Uri("https://localhost:44340/")) ; 
builder.Services.AddMudServices();


await builder.Build().RunAsync();
