﻿using Dashboard.Business.Abtract;
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
    public class LogManager : ILogService
    {
        private ILogDal _logDal;
        public LogManager(ILogDal logDal)
        {
            _logDal = logDal;
        }

        public void Add(Log log,Machine machine)
        {
            _logDal.Add(log,machine);
        }

        public List<Log> GetByDate(string ip, string db, string table, string firstDate, string lastDate)
        {
            return _logDal.GetByDate(ip, db, table,firstDate,lastDate);
        }

        public List<Log> GetById(string ip, string db, string table, int startId, int finishId)
        {
            return _logDal.GetById(ip,db,table,startId,finishId);
        }

        public TimeSpan GetHoursByHours(string ip, string db, string tableName,string state, string day, string hour)
        {
            return _logDal.GetHoursByHours(ip,db,tableName,state,day,hour);
        }

        public Log GetLast(string ip, string db, string tableName)
        {
            return _logDal.GetLast(ip,db,tableName);
        }

        public Log GetLastLog(string ip, string db, string tableName)
        {
            return _logDal.GetLastLog(ip,db,tableName);
        }

        public TimeSpan GetSpendTimes(string serverIp, string serverDb, string tableName, string ip, string day)
        {
            return _logDal.GetSpendTimes(serverIp,serverDb,tableName,ip,day);
        }

        public TimeSpan SpendTime(string ip, string db, string tableName, string day, string state)
        {
            return _logDal.SpendTime(ip,db,tableName,day,state);
        }
    }
}
