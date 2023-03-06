using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FaleMais.Domain.Entities;
using FaleMais.Domain.Interfaces;

namespace FaleMais.Data.Repository
{
    public class TarifaRepository : ITarifaRepository
    {
        public void Add(Tarifa tarifa)
        {
            _tarifa.Add(tarifa);
        }

        public List<Tarifa> Get()
        {
           return _tarifa.ToList();
        }

        public Tarifa Get(Guid id)
        {
            return _tarifa.FirstOrDefault(t => t.Id == id);
        }

        public Tarifa Get(string origem, string destino)
        {
            return _tarifa.FirstOrDefault(t => t.Origem.Equals(origem) && t.Destino.Equals(destino));
        }

        private readonly List<Tarifa> _tarifa = new List<Tarifa>
        {
            new Tarifa("011", "016", 1.90),
            new Tarifa("016", "011", 2.90),
            new Tarifa("011", "017",  1.70),
            new Tarifa("017", "011", 2.70),
            new Tarifa("011", "018", 0.90),
            new Tarifa("018", "011", 1.90)
        };
    }
}