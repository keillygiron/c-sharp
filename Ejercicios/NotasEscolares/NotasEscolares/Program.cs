using System;
using System.Collections.Generic;
using System.Text;

namespace NotasEscolares
{
    class Program
    {
        static void Main(string[] args)
        {

           Datos estudiante = new Datos();

            Console.WriteLine("Escriba el nombre: ");
            estudiante.setNombre(Console.ReadLine());

            Console.WriteLine("Escriba la matricula: ");
            estudiante.setMatricula(Console.ReadLine());

            Console.WriteLine("Ingles: ");
            estudiante.setNota1(decimal.Parse(Console.ReadLine()));

            Console.WriteLine("Matematicas: ");
            estudiante.setNota2(decimal.Parse(Console.ReadLine()));

            Console.WriteLine("Quimica: ");
            estudiante.setNota3(decimal.Parse(Console.ReadLine()));

            Console.WriteLine("Fisica: ");
            estudiante.setNota4(decimal.Parse(Console.ReadLine()));

            Console.WriteLine("Español: ");
            estudiante.setNota5(decimal.Parse(Console.ReadLine()));
            
            Console.WriteLine("****//////********************* ");
            Console.WriteLine("Nombre: "+ estudiante.getNombre());
            Console.WriteLine("Matricula: "+ estudiante.getMatricula());
            Console.WriteLine("Promedio: "+ estudiante.getPromedio());
            Console.WriteLine("Top: "+ estudiante.getTop());
            

            Console.ReadKey();
        }
    }
}
