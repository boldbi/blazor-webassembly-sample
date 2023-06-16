using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using leftsidebarwebassembly;
using leftsidebarwebassembly.Controllers;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });


// Read embedconfig.json file
//var embedConfigPath = Path.Combine(builder.HostEnvironment.BaseAddress, "embedConfig.json");
//var embedConfigContent = await File.ReadAllTextAsync(embedConfigPath);

//var controller = new EmbedDataController();
//var aa = controller.GetDetails("");
var app = builder.Build();
app.Services.GetRequiredService<EmbedDataController>();


await builder.Build().RunAsync();
