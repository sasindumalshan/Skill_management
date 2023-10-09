using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace Skill_management.DBConntection
{
    internal class DBConection
    {
        private static MySqlConnection connection=null;
        private static DBConection dBConection;
        private DBConection()
        {
            connection = new MySqlConnection("host=localhost;user=root;password=1234;database=student;");
            connection.Open();
        }
        public static DBConection getDB()
        {
            return dBConection==null? new DBConection():dBConection;
        }
        public  MySqlConnection getConection()
        {
            return connection;
        }
    }
}
