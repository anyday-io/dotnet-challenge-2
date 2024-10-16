using Microsoft.AspNetCore.Mvc;


namespace Anyday.IPExtractor.Controllers
{
    public class OperationsApi : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

		//Get input i.p address from the form.
		[HttpPost]
        public JsonResult GetIp()
        {
            //Send GET request to extract I.P details
            //https://demo.ip-api.com/json/192.168.0.1?fields=66842623&lang=en

            //Sample response
            var mockedResponse = SampleResponse();// Pass response body and extract details.
            return Json(mockedResponse);
        }
		
        public string SampleResponse()
        {
            string jsonString = @"
			{
			  ""status"": ""success"",
			  ""continent"": ""Asia"",
			  ""continentCode"": ""AS"",
			  ""country"": ""Thailand"",
			  ""countryCode"": ""TH"",
			  ""region"": ""10"",
			  ""regionName"": ""Bangkok"",
			  ""city"": ""Bangkok"",
			  ""district"": """",
			  ""zip"": ""10260"",
			  ""lat"": 13.6671,
			  ""lon"": 100.5775,
			  ""timezone"": ""Asia/Bangkok"",
			  ""offset"": 25200,
			  ""currency"": ""THB"",
			  ""isp"": ""AIS-Fibre"",
			  ""org"": """",
			  ""as"": ""AS133481 AIS Fibre"",
			  ""asname"": ""AIS-Fibre-AS-AP"",
			  ""mobile"": false,
			  ""proxy"": false,
			  ""hosting"": false,
			  ""query"": ""184.22.240.206""
			}";

            return jsonString;
        }
    }
}
