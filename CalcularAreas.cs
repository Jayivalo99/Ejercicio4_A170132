using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AreasWS.Calcular.SOAP
{
    public class CalcularAreas
    {
		public decimal numero1 { get; set; }
		public decimal numero2 { get; set; }
		
		public decimal a;
		


		public decimal cuadrado(decimal n1)
		{
			numero1 = n1;

			return n1 * n1;
		}

		public decimal triangulo(decimal n1, decimal n2)
        {
			numero1 = n1;
			numero2 = n2;
			a = n1 * n2;
			return a / 2;
		}

		public double circulo(double n1)
		{
			return (n1 * n1) * 3.1416;
		}
	}
}