using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ticeWS.Controllers
{
    public class TareaController : ApiController
    {

        ticeEntities3 objapi = new ticeEntities3();

        [HttpGet]
        public IEnumerable<SP_TAREA_RETRIEVE_BY_ACTIVIDAD_Result> listarTareaXActividad(int actividad)
        {
           
            return objapi.SP_TAREA_RETRIEVE_BY_ACTIVIDAD(actividad).AsEnumerable();
        }

        [HttpGet]
        public int ingresarTarea(int codigoCurso, int codigoActividad , string titulo, int codigoPrioridad, string estado, int porcentajecompletado , int codigoRecuros ,string descripcion,DateTime fechaInicio,  DateTime fechaFin, string usuarioCreacion)
        {

            return objapi.SP_TAREA_CREATE(codigoCurso, codigoActividad, titulo,  codigoPrioridad,  estado,  porcentajecompletado,  codigoRecuros, descripcion, fechaInicio,  fechaFin,  usuarioCreacion );


        }

        [HttpGet]
        public int actualizarTarea(int codigoCurso, int codigoActividad, string titulo, int codigoPrioridad, string estado, int porcentajecompletado, int codigoRecuros, string descripcion, DateTime fechaInicio, DateTime fechaFin, string usuarioCreacion)
        {

            return objapi.SP_TAREA_CREATE(codigoCurso, codigoActividad, titulo, codigoPrioridad, estado, porcentajecompletado, codigoRecuros, descripcion, fechaInicio, fechaFin, usuarioCreacion);


        }

        

    }
}
