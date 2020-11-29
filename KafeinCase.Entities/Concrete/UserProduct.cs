using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KafeinCase.Core.Entities;

namespace KafeinCase.Entities.Concrete
{
    public class UserProduct : IEntity
    {
        public int UserProductId { get; set; }
        public int UserId { get; set; }
        public int ProductId { get; set; }       

    }
}
