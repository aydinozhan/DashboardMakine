﻿using Dashboard.DataAccess.Concrete;
using Dashboard.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard.DataAccess.Abtract
{
    public interface IStopReasonDal
    {
        StopReason GetLast(Machine machine);
        void Add(Machine machine,StopReason stopReason);
    }
}
