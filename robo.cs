using Newtonsoft.Json;
using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Web;

class UploadLocal
    {

    //   public static robojosns.roboRoot stc(string args)
    //    {
    //    byte[] imageArray = System.IO.File.ReadAllBytes(args);
    //    string encoded = Convert.ToBase64String(imageArray);
    //    byte[] data = Encoding.ASCII.GetBytes(encoded);
    //    string api_key = "9VdEvYaGd43QiJT6YBVx"; // Your API Key
    //    string model_endpoint = "xingbie/1"; // Set model endpoint


    //    string uploadURL =$"https://detect.roboflow.com/{model_endpoint}?api_key={api_key}&confidence=0.4";

    //    // Service Request Config
    //    ServicePointManager.Expect100Continue = true;
    //    ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

    //    // Configure Request
    //    WebRequest request = WebRequest.Create(uploadURL);
    //    request.Method = "POST";

    //    request.ContentType = "application/x-www-form-urlencoded";
    //    request.ContentLength = data.Length;

    //    // Write Data
    //    using (Stream stream = request.GetRequestStream())
    //    {
    //        stream.Write(data, 0, data.Length);
    //    }

    //    // Get Response
    //    string responseContent = null;
    //    using (WebResponse response = request.GetResponse())
    //    {
    //        using (Stream stream = response.GetResponseStream())
    //        {
    //            using (StreamReader sr99 = new StreamReader(stream))
    //            {
    //                responseContent = sr99.ReadToEnd();
    //            }
    //        }
    //    }

    //    Console.WriteLine(responseContent);
    //    return JsonConvert.DeserializeObject<robojosns.roboRoot>(responseContent);
    //}

    //public static robojosns.roboRoot stcc(string args)
    //{
    //    string api_key = "9VdEvYaGd43QiJT6YBVx"; // Your API Key
    //    string imageURL = args;
    //    string model_endpoint = "xingbie/1"; // Set model endpoint

    //    // Construct the URL
    //    string uploadURL =
    //            "https://detect.roboflow.com/" + model_endpoint
    //            + "?api_key=" + api_key
    //            + "&image=" + HttpUtility.UrlEncode(imageURL) + "&confidence=0.3";

    //    // Service Point Config
    //    ServicePointManager.Expect100Continue = true;
    //    ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

    //    // Configure Http Request
    //    WebRequest request = WebRequest.Create(uploadURL);
    //    request.Method = "POST";
    //    request.ContentType = "application/x-www-form-urlencoded";
    //    request.ContentLength = 0;

    //    // Get Response
    //    string responseContent = null;
    //    try
    //    {
    //        using (WebResponse response = request.GetResponse())
    //        {
    //            using (Stream stream = response.GetResponseStream())
    //            {
    //                using (StreamReader sr99 = new StreamReader(stream))
    //                {
    //                    responseContent = sr99.ReadToEnd();
    //                }
    //            }
    //        }
    //    }
    //    catch (Exception)
    //    {
    //        return null;
    //    }



    //    Console.WriteLine(responseContent);
    //    return JsonConvert.DeserializeObject<robojosns.roboRoot>(responseContent);
    //}


    public static async Task<robojosns.roboRoot> stcc(string args)
    {
        string api_key = "9VdEvYaGd43QiJT6YBVx"; // Your API Key
        string imageURL = args;
        string model_endpoint = "xingbie/1"; // Set model endpoint

        // Construct the URL
        string uploadURL =
            "https://detect.roboflow.com/" + model_endpoint
            + "?api_key=" + api_key
            + "&image=" + HttpUtility.UrlEncode(imageURL) + "&confidence=0.3";

        using HttpClient client = new HttpClient();
        client.DefaultRequestHeaders.Accept.Clear();
        client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/x-www-form-urlencoded"));

        try
        {
            HttpResponseMessage response = await client.PostAsync(uploadURL, new StringContent(""));
            response.EnsureSuccessStatusCode();
            string responseContent = await response.Content.ReadAsStringAsync();
            Console.WriteLine(responseContent);
            return JsonConvert.DeserializeObject<robojosns.roboRoot>(responseContent);
        }
        catch (Exception)
        {
            return null;
        }

    }
}
