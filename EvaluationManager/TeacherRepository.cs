using DBLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace EvaluationManager
{
    public static class TeacherRepository
    {
        public static Teacher GetTeacher (string username)
        {
            Teacher teacher = null;
            string sql = $"SELECT * FROM Teachers Where username = '{username}'";
            return teacher;
        }

        public static Teacher GetTeacherID(string id)
        {
            Teacher teacher = null;
            string sql = $"SELECT * FROM Teachers Where id = '{id}'";
            return teacher;
        }

        private static Teacher FetchTeacher(string sql)
        {
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            Teacher teacher = null;
            if (reader.HasRows)
            {
                reader.Read();
                teacher = CreateObject(reader);
                reader.Close();
            }
            DB.CloseConnection();
            return teacher;
        }

        private static Teacher CreateObject(SqlDataReader reader)
        {
            int id = int.Parse(reader["Id"].ToString());
            string firstName = reader["FirstName"].ToString();
            string lastName = reader["LastName"].ToString();
            string password = reader["Password"].ToString();
            var teacher = new Teacher
            {
                Id = id,
                FirstName = firstName,
                LastName = lastName,
                Password = password

            };
            return teacher;
        }
    }
}
