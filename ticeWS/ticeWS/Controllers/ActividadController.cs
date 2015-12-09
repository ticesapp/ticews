using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ticeWS.Controllers
{
    public class ActividadController : ApiController
    {


        ticeEntities3 objapi = new ticeEntities3();



     

        [HttpGet]
        public int crearActividad(int codigoCurso, int codigoModalidad, int codigoPeriodo, int codigoTipoCurso, string titulo, DateTime fechaInicio, DateTime fechaFin, int codigoSesion, int codigoEstado, string descripcion, string usuarioCreacion)
        {

            return objapi.SP_ACTIVIDAD_CREATE(codigoCurso, codigoModalidad, codigoPeriodo, codigoTipoCurso, titulo, fechaInicio, fechaFin, codigoSesion, codigoEstado, descripcion, usuarioCreacion);
        

        }

        [HttpGet]
        public int actualizarActividad(int codigoActividad, int codigoCurso, int codigoModalidad, int codigoPeriodo, int codigoTipoCurso, string titulo, DateTime fechaInicio, DateTime fechaFin, int codigoSesion, int codigoEstado, string descripcion, string usuarioModificacion, DateTime fechaModificacion)
        {
            return objapi.SP_ACTIVIDAD_UPDATE(codigoActividad, codigoCurso, codigoModalidad, codigoPeriodo, codigoTipoCurso, titulo, fechaInicio, fechaFin, codigoSesion, codigoEstado, descripcion, usuarioModificacion, fechaModificacion);

        }


        //[HttpGet]
        //public string borrarActividad(int codigoActividad)
        //{
        //    try
        //    {
        //        objapi.SP_ACTIVIDAD_DELETE(codigoActividad);
        //        return "ok";
        //    }
        //    catch (Exception ex)
        //    {
        //        return "Error";

        //    }
        //}



        [HttpGet]
        public IEnumerable<SP_ACTIVIDAD_RETRIEVE_BY_CURSO_Result> listarCursosxPeriodo(string periodo, string estado)
        {
            if (periodo == null)
                periodo = "";

            if (estado == null)
                estado = "";

            return objapi.SP_ACTIVIDAD_RETRIEVE_BY_CURSO(periodo, estado).AsEnumerable();
        }



        //[HttpGet]
        //public int listarActividadesxCurso(int codigoCurso, int codigoPeriodo, int codigoModalidad)
        //{

        //    return objapi.SP_ACTIVIDAD_RETRIEVE_BY_CURSO(codigoCurso, codigoPeriodo, codigoModalidad);

        //}






    }
}
