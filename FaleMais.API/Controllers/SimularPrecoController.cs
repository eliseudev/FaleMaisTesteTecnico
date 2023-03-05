using System;
using FaleMais.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FaleMais.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SimularPrecoController : ControllerBase
    {
        private readonly ITarifaRepository _tarifaRepository;
        private readonly IPlanoRepository _planoRepository;
        private readonly ITarifaService _tarifaService;

        public SimularPrecoController(ITarifaRepository tarifaRepository, IPlanoRepository planoRepository, ITarifaService tarifaService)
        {
            _tarifaRepository = tarifaRepository;
            _planoRepository = planoRepository;
            _tarifaService = tarifaService;
        }

        [HttpGet("ListarTarifas")]
        public IActionResult ListarTarifas()
        {
            var tarifas = _tarifaRepository.Get();
            return Ok(tarifas);
        }

        [HttpGet("ListarPlanos")]
        public IActionResult ListarPlanos()
        {
            var planos = _planoRepository.Get();
            return Ok(planos);
        }

        [HttpGet("SimularPreco")]
        public IActionResult SimularPreco(string origen, string destino, int duracao)
        {
            var calcular = _tarifaService.SimularPreco(origen, destino, duracao);
            return Ok(calcular);
        }

        [HttpGet("SimularPrecoPlano")]
        public IActionResult SimularPrecoComPlano(string origen, string destino, int duracao, Guid planoId)
        {
            var calcular = _tarifaService.SimularPrecoPlano(origen, destino, duracao, planoId);
            return Ok(calcular);
        }
    }
}