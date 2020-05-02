using System;
using System.Linq;
using Javeriana.Pica.Core.Interfaces;
using Javeriana.Pica.Core.Entidades;
using Javeriana.Pica.Core.Excepciones;
using System.Collections.Generic;

namespace Javeriana.Pica.Core.Servicios
{
    public class Clima : IClima
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        public IEnumerable<WeatherForecast> GetPronosotico(){
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }

        public WeatherForecast GetPronosoticoDia(int dia)
        {
            var rng = new Random();
            return new WeatherForecast
            {
                Date = DateTime.Now.AddDays(dia),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            };
        }

        public int GetPronosoticoDiaTipo(int dia, string tipo)
        {
            var rng = new Random();
            var pronostico = new WeatherForecast
            {
                Date = DateTime.Now.AddDays(dia),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            };

            switch (tipo)
            {
                case "c": return pronostico.TemperatureC;
                case "f": return pronostico.TemperatureF;
                default: throw new UnidadDeMedidaNoValidaException();
            }
        }
    }
    
}