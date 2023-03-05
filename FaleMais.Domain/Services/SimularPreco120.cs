using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FaleMais.Domain.Entities;

namespace FaleMais.Domain.Services
{
    public class SimularPreco120 : SimularPreco
    {
        public override double Simular(Tarifa tarifa, int duracao)
        {
            return duracao > 120 ? tarifa.Valor * _acrecimo * duracao : 0;
        }
    }
}