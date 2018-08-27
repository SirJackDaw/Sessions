using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            var connectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = 
C:\Users\Дмитрий\Documents\Visual Studio 2015\Projects\OOP\OOP\SessionDB.mdf; Integrated Security = True; MultipleActiveResultSets = True";
            SessionConnection = new SqlConnection(connectionString);
            await SessionConnection.OpenAsync();
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (SessionConnection != null || SessionConnection.State != ConnectionState.Closed)
                SessionConnection.Close();
            students.Clear();
        }
        public static SqlConnection SessionConnection;
        public static List<Student> students = new List<Student>();

        private bool CheckEmpty(bool message, params TextBox[] fields)
        {
            foreach (var field in fields)
                if (string.IsNullOrEmpty(field.Text) && string.IsNullOrWhiteSpace(field.Text))
                {
                    if (message) { MessageBox.Show("Не все поля заполнены", "Ошибка"); }
                    return false;
                }
            return true;
        }
        public bool CheckCorrectness(String checkParameter, TextBox parameter, int min, int max)
        {
            byte resultOfTrying;
            bool result = Byte.TryParse(parameter.Text, out resultOfTrying);
            if ((result == false) || (Convert.ToByte(parameter.Text) < min || Convert.ToByte(parameter.Text) > max))
            {
                { MessageBox.Show(checkParameter + " может быть числом от " + min + " до " + max, "Ошибка"); }
                return false;
            }
            return true;
        }
        public bool CheckCorrectness(String checkParameter, TextBox parameter)
        {
            byte resultOfTrying;
            bool result = Byte.TryParse(parameter.Text, out resultOfTrying);

            if (result == false)
            {
                { MessageBox.Show(checkParameter + " должно быть числом", "Ошибка"); }
                return false;
            }
            return true;
        }
        public bool CheckCorrectness(String checkParameter, TextBox parameter, long min)
        {
            long resultOfTrying;
            bool result = Int64.TryParse(parameter.Text, out resultOfTrying);
            if ((result != true) && ((Convert.ToInt64(parameter.Text) < min) || (Convert.ToInt64(parameter.Text) > Int64.MaxValue)))
            {
                { MessageBox.Show(checkParameter + " может быть числом от " + min + " до " + Int64.MaxValue, "Ошибка"); }
                return false;
            }
            return true;
        }
        public async void PutToLBAsync(SqlCommand command, ListBox dBShow, int numberOfColumns)
        {
            SqlDataReader reader = null;
            try
            {
                reader = await command.ExecuteReaderAsync();
                while (await reader.ReadAsync())
                {
                    String rec = null;
                    for (var i = 0; i < numberOfColumns; i++)
                    {
                        rec = rec + Convert.ToString(reader[i]) + " ";

                    }
                    dBShow.Items.Add(rec);
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
        private void GenerateLogs(String message)
        {
            var log = DateTime.Now.ToString() + " " + message;
            lBLogs.Items.Add(log);
        }
        /*
         * События стрипа "Предмет/Студент"
         */
        private async void btnCreateSubject_Click(object sender, EventArgs e)
        {
            if (CheckEmpty(true, tbTeachName, tbSubName))
            {
                SqlCommand command = new SqlCommand("INSERT INTO [SUBJECTS] (Name, Teacher_Name) VALUES (@Name, @Teacher)", SessionConnection);
                command.Parameters.AddWithValue("Name", tbSubName.Text);
                command.Parameters.AddWithValue("Teacher", tbTeachName.Text);
                await command.ExecuteNonQueryAsync();
                GenerateLogs("Создан предмет: " + tbSubName.Text);
                tbTeachName.Clear();
                tbSubName.Clear();
            }
        }
        private async void btnCreateStudent_Click(object sender, EventArgs e)
        {
            if (CheckEmpty(true, tbStudName, tbStudGroup, tbStudGroup) && CheckCorrectness("Группа", tbStudGroup, 1, 20) && CheckCorrectness("Курс", tbStudCourse, 1, 6))
            {
                SqlCommand command = new SqlCommand("INSERT INTO [STUDENTS] (Name, Course, Squad) VALUES (@Name, @Course, @Squad)", SessionConnection);
                command.Parameters.AddWithValue("Name", tbStudName.Text);
                command.Parameters.AddWithValue("Course", tbStudCourse.Text);
                command.Parameters.AddWithValue("Squad", tbStudGroup.Text);
                await command.ExecuteNonQueryAsync();
                GenerateLogs("Создан студент: " + tbStudName.Text);
                tbStudCourse.Clear();
                tbStudGroup.Clear();
                tbStudName.Clear();
            }
        }
        private async void btnDelSub_Click(object sender, EventArgs e)
        {
            if(CheckEmpty(true, tBIDSubject) && CheckCorrectness("ID предмета", tBIDSubject, 1))
            {
                var command = "DELETE FROM [SUBJECTS] WHERE [ID] = @SubID " +
                    "DELETE FROM [MARKS] WHERE [SubjectID] = @SubID";
                SqlCommand delete = new SqlCommand(command, SessionConnection);
                delete.Parameters.AddWithValue("SubID", tBIDSubject.Text);
                await delete.ExecuteNonQueryAsync();
                GenerateLogs("Удалён предмет с ID" + tBIDSubject.Text);
                tBIDSubject.Clear();
            }
        }

        private async void btnDelStud_Click(object sender, EventArgs e)
        {
            if (CheckEmpty(true, tBIDStudent) && CheckCorrectness("ID студента", tBIDStudent, 1))
            {
                var command = "DELETE FROM [STUDENTS] WHERE [ID] = @StudID " +
                    "DELETE FROM [MARKS] WHERE [StudentID] = @StudID";
                SqlCommand delete = new SqlCommand(command, SessionConnection);
                delete.Parameters.AddWithValue("StudID", tBIDStudent.Text);
                await delete.ExecuteNonQueryAsync();
                GenerateLogs("Удалён студент с ID" + tBIDStudent.Text);
                tBIDSubject.Clear();
            }
        }
        /*
         * Показ студентов и предметов(пространство справа)
         */
        private void btnSSub_Click(object sender, EventArgs e)
        {
            dBShSub.Items.Clear();
            SqlCommand command = new SqlCommand("SELECT * FROM [SUBJECTS]", SessionConnection);
            PutToLBAsync(command, dBShSub, 3);
        }

        private void btnSStud_Click(object sender, EventArgs e)
        {
            dBShStud.Items.Clear();
            SqlCommand command = new SqlCommand("SELECT * FROM [STUDENTS]", SessionConnection);
            PutToLBAsync(command, dBShStud, 4);
        }
        

        /*
         * События стрипа "Оценки"
         */
        private async void btnPutMark_Click(object sender, EventArgs e)
        {
            if(CheckEmpty(true, tBStudID, tBSubID, tBMark) && CheckCorrectness("ID Студента", tBStudID) && CheckCorrectness("ID Предмета", tBSubID) && CheckCorrectness("Оценка", tBMark, 1, 100))
            {
                SqlCommand delMark = new SqlCommand("DELETE FROM [MARKS] WHERE [SubjectID] = @SubID AND [StudentID] = @StudID", SessionConnection);
                SqlCommand putMark = new SqlCommand("INSERT INTO [MARKS] (StudentID, SubjectID, Mark) VALUES (@StudentID, @SubjectID, @Mark)", SessionConnection);
                putMark.Parameters.AddWithValue("StudentID", tBStudID.Text);
                putMark.Parameters.AddWithValue("SubjectID", tBSubID.Text);
                putMark.Parameters.AddWithValue("Mark", tBMark.Text);
                delMark.Parameters.AddWithValue("StudID", tBStudID.Text);
                delMark.Parameters.AddWithValue("SubID", tBSubID.Text);
                delMark.ExecuteNonQuery();
                await putMark.ExecuteNonQueryAsync();
                GenerateLogs("Поставлена оценка: " + tBMark.Text + " студенту " + tBStudID.Text + " за предмет" + tBSubID.Text);
                tBStudID.Clear();
                tBSubID.Clear();
                tBMark.Clear();
            }
        }

        private async void btnDelMark_Click(object sender, EventArgs e)
        {
            String command = null, log = null;
            if (CheckEmpty(false, tBStudID, tBSubID))
            {
                command = "DELETE FROM [MARKS] WHERE [SubjectID] = @SubID AND [StudentID] = @StudID";
                log = "Удалена оценка за предмет " + tBSubID.Text + " студента " + tBStudID.Text; 
            }
            else if (CheckEmpty(false, tBStudID))
            {
                command = "DELETE FROM [MARKS] WHERE [StudentID] = @StudID";
                log = "Удалены все оценки студента " + tBStudID.Text;
            }
            else if (CheckEmpty(false, tBSubID))
            {
                command = "DELETE FROM [MARKS] WHERE [SubjectID] = @SubID";
                log = "Удалены все оценки за предмет " + tBSubID.Text;
            }
            SqlCommand delete = new SqlCommand(command, SessionConnection);
            delete.Parameters.AddWithValue("SubID", tBSubID.Text);
            delete.Parameters.AddWithValue("StudID", tBStudID.Text);
            await delete.ExecuteNonQueryAsync();
            GenerateLogs(log);
            tBStudID.Clear();
            tBSubID.Clear();
            tBMark.Clear();            
        }
        /*
         * События стрипа "Найти"
         */
        private void btnShowAll_Click(object sender, EventArgs e)
        {
            if (CheckEmpty(true, tBID) && CheckCorrectness("ID", tBID, 1))
            {
                bool withAvarageMark = false;
                Student student = new Student(tBID);
                students.Add(student);
                if (rBMidMark.Checked)
                {
                    if (cBAM.Checked) withAvarageMark = true;
                    students.Sort();
                    students.Reverse();
                    foreach (var stud in students) stud.FillListBox(withAvarageMark,lbIDs);
                }
                else
                {
                    lbIDs.Items.Clear();
                    if (cBAM.Checked) withAvarageMark = true;
                    student.FillListBox(withAvarageMark ,lbIDs);
                }
            }

        }
        
        private void btnClear_Click(object sender, EventArgs e)
        {
            lbIDs.Items.Clear();
            students.Clear();
        }

       
    }
}
