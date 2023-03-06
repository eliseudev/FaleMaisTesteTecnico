using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FaleMais.Domain.Entities;
using FaleMais.Domain.Interfaces;

namespace FaleMais.Data.Repository
{
    public class PlanoRepository : IPlanoRepository
    {  
        public List<Plano> Get()
        {
            return _plano.ToList();
        }

        public Plano Get(Guid id)
        {
            return _plano.FirstOrDefault(p => p.Id == id);
        }

        private readonly List<Plano> _plano = new List<Plano>
        {
            new Plano(Guid.Parse("513cc232-8ebe-4272-b614-a9c71542e861"), "FaleMais 30",  30),
            new Plano(Guid.Parse("2b8eaf7b-e079-48ad-a897-037c619187a5"), "FaleMais 60", 60),
            new Plano(Guid.Parse("05f4c920-a589-4111-be15-3be5449d6509"),"FaleMais 120", 120)
        };
    }
}