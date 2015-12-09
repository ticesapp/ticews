using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ticeWS.Controllers
{
    public class CapacitacionController : ApiController
    {
        //ticeEntities objapi = new ticeEntities();

        ticeEntities3 objapi = new ticeEntities3();


        [HttpGet]
        public IEnumerable<SP_CAPACITACION_LOAD_Result> listarCursosxPeriodo(int codigoTaller, int codigoPeriodo, string nombreCapacitacion)
        {
        

            return objapi.SP_CAPACITACION_LOAD(codigoTaller,codigoPeriodo, nombreCapacitacion).AsEnumerable();
        }

        [HttpGet]
        public IEnumerable<SP_PARTICIPANTES_CAPACITACION_RETRIEVE_BY_CAPACITACION_Result> listarParticipantesxCapacitacion(int codigoCapacitacion)
        {
            return objapi.SP_PARTICIPANTES_CAPACITACION_RETRIEVE_BY_CAPACITACION(codigoCapacitacion).AsEnumerable();
        }

        [HttpGet]
        public IEnumerable<SP_MATERIAL_CAPACITACION_RETRIEVE_BY_CAPACITACION_Result> listarMaterialxCapacitacion(int codigoCapacitacion)
        {
            return objapi.SP_MATERIAL_CAPACITACION_RETRIEVE_BY_CAPACITACION(codigoCapacitacion).AsEnumerable();
        }


        //[HttpGet]
        //public int  crearCapacidad(string nombre,bool certificado, int codigoPerido,string descripcion, string correoContacto, bool enviarNotificacion,int periodicidadEnvio, DateTime fechaInicio, bool capacitacionActiva, int codigoTaller, DateTime fechaCreacion, DateTime fechaModificacion, string usuarioCreacion, string usuarioModificacion, string lugar, DateTime fechaInicioEnvio,  DateTime fechaCapacitacion )
        //{

        //    return objapi.SP_CAPACITACION_CREATE(nombre, certificado, codigoPerido, descripcion, correoContacto, enviarNotificacion, periodicidadEnvio, fechaInicio, capacitacionActiva, codigoTaller, fechaCreacion, fechaModificacion, usuarioCreacion, usuarioModificacion, lugar, fechaInicioEnvio, fechaCapacitacion);

        //}








    }
}
