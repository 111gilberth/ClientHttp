using System;
using System.Net;
using Newtonsoft.Json;

namespace consume{

    class membresia{

         void Main(String[] args){

             string url = "https://blackdish.mx/blackdish-beta-v3/api/controller.php";
             var json = new WebClient().DownloadString(url);
             dynamic m = JsonConvert.DeserializeObject(json);
             Console.WriteLine(json);
         }
    }
}