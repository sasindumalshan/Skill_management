using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skill_management.utill
{
    internal class CrudUtill
    {
        public static bool executeNonQuery(String sql) {
            MySqlConnection mySqlConnection = DBConntection.DBConection.getDB().getConection();

            MySqlCommand command = new MySqlCommand(sql, mySqlConnection);
            return  command.ExecuteNonQuery()!=0;
            
        }
        public static MySqlDataReader endExecuteReader(String sql)
        {
            MySqlConnection mySqlConnection = DBConntection.DBConection.getDB().getConection();

            MySqlCommand command = new MySqlCommand(sql, mySqlConnection);

            return command.ExecuteReader();
        }
    }
}
