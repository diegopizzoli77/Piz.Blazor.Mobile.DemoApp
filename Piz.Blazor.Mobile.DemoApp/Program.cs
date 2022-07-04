using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Piz.Blazor.Mobile.DemoApp;
using Piz.Blazor.Mobile.DemoApp.MVVM.ViewModel;
using Piz.Blazor.Mobile.UI.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddPizBlazorMobileUI(true);

//MVVM demo
builder.Services.AddTransient<IPersonViewModel, PersonViewModel>();

await builder.Build().RunAsync();
