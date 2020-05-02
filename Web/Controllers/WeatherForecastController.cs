using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Javeriana.Pica.Core.Interfaces;
using Javeriana.Pica.Core.Entidades;
using Javeriana.Pica.Core.Excepciones;

namespace Javeriana.Pica.Web.Controllers
{
    [ApiController]
    [Route("api/pica/clima/pronostico")]
    public class WeatherForecastController : ControllerBase
    {

        private readonly IClima _servicioClima;

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(IClima servicio, ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
            _servicioClima = servicio;
        }

        [HttpGet("semana")]
        public IEnumerable<WeatherForecast> Get()
        {
            return _servicioClima.GetPronosotico();
        }

        [HttpGet("semana/{dia}/temp/{tipo}")]
        public ActionResult<int> Get(int dia, string tipo)
        {
            try{
                return Ok(_servicioClima.GetPronosoticoDiaTipo(dia, tipo));
            }
            catch (UnidadDeMedidaNoValidaException _)
            {
                return BadRequest(0);
            }
        }

        [HttpGet("semana/{dia}")]
        public WeatherForecast Get(int dia)
        {
            return _servicioClima.GetPronosoticoDia(dia);
        }
    }
}
