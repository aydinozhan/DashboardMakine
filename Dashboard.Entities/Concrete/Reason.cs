using Dashboard.Entities.Abtract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard.Entities.Concrete
{
    public class Reason:IEntity
    {
        public int Id { get; set; }
        public string Explanation { get; set; }
    }
}
