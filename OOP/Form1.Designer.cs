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
            this.btnDelSub = new System.Windows.Forms.Button();
            this.btnDelStud = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tBIDSubject = new System.Windows.Forms.TextBox();
            this.tBIDStudent = new System.Windows.Forms.TextBox();
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
            this.label12 = new System.Windows.Forms.Label();
            this.btnDelMark = new System.Windows.Forms.Button();
            this.btnPutMark = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.tBMark = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tBSubID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tBStudID = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnClear = new System.Windows.Forms.Button();
            this.lbIDs = new System.Windows.Forms.ListBox();
            this.cBAM = new System.Windows.Forms.CheckBox();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.tBID = new System.Windows.Forms.TextBox();
            this.dBShSub = new System.Windows.Forms.ListBox();
            this.lBLogs = new System.Windows.Forms.ListBox();
            this.dBShStud = new System.Windows.Forms.ListBox();
            this.btnSStud = new System.Windows.Forms.Button();
            this.btnSSub = new System.Windows.Forms.Button();
            this.rBMidMark = new System.Windows.Forms.CheckBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
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
            this.tabControl1.Size = new System.Drawing.Size(871, 578);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnDelSub);
            this.tabPage1.Controls.Add(this.btnDelStud);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.tBIDSubject);
            this.tabPage1.Controls.Add(this.tBIDStudent);
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
            this.tabPage1.Size = new System.Drawing.Size(863, 549);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Предмет/Студент";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnDelSub
            // 
            this.btnDelSub.Location = new System.Drawing.Point(577, 162);
            this.btnDelSub.Name = "btnDelSub";
            this.btnDelSub.Size = new System.Drawing.Size(280, 67);
            this.btnDelSub.TabIndex = 21;
            this.btnDelSub.Text = "Удалить предмет";
            this.btnDelSub.UseVisualStyleBackColor = true;
            this.btnDelSub.Click += new System.EventHandler(this.btnDelSub_Click);
            // 
            // btnDelStud
            // 
            this.btnDelStud.Location = new System.Drawing.Point(580, 417);
            this.btnDelStud.Name = "btnDelStud";
            this.btnDelStud.Size = new System.Drawing.Size(277, 71);
            this.btnDelStud.TabIndex = 20;
            this.btnDelStud.Text = "Удалить студента";
            this.btnDelStud.UseVisualStyleBackColor = true;
            this.btnDelStud.Click += new System.EventHandler(this.btnDelStud_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(577, 336);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(85, 17);
            this.label14.TabIndex = 19;
            this.label14.Text = "ID студента";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(577, 75);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(89, 17);
            this.label13.TabIndex = 18;
            this.label13.Text = "ID предмета";
            // 
            // tBIDSubject
            // 
            this.tBIDSubject.BackColor = System.Drawing.SystemColors.Window;
            this.tBIDSubject.Location = new System.Drawing.Point(580, 95);
            this.tBIDSubject.Name = "tBIDSubject";
            this.tBIDSubject.Size = new System.Drawing.Size(277, 22);
            this.tBIDSubject.TabIndex = 17;
            // 
            // tBIDStudent
            // 
            this.tBIDStudent.Location = new System.Drawing.Point(580, 356);
            this.tBIDStudent.Name = "tBIDStudent";
            this.tBIDStudent.Size = new System.Drawing.Size(277, 22);
            this.tBIDStudent.TabIndex = 16;
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
            this.label6.Location = new System.Drawing.Point(0, 263);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(863, 72);
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
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(857, 72);
            this.label1.TabIndex = 0;
            this.label1.Text = "Предмет";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.btnDelMark);
            this.tabPage2.Controls.Add(this.btnPutMark);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.tBMark);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.tBSubID);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.tBStudID);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(863, 549);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Оценки";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(11, 151);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(506, 68);
            this.label12.TabIndex = 8;
            this.label12.Text = "Нажатие на кнопку \"Удалить\" работает следующим образом:\r\nПри заполненном поле \"ID" +
    " Студента\" удаляет все оценки этого студента\r\nПри заполненном поле \"ID Предмета\"" +
    " удаляет все оценки за этот предмет\r\n\r\n";
            // 
            // btnDelMark
            // 
            this.btnDelMark.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDelMark.Location = new System.Drawing.Point(238, 110);
            this.btnDelMark.Name = "btnDelMark";
            this.btnDelMark.Size = new System.Drawing.Size(205, 34);
            this.btnDelMark.TabIndex = 7;
            this.btnDelMark.Text = "Удалить";
            this.btnDelMark.UseVisualStyleBackColor = true;
            this.btnDelMark.Click += new System.EventHandler(this.btnDelMark_Click);
            // 
            // btnPutMark
            // 
            this.btnPutMark.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPutMark.Location = new System.Drawing.Point(238, 73);
            this.btnPutMark.Name = "btnPutMark";
            this.btnPutMark.Size = new System.Drawing.Size(205, 34);
            this.btnPutMark.TabIndex = 6;
            this.btnPutMark.Text = "Поставить";
            this.btnPutMark.UseVisualStyleBackColor = true;
            this.btnPutMark.Click += new System.EventHandler(this.btnPutMark_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(6, 94);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(164, 25);
            this.label10.TabIndex = 5;
            this.label10.Text = "Введите Оценку";
            // 
            // tBMark
            // 
            this.tBMark.Location = new System.Drawing.Point(11, 122);
            this.tBMark.Name = "tBMark";
            this.tBMark.Size = new System.Drawing.Size(205, 22);
            this.tBMark.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(233, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(218, 25);
            this.label9.TabIndex = 3;
            this.label9.Text = "Введите ID Предмета";
            // 
            // tBSubID
            // 
            this.tBSubID.Location = new System.Drawing.Point(238, 46);
            this.tBSubID.Name = "tBSubID";
            this.tBSubID.Size = new System.Drawing.Size(205, 22);
            this.tBSubID.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(6, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(210, 25);
            this.label8.TabIndex = 1;
            this.label8.Text = "Введите ID Студента";
            // 
            // tBStudID
            // 
            this.tBStudID.Location = new System.Drawing.Point(11, 46);
            this.tBStudID.Name = "tBStudID";
            this.tBStudID.Size = new System.Drawing.Size(205, 22);
            this.tBStudID.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.rBMidMark);
            this.tabPage3.Controls.Add(this.btnClear);
            this.tabPage3.Controls.Add(this.lbIDs);
            this.tabPage3.Controls.Add(this.cBAM);
            this.tabPage3.Controls.Add(this.btnShowAll);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.tBID);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(863, 549);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Найти";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(3, 516);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(857, 30);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Очистить";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lbIDs
            // 
            this.lbIDs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbIDs.FormattingEnabled = true;
            this.lbIDs.ImeMode = System.Windows.Forms.ImeMode.Katakana;
            this.lbIDs.ItemHeight = 16;
            this.lbIDs.Location = new System.Drawing.Point(3, 63);
            this.lbIDs.Name = "lbIDs";
            this.lbIDs.Size = new System.Drawing.Size(857, 452);
            this.lbIDs.TabIndex = 7;
            // 
            // cBAM
            // 
            this.cBAM.AutoSize = true;
            this.cBAM.Location = new System.Drawing.Point(493, 36);
            this.cBAM.Name = "cBAM";
            this.cBAM.Size = new System.Drawing.Size(204, 21);
            this.cBAM.TabIndex = 4;
            this.cBAM.Text = "Показывать средний балл";
            this.cBAM.UseVisualStyleBackColor = true;
            // 
            // btnShowAll
            // 
            this.btnShowAll.Location = new System.Drawing.Point(400, 12);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(87, 46);
            this.btnShowAll.TabIndex = 3;
            this.btnShowAll.Text = "Показать";
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(0, 12);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(189, 20);
            this.label11.TabIndex = 2;
            this.label11.Text = "Введите ID студента\r\n";
            // 
            // tBID
            // 
            this.tBID.Location = new System.Drawing.Point(3, 36);
            this.tBID.Name = "tBID";
            this.tBID.Size = new System.Drawing.Size(391, 22);
            this.tBID.TabIndex = 1;
            // 
            // dBShSub
            // 
            this.dBShSub.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.dBShSub.FormattingEnabled = true;
            this.dBShSub.ItemHeight = 16;
            this.dBShSub.Location = new System.Drawing.Point(885, 33);
            this.dBShSub.Name = "dBShSub";
            this.dBShSub.Size = new System.Drawing.Size(424, 292);
            this.dBShSub.TabIndex = 1;
            // 
            // lBLogs
            // 
            this.lBLogs.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.lBLogs.FormattingEnabled = true;
            this.lBLogs.ItemHeight = 16;
            this.lBLogs.Location = new System.Drawing.Point(8, 588);
            this.lBLogs.Name = "lBLogs";
            this.lBLogs.Size = new System.Drawing.Size(867, 100);
            this.lBLogs.TabIndex = 2;
            // 
            // dBShStud
            // 
            this.dBShStud.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.dBShStud.FormattingEnabled = true;
            this.dBShStud.ItemHeight = 16;
            this.dBShStud.Location = new System.Drawing.Point(886, 380);
            this.dBShStud.Name = "dBShStud";
            this.dBShStud.Size = new System.Drawing.Size(424, 308);
            this.dBShStud.TabIndex = 3;
            // 
            // btnSStud
            // 
            this.btnSStud.Location = new System.Drawing.Point(1096, 329);
            this.btnSStud.Name = "btnSStud";
            this.btnSStud.Size = new System.Drawing.Size(209, 45);
            this.btnSStud.TabIndex = 4;
            this.btnSStud.Text = "Показать студентов";
            this.btnSStud.UseVisualStyleBackColor = true;
            this.btnSStud.Click += new System.EventHandler(this.btnSStud_Click);
            // 
            // btnSSub
            // 
            this.btnSSub.Location = new System.Drawing.Point(881, 329);
            this.btnSSub.Name = "btnSSub";
            this.btnSSub.Size = new System.Drawing.Size(209, 45);
            this.btnSSub.TabIndex = 5;
            this.btnSSub.Text = "Показать предметы";
            this.btnSSub.UseVisualStyleBackColor = true;
            this.btnSSub.Click += new System.EventHandler(this.btnSSub_Click);
            // 
            // rBMidMark
            // 
            this.rBMidMark.AutoSize = true;
            this.rBMidMark.Location = new System.Drawing.Point(494, 12);
            this.rBMidMark.Name = "rBMidMark";
            this.rBMidMark.Size = new System.Drawing.Size(245, 21);
            this.rBMidMark.TabIndex = 9;
            this.rBMidMark.Text = "Сортировать по среднему баллу";
            this.rBMidMark.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1321, 691);
            this.Controls.Add(this.btnSSub);
            this.Controls.Add(this.btnSStud);
            this.Controls.Add(this.dBShStud);
            this.Controls.Add(this.lBLogs);
            this.Controls.Add(this.dBShSub);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
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
        private System.Windows.Forms.ListBox lBLogs;
        private System.Windows.Forms.ListBox dBShStud;
        private System.Windows.Forms.Button btnSStud;
        private System.Windows.Forms.Button btnSSub;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tBStudID;
        private System.Windows.Forms.Button btnDelMark;
        private System.Windows.Forms.Button btnPutMark;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tBMark;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tBSubID;
        private System.Windows.Forms.CheckBox cBAM;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tBID;
        private System.Windows.Forms.ListBox lbIDs;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnDelStud;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tBIDSubject;
        private System.Windows.Forms.TextBox tBIDStudent;
        private System.Windows.Forms.Button btnDelSub;
        private System.Windows.Forms.CheckBox rBMidMark;
    }
}

