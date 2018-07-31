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
        public static async void ReadDB(SqlCommand command, List<String> result, int numberOfColumns)//исправить, сделать без явного задания кол-ва строк
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
                        rec = rec + Convert.ToString(reader[i]) + ",";

                    }
                    result.Add(rec);
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
        public async void ReadDB(SqlCommand command, ListBox dBShow, int numberOfColumns)//исправить, сделать без явного задания кол-ва строк
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

        private async void btnCreateSubject_Click(object sender, EventArgs e)
        {
            //проверка условий, все ли данные соотвествуют типам, пустота строк
            //запись в логи о создании предмета
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
            //проверка условий, все ли данные соотвествуют типам, пустота строк
            //запись в логи о создании предмета
            if (CheckEmpty(true, tbStudName, tbStudGroup, tbStudGroup))
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

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (SessionConnection != null || SessionConnection.State != ConnectionState.Closed)
                SessionConnection.Close();
            students.Clear();
        }

        private void btnSSub_Click(object sender, EventArgs e)
        {
            dBShSub.Items.Clear();
            SqlCommand command = new SqlCommand("SELECT * FROM [SUBJECTS]", SessionConnection);
            ReadDB(command, dBShSub, 3);
        }

        private void btnSStud_Click(object sender, EventArgs e)
        {
            dBShStud.Items.Clear();
            SqlCommand command = new SqlCommand("SELECT * FROM [STUDENTS]", SessionConnection);
            ReadDB(command, dBShStud, 4);
        }
        private async void btnPutMark_Click(object sender, EventArgs e)
        {
            if(CheckEmpty(true, tBStudID, tBSubID, tBMark))
            {
                SqlCommand putMark = new SqlCommand("INSERT INTO [MARKS] (StudentID, SubjectID, Mark) VALUES (@StudentID, @SubjectID, @Mark)", SessionConnection);
                putMark.Parameters.AddWithValue("StudentID", tBStudID.Text);
                putMark.Parameters.AddWithValue("SubjectID", tBSubID.Text);
                putMark.Parameters.AddWithValue("Mark", tBMark.Text);
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

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            Student student = new Student(tBID);
            students.Add(student);
            lbIDs.Items.Add(student.ToString());

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lbIDs.Items.Clear();
            students.Clear();
        }
    }
}
