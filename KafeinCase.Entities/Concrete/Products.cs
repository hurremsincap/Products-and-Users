using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KafeinCase.Core.Entities;

namespace KafeinCase.Entities.Concrete
{
    public class Products : IEntity
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string ProductImageUrl { get; set; }

    }
}
