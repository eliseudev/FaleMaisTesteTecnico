using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FaleMais.Domain.Entities
{
    public class BaseEntity
    {
        public Guid Id { get; set; }

        protected BaseEntity()
        {
            Id = Guid.NewGuid();
        }
    }
}