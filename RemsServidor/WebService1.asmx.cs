using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using RemsServidor.Models;

namespace RemsServidor
{
    /// <summary>
    /// Descripción breve de WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {
        Model1Container contex = new Model1Container();

        [WebMethod]
        public string HelloWorld()
        {
            return "Hola a todos";
        }


        [WebMethod]
        public List<Estudiantesw>  estudiantes()
        {



            //return contex.Estudiantes.ToList();
            return contex.Estudiantes.Select(
                x=> new Estudiantesw(){

                    Id= x.Id
                    ,Nombre= x.Nombre
                    ,Carnet= x.Carnet
                }
                )
                .ToList();

        }

        public class Estudiantesw
        {
            public int Id { get; set; }
            public string Carnet { get; set; }
            public string Nombre { get; set; }
        }
        

    }
}
