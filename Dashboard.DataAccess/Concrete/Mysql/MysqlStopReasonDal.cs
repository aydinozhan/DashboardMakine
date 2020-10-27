using Dashboard.DataAccess.Abtract;
using Dashboard.Entities.Concrete;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard.DataAccess.Concrete.Mysql
{
    public class MysqlStopReasonDal : IStopReasonDal
    {
        string _serverIp = "172.16.0.221";
        string _serverBackupDb = "Backup";
        private string _raspiDb = "Machine";
        private string _raspiStopReasonTable = "StopReasons";
        MySqlConnection _conn;

        public void Add(Machine machine,StopReason stopReason)
        {
            string connString = string.Format("server={0};user=root;database={1};port=3306;password=root;Connection Timeout=1", machine.Ip, _raspiDb);
            try
            {
                using (_conn = new MySqlConnection(connString))
                {
                    string query = "insert into StopReasons (Start,Finish,Time,Reason) values (@Start,@Finish,@,@Time,@Reason)";
                    using (MySqlCommand cmd = new MySqlCommand(query, _conn))
                    {
                        _conn.Open();
                        cmd.Parameters.AddWithValue("@Start", stopReason.Start);
                        cmd.Parameters.AddWithValue("@Finish", stopReason.Finish);
                        cmd.Parameters.AddWithValue("@Time", stopReason.Time);
                        cmd.Parameters.AddWithValue("@Reason", stopReason.Reason);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("stopreasondal add sıkıntı var" + e);
            }
        }

        public StopReason GetLast(Machine machine)
        {
            string connString = string.Format("server={0};user=root;database={1};port=3306;password=root;Connection Timeout=1", machine.Ip, _raspiDb);
            StopReason sr = new StopReason();
            try
            {
                using (_conn = new MySqlConnection(connString))
                {
                    string query = string.Format("select * from {0} order by Id desc limit 1", _raspiStopReasonTable);
                    using (MySqlCommand cmd = new MySqlCommand(query, _conn))
                    {
                        _conn.Open();
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                sr.Id = reader.GetInt32(0);
                                sr.Start = reader.GetDateTime(1);
                                sr.Finish = reader.GetDateTime(2);
                                sr.Time = reader.GetTimeSpan(3);
                                sr.Reason = reader.GetInt32(4);
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("stopreasondal  getlast'de sıkıntı var\n" + e);
            }
            return sr;
        }
    }
}
