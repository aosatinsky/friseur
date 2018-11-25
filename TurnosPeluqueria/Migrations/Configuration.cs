namespace TurnosPeluqueria.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using TurnosPeluqueria.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<TurnosPeluqueria.Datos.PeluqueriaContexto>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(TurnosPeluqueria.Datos.PeluqueriaContexto context)
        {
            //var peluqueros = new List<Peluquero>
            //{
            //    new Peluquero{Nombre="Gino", Apellido= "Nacchio", Dni=12345678, Usuario="ginona", Passw="ginona"},
            //    new Peluquero{Nombre="Agustin", Apellido= "Osatinsky", Dni=87654321, Usuario="aosatinsky", Passw="123456"}
            //};
            //peluqueros.ForEach(s => context.Peluqueros.Add(s));
            //context.SaveChanges();

            //var clientes = new List<Cliente>
            //{
            //    new Cliente{Nombre="Pepe", Apellido="Argento",Dni=30056987,User="pepe",Passw="argento", Email="aosatinsky@gmail.com"},
            //    new Cliente{Nombre="Armando", Apellido="Barreras",Dni=30056987,User="armando",Passw="barreras", Email="ginonacchio94@gmail.com"}
            //};
            //clientes.ForEach(s => context.Clientes.Add(s));
            //context.SaveChanges();

            //var servicios = new List<Servicio>
            //{
            //    new Servicio{Nombre="Corte",Precio=200},
            //    new Servicio{Nombre="Corte y Barba",Precio=300},
            //    new Servicio{Nombre="Color",Precio=150}
            //};
            //servicios.ForEach(s => context.Servicios.Add(s));
            //context.SaveChanges();
        }
    }
}
