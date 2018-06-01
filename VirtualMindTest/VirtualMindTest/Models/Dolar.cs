using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;
using System.IO;

namespace VirtualMindTest.Models
{
    public class Dolar : ICotizacion
    {
        public string obtenerRespuesta()
        {
            string url = "http://www.bancoprovincia.com.ar/Principal/Dolar";
            WebRequest request = HttpWebRequest.Create(url);
            WebResponse response = request.GetResponse();
            StreamReader reader = new StreamReader(response.GetResponseStream());
            return reader.ReadToEnd();

        }
    }
}