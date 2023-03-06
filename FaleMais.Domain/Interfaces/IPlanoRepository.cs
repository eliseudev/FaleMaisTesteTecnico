using System;
using System.Collections.Generic;
using FaleMais.Domain.Entities;

namespace FaleMais.Domain.Interfaces
{
	public interface IPlanoRepository
	{
		List<Plano> Get();
		Plano Get(Guid id);
	}
}

