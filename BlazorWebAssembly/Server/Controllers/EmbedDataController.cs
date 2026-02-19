using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using BlazorWebAssembly.Shared;
using System.Text;

namespace BlazorWebAssembly.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmbedDataController : Controller
    {
        [HttpGet]
        [Route("GetConfig")]
        public IActionResult GetConfig()
        {
            var jsonData = System.IO.File.ReadAllText("embedConfig.json");
            string basePath = AppDomain.CurrentDomain.BaseDirectory;
            string jsonString = System.IO.File.ReadAllText(Path.Combine(basePath, "embedConfig.json"));
            GlobalAppSettings.EmbedDetails = JsonConvert.DeserializeObject<EmbedDetails>(jsonString);
            
            return Json(new
            {
                DashboardId = GlobalAppSettings.EmbedDetails.DashboardId,
                ServerUrl = GlobalAppSettings.EmbedDetails.ServerUrl,
                EmbedType = GlobalAppSettings.EmbedDetails.EmbedType,
                Environment = GlobalAppSettings.EmbedDetails.Environment,
                SiteIdentifier = GlobalAppSettings.EmbedDetails.SiteIdentifier
            });
        }

        [HttpGet]
        [Route("EmbedConfigErrorLog")]
        public IActionResult EmbedConfigErrorLog()
        {
            return View("~/Pages/EmbedConfigErrorLog.cshtml");
        }

        [HttpPost("[action]")]
        [Route("TokenGeneration")]
        public string TokenGeneration()
        {
            var embedDetails = new
            {
                email = GlobalAppSettings.EmbedDetails.UserEmail,
                serverurl = GlobalAppSettings.EmbedDetails.ServerUrl,
                siteidentifier = GlobalAppSettings.EmbedDetails.SiteIdentifier,
                embedsecret = GlobalAppSettings.EmbedDetails.EmbedSecret,
                dashboard = new  // Dashboard ID property is mandatory only when using BoldBI version 14.1.11.
                {
                    id = GlobalAppSettings.EmbedDetails.DashboardId
                }
            };
            
            //Post call to Bold BI server
            var client = new HttpClient();
            var requestUrl = $"{embedDetails.serverurl}/api/{embedDetails.siteidentifier}/embed/authorize";

            var jsonPayload = JsonConvert.SerializeObject(embedDetails);
            var httpContent = new StringContent(jsonPayload, Encoding.UTF8, "application/json");

            var result = client.PostAsync(requestUrl, httpContent).Result;
            var resultContent = result.Content.ReadAsStringAsync().Result;

            return JsonConvert.DeserializeObject<dynamic>(resultContent).Data.access_token;
        }
    }
}
