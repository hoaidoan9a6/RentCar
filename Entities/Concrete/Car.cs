using System;
using Core;

namespace Entities.Concrete
{
    public interface Brand : IEntity
    {
        public int BrandId { get; set; }
        public string BrandName { get; set; }
    }
}
