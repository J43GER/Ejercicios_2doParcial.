using System;
using System.Linq; 

namespace Visual_Studio_Code
{
   /* 11 -Crear una aplicación que simule una maquina expendora
      de alimentos. Debe tener un maximo de 10 productos y solo
      debe aceptar monedas (5,10,25) y billetes (50,100 y 200).
      
      Clase Producto: nombre, precio, existencia. 
      
      Al final el sistema debe mostrar cuales productos se vendieron 
      y cuantos quedaron de cada productos.*/

      class Program 
      {
          static void Main ()
          {

          }
      }

    class Producto
    {
        string nombre;
        int precio;
        int existencia;

        static void main ()
        {
            Producto[] productos = new Producto[6];
            
            productos[0].nombre = "Papas";
            productos[0].precio = 15;
            productos[0].existencia = 10;

            productos[1].nombre = "Chocolate";
            productos[1].precio = 20;
            productos[1].existencia = 10;

            productos[2].nombre = "Agua";
            productos[2].precio = 10;
            productos[2].existencia = 10;

            productos[3].nombre = "Refresco";
            productos[3].precio = 15;
            productos[3].existencia = 10;

            productos[4].nombre = "Pizza";
            productos[4].precio = 25;
            productos[4].existencia = 10;

            productos[5].nombre = "Café";
            productos[5].precio = 20;
            productos[5].existencia = 10;

        }


    }
}
