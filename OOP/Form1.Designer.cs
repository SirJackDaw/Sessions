namespace OOP
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnCreateStudent = new System.Windows.Forms.Button();
            this.tbStudGroup = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbStudCourse = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbStudName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCreateSubject = new System.Windows.Forms.Button();
            this.tbTeachName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbSubName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dBShSub = new System.Windows.Forms.ListBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.dBShStud = new System.Windows.Forms.ListBox();
            this.btnSStud = new System.Windows.Forms.Button();
            this.btnSSub = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(8, 8);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(551, 578);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnCreateStudent);
            this.tabPage1.Controls.Add(this.tbStudGroup);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.tbStudCourse);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.tbStudName);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.btnCreateSubject);
            this.tabPage1.Controls.Add(this.tbTeachName);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.tbSubName);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(543, 549);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Создать";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnCreateStudent
            // 
            this.btnCreateStudent.Location = new System.Drawing.Point(10, 433);
            this.btnCreateStudent.Name = "btnCreateStudent";
            this.btnCreateStudent.Size = new System.Drawing.Size(527, 55);
            this.btnCreateStudent.TabIndex = 15;
            this.btnCreateStudent.Text = "Создать студента";
            this.btnCreateStudent.UseVisualStyleBackColor = true;
            this.btnCreateStudent.Click += new System.EventHandler(this.btnCreateStudent_Click);
            // 
            // tbStudGroup
            // 
            this.tbStudGroup.Location = new System.Drawing.Point(274, 405);
            this.tbStudGroup.Name = "tbStudGroup";
            this.tbStudGroup.Size = new System.Drawing.Size(262, 22);
            this.tbStudGroup.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(274, 385);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Группа";
            // 
            // tbStudCourse
            // 
            this.tbStudCourse.Location = new System.Drawing.Point(9, 405);
            this.tbStudCourse.Name = "tbStudCourse";
            this.tbStudCourse.Size = new System.Drawing.Size(259, 22);
            this.tbStudCourse.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 385);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Курс";
            // 
            // tbStudName
            // 
            this.tbStudName.Location = new System.Drawing.Point(9, 356);
            this.tbStudName.Name = "tbStudName";
            this.tbStudName.Size = new System.Drawing.Size(527, 22);
            this.tbStudName.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 335);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "ФИО Студента";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Lucida Bright", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 263);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(530, 72);
            this.label6.TabIndex = 6;
            this.label6.Text = "Студент";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCreateSubject
            // 
            this.btnCreateSubject.Location = new System.Drawing.Point(9, 174);
            this.btnCreateSubject.Name = "btnCreateSubject";
            this.btnCreateSubject.Size = new System.Drawing.Size(527, 55);
            this.btnCreateSubject.TabIndex = 5;
            this.btnCreateSubject.Text = "Создать предмет";
            this.btnCreateSubject.UseVisualStyleBackColor = true;
            this.btnCreateSubject.Click += new System.EventHandler(this.btnCreateSubject_Click);
            // 
            // tbTeachName
            // 
            this.tbTeachName.Location = new System.Drawing.Point(9, 145);
            this.tbTeachName.Name = "tbTeachName";
            this.tbTeachName.Size = new System.Drawing.Size(527, 22);
            this.tbTeachName.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "ФИО преподавателя";
            // 
            // tbSubName
            // 
            this.tbSubName.Location = new System.Drawing.Point(9, 96);
            this.tbSubName.Name = "tbSubName";
            this.tbSubName.Size = new System.Drawing.Size(527, 22);
            this.tbSubName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Название предмета";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(530, 72);
            this.label1.TabIndex = 0;
            this.label1.Text = "Предмет";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(545, 549);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Редактировать";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(545, 549);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Найти";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dBShSub
            // 
            this.dBShSub.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.dBShSub.FormattingEnabled = true;
            this.dBShSub.ItemHeight = 16;
            this.dBShSub.Location = new System.Drawing.Point(565, 33);
            this.dBShSub.Name = "dBShSub";
            this.dBShSub.Size = new System.Drawing.Size(424, 244);
            this.dBShSub.TabIndex = 1;
            // 
            // listBox1
            // 
            this.listBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(8, 588);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(981, 100);
            this.listBox1.TabIndex = 2;
            // 
            // dBShStud
            // 
            this.dBShStud.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.dBShStud.FormattingEnabled = true;
            this.dBShStud.ItemHeight = 16;
            this.dBShStud.Location = new System.Drawing.Point(565, 342);
            this.dBShStud.Name = "dBShStud";
            this.dBShStud.Size = new System.Drawing.Size(424, 244);
            this.dBShStud.TabIndex = 3;
            // 
            // btnSStud
            // 
            this.btnSStud.Location = new System.Drawing.Point(780, 283);
            this.btnSStud.Name = "btnSStud";
            this.btnSStud.Size = new System.Drawing.Size(209, 53);
            this.btnSStud.TabIndex = 4;
            this.btnSStud.Text = "Показать студентов";
            this.btnSStud.UseVisualStyleBackColor = true;
            this.btnSStud.Click += new System.EventHandler(this.btnSStud_Click);
            // 
            // btnSSub
            // 
            this.btnSSub.Location = new System.Drawing.Point(565, 283);
            this.btnSSub.Name = "btnSSub";
            this.btnSSub.Size = new System.Drawing.Size(209, 53);
            this.btnSSub.TabIndex = 5;
            this.btnSSub.Text = "Показать предметы";
            this.btnSSub.UseVisualStyleBackColor = true;
            this.btnSSub.Click += new System.EventHandler(this.btnSSub_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 691);
            this.Controls.Add(this.btnSSub);
            this.Controls.Add(this.btnSStud);
            this.Controls.Add(this.dBShStud);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.dBShSub);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCreateStudent;
        private System.Windows.Forms.TextBox tbStudGroup;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbStudName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCreateSubject;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbSubName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbTeachName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbStudCourse;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.ListBox dBShSub;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox dBShStud;
        private System.Windows.Forms.Button btnSStud;
        private System.Windows.Forms.Button btnSSub;
    }
}

