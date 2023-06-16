using Newtonsoft.Json;
using leftsidebarwebassembly.Models;
using Microsoft.AspNetCore.Mvc;

namespace leftsidebarwebassembly.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmbedDataController : ControllerBase
    {
        //[HttpPost()]
        //[Route("str")]
        [Route("api/controllername")]
        public string str()
        {
            return "name";
        }

        [HttpPost()]
        [Route("GetDetails")]
        public string GetDetails([FromBody] object embedQuerString)
        {
            string basePath = AppDomain.CurrentDomain.BaseDirectory;
            string jsonString = System.IO.File.ReadAllText(Path.Combine(basePath, "embedConfig.json"));
            GlobalAppSettings.EmbedDetails = JsonConvert.DeserializeObject<EmbedDetails>(jsonString);

            var embedClass = JsonConvert.DeserializeObject<EmbedClass>(embedQuerString.ToString());
            var embedQuery = embedClass.embedQuerString;
            // User your user-email as embed_user_email
            embedQuery += "&embed_user_email=" + GlobalAppSettings.EmbedDetails.UserEmail;
            //To set embed_server_timestamp to overcome the EmbedCodeValidation failing while different timezone using at client application.
            double timeStamp = (int)DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1)).TotalSeconds;
            embedQuery += "&embed_server_timestamp=" + timeStamp;
            var embedDetailsUrl = "/embed/authorize?" + embedQuery + "&embed_signature=" + GetSignatureUrl(embedQuery);

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(embedClass.dashboardServerApiUrl);
                client.DefaultRequestHeaders.Accept.Clear();

                var result = client.GetAsync(embedClass.dashboardServerApiUrl + embedDetailsUrl).Result;
                string resultContent = result.Content.ReadAsStringAsync().Result;
                return resultContent;
            }
        }

        public string GetSignatureUrl(string message)
        {
            var encoding = new System.Text.UTF8Encoding();
            var keyBytes = encoding.GetBytes(GlobalAppSettings.EmbedDetails.EmbedSecret);
            var messageBytes = encoding.GetBytes(message);
            using (var hmacsha1 = new System.Security.Cryptography.HMACSHA256(keyBytes))
            {
                var hashMessage = hmacsha1.ComputeHash(messageBytes);
                return Convert.ToBase64String(hashMessage);
            }
        }
    }






















    //public class EmbedDataController : ControllerBase
    //{
    //    [Route("Embed")]
    //    public string Embed()
    //    {
    //        //string basePath = AppDomain.CurrentDomain.BaseDirectory;
    //        //string jsonString = System.IO.File.ReadAllText(Path.Combine(basePath, "embedConfig.json"));
    //        //GlobalAppSettings.EmbedDetails = JsonConvert.DeserializeObject<EmbedDetails>(jsonString);
    //        return "das";
    //    }

    //    [HttpPost("[action]")]
    //    [Route("AuthorizationServer")]
    //    public string AuthorizationServer([FromBody] object embedQuerString)
    //    {
    //        string basePath = AppDomain.CurrentDomain.BaseDirectory;
    //        string jsonString = System.IO.File.ReadAllText(Path.Combine(basePath, "embedConfig.json"));
    //        GlobalAppSettings.EmbedDetails = JsonConvert.DeserializeObject<EmbedDetails>(jsonString);

    //        var embedClass = JsonConvert.DeserializeObject<EmbedClass>(embedQuerString.ToString());
    //        var embedQuery = embedClass.embedQuerString;
    //        // User your user-email as embed_user_email
    //        embedQuery += "&embed_user_email=" + GlobalAppSettings.EmbedDetails.UserEmail;
    //        //To set embed_server_timestamp to overcome the EmbedCodeValidation failing while different timezone using at client application.
    //        double timeStamp = (int)DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1)).TotalSeconds;
    //        embedQuery += "&embed_server_timestamp=" + timeStamp;
    //        var embedDetailsUrl = "/embed/authorize?" + embedQuery + "&embed_signature=" + GetSignatureUrl(embedQuery);

    //        using (var client = new HttpClient())
    //        {
    //            client.BaseAddress = new Uri(embedClass.dashboardServerApiUrl);
    //            client.DefaultRequestHeaders.Accept.Clear();

    //            var result = client.GetAsync(embedClass.dashboardServerApiUrl + embedDetailsUrl).Result;
    //            string resultContent = result.Content.ReadAsStringAsync().Result;
    //            return resultContent;
    //        }
    //    }

    //    public string GetSignatureUrl(string message)
    //    {
    //        var encoding = new System.Text.UTF8Encoding();
    //        var keyBytes = encoding.GetBytes(GlobalAppSettings.EmbedDetails.EmbedSecret);
    //        var messageBytes = encoding.GetBytes(message);
    //        using (var hmacsha1 = new System.Security.Cryptography.HMACSHA256(keyBytes))
    //        {
    //            var hashMessage = hmacsha1.ComputeHash(messageBytes);
    //            return Convert.ToBase64String(hashMessage);
    //        }
    //    }
    //}
}

