using Microsoft.AspNetCore.ResponseCompression;
using BlazorWebAssembly.Shared;
using Newtonsoft.Json;

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

//string basePath = AppDomain.CurrentDomain.BaseDirectory;
//string jsonString = System.IO.File.ReadAllText(Path.Combine(basePath, "embedConfig.json"));
//GlobalAppSettings.EmbedDetails = JsonConvert.DeserializeObject<EmbedDetails>(jsonString);

app.MapRazorPages();

app.MapControllers();
app.MapFallbackToFile("index.html");

app.Run();
