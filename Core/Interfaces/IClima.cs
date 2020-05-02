using Javeriana.Pica.Core.Entidades;
using System.Collections.Generic;

namespace Javeriana.Pica.Core.Interfaces
{
    public interface IClima
    {
        IEnumerable<WeatherForecast> GetPronosotico();

        WeatherForecast GetPronosoticoDia(int dia);

        int GetPronosoticoDiaTipo(int dia, string tipo);
    }
}