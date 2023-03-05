using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FaleMais.Domain.Entities;

namespace FaleMais.Domain.Services
{
    public abstract class SimularPreco
    {
        public readonly double _acrecimo = 1.1;
        public abstract double Simular(Tarifa tarifa, int duracao);
    }
}