using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ConsoleApp2
{
    class Program
    {
         
             
        static void Main(string[] args)
        {
            string connectionString = "SERVER=d;DATABASE=d;UID=;PWD=;";

            string queryString = "SELECT   header = CMSTEST.dbo.W_FN_KeyX_WriteReportShort(202002,corp,dept_code) FROM W_TL_KeyX_List WHERE  dept_code  in ('1517')";

            queryString = " SELECT header=txt FROM W_FN_KeyX_WriteReport_Mono(202002,1,'1510') ORDER BY sort";
            //select header = dbo.W_FN_KeyX_Write_HoursSummary(202001, 1, '1510')";
            //queryString = " SELECT header=txt FROM W_FN_KeyX_WriteHoursBlock('1510','202002','ADJ',0,'test','Hours1')"; //(202002,1,'1510') ";
            /* string header = "";
             using (SqlConnection connection = new SqlConnection(connectionString))
             {
                 SqlCommand command =
                     new SqlCommand(queryString, connection);
                 connection.Open();

                 SqlDataReader reader = command.ExecuteReader();

                 while (reader.Read())
                 {
                     header = header+ reader["header"].ToString();
                 }

                 // Call Close when done reading.
                 reader.Close();
             }*/

                Console.Write("\nThis is test\n");
                Console.Write("\nThis is test\n");
        }

        
    }
}
