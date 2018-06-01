using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VirtualMindTest.Models
{
    public class Cotizacion
    {
        private ICotizacion moneda;

        public Cotizacion(ICotizacion moneda)
        {
            this.moneda = moneda;
        }


        public string obtenerRespuesta()
        {
            return moneda.obtenerRespuesta();
        }
    }
}