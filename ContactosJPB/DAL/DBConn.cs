using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using EN;

namespace DAL
{
    public class DBConn
    {

        private static string server1 = "Proserver";
        private static string base1 = "IntelisisTmp";
        private static string usr1 = "jjpicazo"; // "UsrExamen";
        private static string pwd1 = "Visual73"; // "UsrExamen";
        private static string conn1 = @"Data Source=" + server1 + ";Initial Catalog=" + base1 + ";User ID=" + usr1 + ";Password=" + pwd1;

        public static IDbConnection conexion()
        {

            return new SqlConnection(conn1);
        }

        public static IDbCommand Comandos(string pcomando, IDbConnection pcnn)
        {
            return new SqlCommand(pcomando, pcnn as SqlConnection);
        }

    }
}
