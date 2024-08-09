using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_management_system.DAL
{
    public class GradeDal
    {   
        static SqlConnection conn=new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"].ToString());
        public static DataTable GetAll()
        {   
            DataTable dt = new DataTable();
            try
            {
                SqlCommand cmd=conn.CreateCommand();
                cmd.CommandText = "select * from grades";
                if (conn.State !=ConnectionState.Open)
                {
                    conn.Open(); 
                }
                SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                dt.Load(dr);
                cmd.Dispose();
            }
            catch (Exception)
            {

                throw;
            }
            finally {
            
            }
            return dt;
        }
        public static void GetById()
        {
            MessageBox.Show("this is get all Grade Details by Id");
        }
        public static void insert(String GradeName,String GradeOrder, String GradeColor)
        {
            try
            {
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = $"INSERT INTO [dbo].[grades]([id])VALUES('{GradeName}','{GradeOrder}','{GradeColor}')";
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
           
             catch (Exception)
            {

                throw;
            }
            finally {

            }
        }

        public static void update(String GradeName, String GradeOrder, int id)
        {
            MessageBox.Show("this is update by grade");
        }
        public static void delete(int id)
        {
            MessageBox.Show("this is delete by grade");
        }

    }
           
       
    
}
