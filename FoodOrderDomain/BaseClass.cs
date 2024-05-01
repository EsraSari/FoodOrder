using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodOrderDomain
{
    public class BaseClass
    {
        public int ID { get; set; }
        public bool Status { get; set; } = true;
        public DateTime AddedDate { get; set; } = DateTime.Now;
        public DateTime ModifiedDate { get; set; } = DateTime.Now;
    }
}
