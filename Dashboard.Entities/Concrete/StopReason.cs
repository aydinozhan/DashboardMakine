using Dashboard.Entities.Abtract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard.Entities.Concrete
{
    public class StopReason:IEntity
    {
        public int Id { get; set; }
        public DateTime Start { get; set; }
        public DateTime Finish { get; set; }
        public TimeSpan Time { get; set; }
        public string Reason { get; set; }
    }
}
