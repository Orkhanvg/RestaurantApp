using Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    class Reservation:IEntity
    {
        public DateTime Time { get; set; }
        public int Count { get; set; }
        public string Name { get; set; }
        public double TotalCost { get; set; }
    }
}
