using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendProje.Entity.Abstract
{
    public interface IBaseEntity
    {
        public int Id { get; set; }
        public bool Status { get; set; }
    }
}
