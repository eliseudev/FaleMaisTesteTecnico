using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FaleMais.Domain.Entities;
using FaleMais.Domain.Interfaces;

namespace FaleMais.Domain.Services
{
    public class TarifaService : ITarifaService
    {
        private readonly ITarifaRepository _tarifaRepository;
        private readonly IPlanoRepository _planoRepository;

        public TarifaService(ITarifaRepository tarifaRepository, IPlanoRepository planoRepository)
        {
            _tarifaRepository = tarifaRepository;
            _planoRepository = planoRepository;
        }

        public List<Plano> GetPlanos()
        {
            return _planoRepository.Get();
        }

        public double SimularPreco(string origem, string destino, int duracao)
        {
            var tarifa = _tarifaRepository.Get(origem, destino);
            if(tarifa == null) return 0;

            return tarifa.Valor * duracao;
        }

        public double SimularPrecoPlano(string origem, string destino, int duracao, Guid planoId)
        {
            var tarifa = _tarifaRepository.Get(origem, destino);
            if(tarifa == null) return 0;

            var plano = _planoRepository.Get(planoId);

            return plano.Duracao switch
            {
                30 => new SimularPreco30().Simular(tarifa, duracao),
                60 => new SimularPreco60().Simular(tarifa, duracao),
                120 => new SimularPreco120().Simular(tarifa, duracao)
            };
        }
    }
}