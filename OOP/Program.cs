using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
namespace OOP
{
    public class Student : IComparable<Student>
    {
        private String studentName;
        private byte studentCourse;
        private byte studentSquad;
        private List<Subject> exams;

        public Student(TextBox id)
        {
            var data = new String [3];
            //var subjects = new List<Subject>();
            exams = new List<Subject>();
            GetStudentFromDB(id, data);
            Subject.GetSubjectFromDB(id, exams);
            studentName = data[0];
            studentCourse = Convert.ToByte(data[1]);
            studentSquad = Convert.ToByte(data[2]);
        }
        public int CompareTo(Student student)
        {
                return this.AvarageMark().CompareTo(student.AvarageMark());
        }
        public void GetStudentFromDB(TextBox id, String[] data)
        {
                    String command = "SELECT STUDENTS.NAME, STUDENTS.COURSE, STUDENTS.SQUAD" +
                         " FROM STUDENTS" +
                         " WHERE STUDENTS.ID=@WrittenID";
                    SqlCommand read = new SqlCommand(command, Form1.SessionConnection);
                    read.Parameters.AddWithValue("WrittenID", id.Text);
                    SqlDataReader reader = null;
                    try
                    {
                        reader = read.ExecuteReader();
                        while (reader.Read())
                        {
                            for (var i = 0; i < 3; i++)
                            {
                                data[i] = Convert.ToString(reader[i]);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        if (reader != null) reader.Close();
                    }
        }
        public double AvarageMark()
        {
            var summary = 0;
            foreach(var exam in exams)
            {
                summary = summary + exam.Mark;
            }
            return (double)summary / exams.Count;
        }
        /*
         * Перегрузки операторов и методы возвращения значений
         */
        public override bool Equals(object input)
        {
            if((input is Student) && (((Student)input).AvarageMark() == this.AvarageMark()))
            {
                    return true;
            }
            return false;
        }
        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }
        public static bool operator ==(Student a, Student b) => a.Equals(b);
        public static bool operator !=(Student a, Student b) => !a.Equals(b);
        public static bool operator <(Student a, Student b) => (a.AvarageMark() < b.AvarageMark());
        public static bool operator >(Student a, Student b) => (a.AvarageMark() > b.AvarageMark());
        public override string ToString()
        {
            String result = studentName + " " + studentCourse + " " + studentSquad + ' ';
            return result;
        }
        public void FillListBox(bool withAvarageMark, ListBox listBox)
        {
            foreach (var exam in exams)
            {
                String line = ToString() + exam.ToString();
                listBox.Items.Add(line);
            }
            if(withAvarageMark) listBox.Items.Add("Средний балл: " + AvarageMark());
        }


    }
    public class Subject : IComparable<Subject>
    {
        private String subjectName;
        private String teacherName;
        private byte mark;

        public int CompareTo(Subject subject)
        {
                return this.mark.CompareTo(subject.mark);

        }
        public Subject(String[] data)
        {
            subjectName = data[0];
            teacherName = data[1];
            mark = Convert.ToByte(data[2]);
        }
        public static void GetSubjectFromDB(TextBox id, List<Subject> subjects)
        /*Не разобрался в асинхронных процессах, поэтому такая реализация*/
        {
            var command = "SELECT SUBJECTS.NAME, SUBJECTS.TEACHER_NAME, MARKS.Mark " +
                    "FROM STUDENTS, SUBJECTS, MARKS" +
                    " WHERE MARKS.StudentID = STUDENTS.ID AND SUBJECTS.ID = MARKS.SubjectID AND STUDENTS.ID = @WrittenID";
            SqlCommand read = new SqlCommand(command, Form1.SessionConnection);
            read.Parameters.AddWithValue("WrittenID", id.Text);
            SqlDataReader reader = null;
            try
            {
                reader =  read.ExecuteReader();
                while ( reader.Read())
                {
                    var data = new String[3];
                    for (var i = 0; i < 3; i++)
                    {
                        data[i] = Convert.ToString(reader[i]);
                    }
                    var sub = new Subject(data);
                    subjects.Add(sub);
                    subjects.Sort();
                    subjects.Reverse();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (reader != null) reader.Close();
            }
        }
        /*
         * Перегрузки операторов и методы возвращения значений
         */
        public byte Mark => mark;
        public static bool operator ==(Subject a, Subject b) => (a.Mark == b.Mark);
        public static bool operator !=(Subject a, Subject b) => (a.Mark != b.Mark);
        public static bool operator <(Subject a, Subject b) => (a.Mark < b.Mark);
        public static bool operator >(Subject a, Subject b) => (a.Mark > b.Mark);
        public override string ToString()
        {
            return subjectName + " " + teacherName + " " + mark;
        }
    }
    static class Program
    {

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

    }
}
