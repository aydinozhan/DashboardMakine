using Dashboard.Business.Abtract;
using Dashboard.DataAccess.Abtract;
using Dashboard.DataAccess.Concrete;
using Dashboard.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard.Business.Concrete
{
    public class StopReasonManager : IStopReasonService
    {
        private IStopReasonDal _stopReasonDal;
        public StopReasonManager(IStopReasonDal stopReasonDal)
        {
            _stopReasonDal = stopReasonDal;
        }

        public void Add(Machine machine, StopReason stopReason)
        {
            _stopReasonDal.Add(machine,stopReason);
        }

        public StopReason GetLast(Machine machine)
        {
            return _stopReasonDal.GetLast(machine);
        }
    }
}
