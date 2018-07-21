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
            var connectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\Дмитрий\Documents\Visual Studio 2015\Projects\OOP\OOP\SessionDB.mdf; Integrated Security = True";
            SessionConnection = new SqlConnection(connectionString);
            await SessionConnection.OpenAsync();
        }

        SqlConnection SessionConnection;

        private bool CheckEmpty(params TextBox[] fields)//нет ли незаполненных строк
        {
            foreach (var field in fields)
                if (string.IsNullOrEmpty(field.Text) && string.IsNullOrWhiteSpace(field.Text))
                {
                    MessageBox.Show("Не все поля заполнены", "Ошибка");
                    return false;
                }
            return true;
        }
        private async void ReadDB(SqlCommand command, ListBox dBShow, int numberOfColumns)//исправить, сделать без явного задания кол-ва строк
        {
            SqlDataReader reader = null;
            try
            {
                reader = await command.ExecuteReaderAsync();
                while (await reader.ReadAsync())
                {
                    String rec = null;
                    for(var i = 0; i < numberOfColumns; i++)
                    {
                        rec = rec + Convert.ToString(reader[i]) + "    ";
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

        private async void btnCreateSubject_Click(object sender, EventArgs e)
        {
            //проверка условий, все ли данные соотвествуют типам, пустота строк
            //запись в логи о создании предмета
            if (CheckEmpty(tbTeachName, tbSubName))
            {
                SqlCommand command = new SqlCommand("INSERT INTO [SUBJECTS] (Name, Teacher_Name) VALUES (@Name, @Teacher)", SessionConnection);
                command.Parameters.AddWithValue("Name", tbSubName.Text);
                command.Parameters.AddWithValue("Teacher", tbTeachName.Text);
                await command.ExecuteNonQueryAsync();
            }
        }

        private async void btnCreateStudent_Click(object sender, EventArgs e)
        {
            //проверка условий, все ли данные соотвествуют типам, пустота строк
            //запись в логи о создании предмета
            if (CheckEmpty(tbStudCourse, tbStudGroup, tbStudGroup))
            {
                SqlCommand command = new SqlCommand("INSERT INTO [STUDENTS] (Name, Course, Squad) VALUES (@Name, @Course, @Squad)", SessionConnection);
                command.Parameters.AddWithValue("Name", tbStudName.Text);
                command.Parameters.AddWithValue("Course", tbStudCourse.Text);
                command.Parameters.AddWithValue("Squad", tbStudGroup.Text);
                await command.ExecuteNonQueryAsync();

            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (SessionConnection != null && SessionConnection.State != ConnectionState.Closed)
                SessionConnection.Close();
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
    }
}
