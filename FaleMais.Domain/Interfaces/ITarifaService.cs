using System;
using FaleMais.Domain.Entities;
using System.Collections.Generic;

namespace FaleMais.Domain.Interfaces
{
	public interface ITarifaService
	{
        List<Plano> GetPlanos();
        double SimularPreco(string origem, string destino, int duracao);
        double SimularPrecoPlano(string origem, string destino, int duracao, Guid planoId);
    }
}

