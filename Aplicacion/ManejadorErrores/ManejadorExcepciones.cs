using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Aplicacion.ManejadorErrores
{
    public class ManejadorExcepciones : Exception
    {
        public HttpStatusCode Codigo { get; }
        public object Errores { get; }

        public ManejadorExcepciones(HttpStatusCode codigo, object errores = null ){
            Codigo = codigo;
            Errores = errores;
        }

        
        
    }
}