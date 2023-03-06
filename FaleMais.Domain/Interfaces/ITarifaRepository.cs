using System;
using FaleMais.Domain.Entities;
using System.Collections.Generic;

namespace FaleMais.Domain.Interfaces
{
	public interface ITarifaRepository
	{
        List<Tarifa> Get();
        Tarifa Get(string origem, string destino);
    }
}

