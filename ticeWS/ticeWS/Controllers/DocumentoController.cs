using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ticeWS.Controllers
{
    public class DocumentoController : ApiController
    {
        ticeEntities3 objapi = new ticeEntities3();

        [HttpGet]
        public IEnumerable<SP_DOCUMENTO_RETRIEVE_BY_TAREA_Result> listarDocumentosxTarea(int tarea)
        {

            return objapi.SP_DOCUMENTO_RETRIEVE_BY_TAREA(tarea).AsEnumerable();
        }
    }
}
