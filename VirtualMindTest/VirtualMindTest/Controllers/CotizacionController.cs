using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using VirtualMindTest.Models;

namespace VirtualMindTest.Controllers
{
    public class CotizacionController : ApiController
    {
        Cotizacion TipoMoneda;

        public IHttpActionResult GetServicio(string id)
        {
            if (id == "Pesos")
            {
                TipoMoneda = new Cotizacion(new Pesos());

                return Ok(TipoMoneda.obtenerRespuesta());
            }
            else if (id == "Real")
            {
                TipoMoneda = new Cotizacion(new Real());

                return Ok(TipoMoneda.obtenerRespuesta());
            }
            else if (id == "Dolar")
            {
                TipoMoneda = new Cotizacion(new Dolar());

                return Ok(TipoMoneda.obtenerRespuesta());
            }
            else
            {
                return ResponseMessage(Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Pagina no encontrada"));
            }

        }
    }
}
