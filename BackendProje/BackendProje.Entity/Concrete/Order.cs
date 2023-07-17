using BackendProje.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendProje.Entity.Concrete
{
    public class Order : IBaseEntity
    {
        public int Id { get; set; }
        public bool Status { get; set; }
        public int Count { get; set; }
        public string Address { get; set; } 
    }
}
