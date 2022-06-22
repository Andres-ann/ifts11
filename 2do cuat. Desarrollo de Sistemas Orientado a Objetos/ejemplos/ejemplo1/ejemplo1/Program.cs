using System;

/*
 En un comercio que despacha carnes se desea administrar los precios y descuentos de estos. El despacho trabaja con carne vacuna, porcina y aviar. Todas poseen nombre y precio por kilo. La carne vacuna indica si es un corte de novillito, la aviar indica si es de granja. El precio por kilo de la carne vacuna tendrá un recargo del 10% si es de novillito, la aviar tendrá un recargo del 25% si es de granja. Todas las carnes pueden modificar su precio.

Crear un arreglo con diferentes tipos de carnes (al menos cinco), modificar el precio de dos de ellas y mostrar la lista redefiniendo el método ToString. Mostrar ejemplos de ventas de diferentes carnes indicando el precio por kilo sin recargo, con el recargo y el total según los kilos vendidos.
 */

namespace ejemplo1
{
    internal class Program
    {
        class TipoCarne
        {
            private String _nombre;
            private Double _precioKilo;

            TipoCarne(double precioKilo)
            {
                _precioKilo = precioKilo;
            }
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
