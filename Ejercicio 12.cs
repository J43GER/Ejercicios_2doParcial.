using System;
using System.Linq; 

namespace Visual_Studio_Code
{
   /* 12 - Crear un programa que permita cargar los nombres de 5 empleados y sus salarios respectivos.
   Mostrar el salario mayor y el nombre del empleado.
   
   Crear un metodo para Cargar.
   
   Crear un metodo para calcular el salario mayor.*/
   
    class program
    { 
        
        static void Main (string[] args)
        
        {
            Cargar();
            mayor();

        }

        static void Cargar()
        {
            
            string[] nombres = new string [5];

           for (int i = 0; i <= 4; i++)
           {
               Console.WriteLine("Favor introducir nombre de empleado: ");
               nombres[i] = Console.ReadLine();
               Console.Clear();
           }  
            
        }

        static void mayor()
        {   
            int[] salarios = new int [5];

            for (int i = 0; i <= 4; i++)
            {
                Console.WriteLine("Favor introducir salario de empleado: ");
                salarios[i] = int.Parse(Console.ReadLine());
                Console.Clear();
            }

            int x = salarios.Max();

            Console.WriteLine("El salario mayor es: " + x);
             
        }



        
    } 

}
