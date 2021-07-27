
using System.Collections.Generic;

namespace PilaresPoo
{
    class Program
    {
        static void Main(string[] args)
        {
             //Animal Mamifero= new Animal("La vaca");
            //Mamifero.comer();

            // Animal Ave = new Animal("El loro");
            //Ave.dormir();

         // Herencia
         //Mamifero objetoMamifero = new Mamifero("La vaca");
         //objetoMamifero.comer();

         //Ave objAve = new Ave("El loro");
         //objAve.dormir();   

         //polimorfismo
         Mamifero obj1 = new Mamifero("El perro");
         Mamifero obj2 = new Mamifero("La vaca");
         Mamifero obj3 = new Mamifero("El koala");
         Mamifero obj4 = new Mamifero("El canguro");
         Mamifero obj5 = new Mamifero("El leon");
         Mamifero obj6 = new Mamifero("El gato");

         List<Animal>ListaMamiferos= new List<Animal>();
         ListaMamiferos.Add(obj1);
         ListaMamiferos.Add(obj2);
         ListaMamiferos.Add(obj3);
         ListaMamiferos.Add(obj4);
         ListaMamiferos.Add(obj5);
         ListaMamiferos.Add(obj6);

         foreach (Mamifero item in ListaMamiferos)
         {
             obj1.comer();
             obj2.dormir();

             
         }

         Ave obje1 = new Ave("El loro");
         Ave obje2 = new Ave("La Agula");
         Ave obje3 = new Ave("El Buho");
         Ave obje4 = new Ave("El colibri");
         Ave obje5 = new Ave("El cuervo");
         Ave obje6 = new Ave("El flamenco");

         List<Animal>ListaAves= new List<Animal>();
         ListaAves.Add(obje1);
         ListaAves.Add(obje2);
         ListaAves.Add(obje3);
         ListaAves.Add(obje4);
         ListaAves.Add(obje5);
         ListaAves.Add(obje6);

         foreach (Ave item in ListaAves)
         {
             obje1.comer();
             obje2.dormir();
             obje3.volar();

             
         }
        
         Pez ob1 = new Pez("El pez payaso");
         Pez ob2 = new Pez("La pez mandarin");
         Pez ob3 = new Pez("El pez loro");
         Pez ob4 = new Pez("El pez cebra");
         Pez ob5 = new Pez("El pez betta");
         Pez ob6 = new Pez("El pez dorado");

         List<Animal>ListaPeces= new List<Animal>();
         ListaPeces.Add(ob1);
         ListaPeces.Add(ob2);
         ListaPeces.Add(ob3);
         ListaPeces.Add(ob4);
         ListaPeces.Add(ob5);
         ListaPeces.Add(ob6);

         foreach (Pez item in ListaPeces)
         {
             ob1.nadar();
             ob2.comer();
             


         }
    }
 }
}