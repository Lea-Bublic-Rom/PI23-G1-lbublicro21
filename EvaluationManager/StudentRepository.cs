using System;

public class StudentRepository 
    {
    private static Student CreateObject(SqlDataReader reader) {
        int id = int.Parse(reader["Id"].ToString());
        string firstName = reader["FirstName"].ToString();
        string lastName = reader["LastName"].ToString();
        int.TryParse(reader["Grade"].ToString(), out int grade);
        var student = new Student {
            Id = id,
            FirstName = firstName,
            LastName = lastName,
            Grade = grade
        };
        return student;
    }


    public static Student GetStudent(int id) {
        Student student = null;
        string sql = $"SELECT * FROM Students WHERE Id = {id}";
        DB.OpenConnection();
        var reader = DB.GetDataReader(sql);
        if (reader.HasRows) {
            reader.Read();
            student = CreateObject(reader);
            reader.Close();
        }
        DB.CloseConnection();
        return student;
    }

    public static List<Student> GetStudents() {
        List<Student> students = new List<Student>();
        string sql = "SELECT * FROM Students";
        DB.OpenConnection();
        var reader = DB.GetDataReader(sql);
        while (reader.Read()) {
            Student student = CreateObject(reader);
            students.Add(student);
        }
        reader.Close();
        DB.CloseConnection();
        return students;
    }

    private void ShowStudents() {
        List<Student> students = StudentRepository.GetStudents();
        dgvStudents.DataSource = students;
        dgvStudents.Columns["Id"].DisplayIndex = 0;
        dgvStudents.Columns["FirstName"].DisplayIndex = 1;
        dgvStudents.Columns["LastName"].DisplayIndex = 2;
        dgvStudents.Columns["Grade"].DisplayIndex = 3;
    }


}
