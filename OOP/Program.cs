using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP
{
    public class Student
    {
        private String studentName;
        private byte studentCourse;
        private byte studentSquad;
        private Subject[] exams;

    }
    public class Subject
    {
        private String subjectName;
        private String teacherName;
        private byte mark;
        private DateTime date;

        public Subject(TextBox Name, TextBox Teacher)
        {
            subjectName = Convert.ToString(Name);
            teacherName = Convert.ToString(Teacher);
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
