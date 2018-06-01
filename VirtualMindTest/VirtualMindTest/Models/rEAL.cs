using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VirtualMindTest.Models
{
    public class Real : ICotizacion
    {
        public string obtenerRespuesta()
        {
            return "error 401 no authorized de http";
        }
    }
}