using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace AreasWS.Calcular.SOAP
{
    /// <summary>
    /// Descripción breve de AreasService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class AreasService : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hola a todos";
        }

        [WebMethod]
        public decimal cuadrado(decimal n1)
        {
            CalcularAreas c = new CalcularAreas();
            c.numero1 = n1;
           
            return c.cuadrado(n1);
        }
        [WebMethod]
        public decimal triangulo(decimal n1, decimal n2)
        {
            CalcularAreas c = new CalcularAreas();
            c.numero1 = n1;
            c.numero2 = n2;
            return c.triangulo(n1, n2);
        }
        [WebMethod]
        public double circulo(double n1)
        {
            CalcularAreas c = new CalcularAreas();
            //c.numero1 = n1;
            return c.circulo(n1);
        }
    }
}
