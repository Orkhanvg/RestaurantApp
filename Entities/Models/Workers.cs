using Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    class Workers:IEntity
    {
        public String Name { get; set; }
        public int Count { get; set; }
        public double  Salary { get; set; }
    }
}
