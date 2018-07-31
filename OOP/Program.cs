using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
namespace OOP
{
    public class Student
    {
        private String studentName;
        private byte studentCourse;
        private byte studentSquad;
        private Subject[] exams;

        public Student(TextBox studentId)
        {
            String[] data = new String[3];
            String command = "SELECT STUDENTS.NAME, STUDENTS.COURSE, STUDENTS.SQUAD" +
           " FROM STUDENTS" +
           " WHERE STUDENTS.ID=@studentID";
            SqlCommand read = new SqlCommand(command, Form1.SessionConnection);
            read.Parameters.AddWithValue("studentID", studentId.Text);
            List<String> studentList = new List<String>();
            Form1.ReadDB(read, studentList, 3);
        
        }
        /*public override string ToString()
        {
            if (exams == null) return null;
            String result = null;
            foreach (Subject Sub in exams)
            {
                result = studentName + " " + studentCourse + " " + studentSquad + " " + Sub.ToString() + '\n';
            }
            result += "Средний балл: " + AvarageMark();
            return result;
        }*/
        public double AvarageMark()
        {
            var summary = 0;
            foreach(var exam in exams)
            {
                summary = summary + exam.Mark;
            }
            return (double)summary / exams.Length;
        }
        public void GetStudentData()
        {

        }
        public static bool operator == (Student a, Student b)
        {
            return (a.AvarageMark() == b.AvarageMark());
        }
        public static bool operator !=(Student a, Student b)
        {
            return (a.AvarageMark() != b.AvarageMark());
        }
        public static bool operator <(Student a, Student b)
        {
            return (a.AvarageMark() < b.AvarageMark());
        }
        public static bool operator >(Student a, Student b)
        {
            return (a.AvarageMark() > b.AvarageMark());
        }
    }
    public class Subject
    {
        private String subjectName;
        private String teacherName;
        private byte mark;

        public Subject(String[] data)
        {
            subjectName = data[0];
            teacherName = data[1];
            mark = Convert.ToByte(data[2]);
        }
        public override string ToString()
        {
            return subjectName + " " + teacherName + " " + mark;
        }

        public static List<Subject> GetSubjectFromDB(TextBox id)
        {
            List<Subject> subjects = new List<Subject>();
            var command = "SELECT SUBJECTS.NAME, SUBJECTS.TEACHER_NAME, MARKS.Mark " +
                    "FROM STUDENTS, SUBJECTS, MARKS" +
                    " WHERE MARKS.StudentID = STUDENTS.ID AND SUBJECTS.ID = MARKS.SubjectID AND STUDENTS.ID = @WrittenID";
            SqlCommand read = new SqlCommand(command, Form1.SessionConnection);
            read.Parameters.AddWithValue("WrittenID", id.Text);
            List<String> subjectList = new List<string>();
            Form1.ReadDB(read, subjectList, 3);
            foreach (var subject in subjectList)
            {
                var data = subject.Split(',');
                var sub = new Subject(data);
                subjects.Add(sub);
            }
            return subjects;
        }
        public byte Mark => mark;
        public static bool operator ==(Subject a, Subject b) => (a.mark == b.mark);
        public static bool operator !=(Subject a, Subject b) => (a.mark != b.mark);
        public static bool operator <(Subject a, Subject b)
        {
            return (a.mark < b.mark);
        }
        public static bool operator >(Subject a, Subject b)
        {
            return (a.mark > b.mark);
        }
    }
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

    }
}
