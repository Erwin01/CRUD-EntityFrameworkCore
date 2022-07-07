using CRUDEntityFramework.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace CRUDEntityFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            //Model-First: Scaffold-DbContext "Server=.\SQLExpress;Database=SchoolDB;Trusted_Connection=True;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models
            using (var mundo = new MundoContext())
            {
                var paises = mundo.Paises.Include(c => c.Continente).ToList();

                foreach (var pais in paises)
                {
                    Console.WriteLine($"Continente {pais.Continente.Name}, País {pais.Name}");
                }
            }

            //Code-First: add-migration 20210610031757_ContinentesPaises / update-database.
            using (var mundo = new Contexto())
            {
                var paises = mundo.Paises.Include(c => c.Continente).ToList();

                foreach (var pais in paises)
                {
                    Console.WriteLine($"Continente {pais.Continente.Name}, País {pais.Name}");
                }
                //var continente = new Continente()
                //{
                //    Name = "Europa"
                //};

                //var pais = new Pais()
                //{
                //    Name = "España"
                //};

                //continente.Paises.Add(pais);

                //pais = new Pais()
                //{
                //    Name = "Holanda"
                //};

                //continente.Paises.Add(pais);

                //mundo.Continentes.Add(continente);                

                //mundo.SaveChanges();               

                //var contienentes = mundo.Continentes.Include(c => c.Paises).ToList();

                //foreach (var contienente in contienentes)
                //{
                //    Console.WriteLine("Continente " + contienente.Name +", Paises");                   
                //    contienente.Paises.ForEach(p => Console.WriteLine(p.Name));
                //}               

                //var paisActualizar = continente.Paises.First(p => p.Name == "Holanda");
                //paisActualizar.Name = "Paises Bajos";

                //mundo.Update(paisActualizar);
                //mundo.SaveChanges();                

                //foreach (var contienente in contienentes)
                //{
                //    Console.WriteLine("Continente " + contienente.Name + ", Paises");                    
                //    contienente.Paises.ForEach(p => Console.WriteLine(p.Name));
                //}               

                //var paisEliminar = continente.Paises.First(p => p.Name == "España");                

                //mundo.Remove(paisEliminar);
                //mundo.SaveChanges();               

                //foreach (var contienente in contienentes)
                //{
                //    Console.WriteLine("Continente " + contienente.Name + ", Paises");
                //    contienente.Paises.ForEach(p => Console.WriteLine(p.Name));
                //}                

            }


        }
    }






}
