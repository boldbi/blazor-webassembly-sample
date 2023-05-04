using BlazorWebAssembly.Models;
using BlazorWebAssembly.Shared;
using BlazorWebAssembly.Server;
using Microsoft.AspNetCore.ResponseCompression;
using Newtonsoft.Json;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseBlazorFrameworkFiles();
app.UseStaticFiles();

app.UseRouting();


app.MapRazorPages();
app.MapControllers();

try
{
    string basePath = AppDomain.CurrentDomain.BaseDirectory;
    string jsonString = System.IO.File.ReadAllText(Path.Combine(basePath, "embedConfig.json"));
    GlobalAppSettings.EmbedDetails = JsonConvert.DeserializeObject<EmbedDetails>(jsonString);
}

//try
//{
//    string basePath = Path.GetDirectoryName(typeof(Program).Assembly.Location);
//string jsonFilePath = Path.Combine(basePath, "Shared", "embedConfig.json");
//    string jsonString = System.IO.File.ReadAllText(Path.Combine(basePath, "embedConfig.json"));
//   // string jsonString = File.ReadAllText(jsonFilePath);
//GlobalAppSettings.EmbedDetails = JsonConvert.DeserializeObject<EmbedDetails>(jsonString);
//}
catch
{
    app.MapFallbackToFile("EmbedConfigErrorLog");
}

app.UseEndpoints(endpoints =>
{
    endpoints.MapFallbackToController("EmbedConfigErrorLog", "EmbedData");
});

//app.MapControllerRoute(
//    name: "default",
//    pattern: "{controller=EmbedData}/{action=EmbedConfigErrorLog}/{id?}");

//app.MapControllerRoute(
//    name: "default",
//    pattern: "{controller=EmbedData}/{action=EmbedConfig}/{id?}");

//app.MapFallbackToFile("Host1.cshtml");

//app.UseEndpoints(endpoints =>
//{
//    endpoints.MapBlazorHub();
//    endpoints.MapFallbackToPage("/_Host");
//});

app.Run();
