using BackendProje.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendProje.Entity.Concrete
{
    public class Product : IBaseEntity
    {
        public int Id { get; set; }
        public bool Status { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}
