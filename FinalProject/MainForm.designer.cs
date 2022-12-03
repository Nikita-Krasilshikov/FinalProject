namespace FinalProject
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.addStudentButton = new System.Windows.Forms.Button();
            this.showGroupListButton = new System.Windows.Forms.Button();
            this.workingButton = new System.Windows.Forms.Button();
            this.studentsCountLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.usersButton = new System.Windows.Forms.Button();
            this.fieldGroupBox = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.foundationComboBox = new System.Windows.Forms.ComboBox();
            this.debtsTextBox = new System.Windows.Forms.TextBox();
            this.noteTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.genderComboBox = new System.Windows.Forms.ComboBox();
            this.birthDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.studentsIDTextBox = new System.Windows.Forms.TextBox();
            this.middleNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.fieldGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // addStudentButton
            // 
            this.addStudentButton.Location = new System.Drawing.Point(12, 634);
            this.addStudentButton.Name = "addStudentButton";
            this.addStudentButton.Size = new System.Drawing.Size(713, 23);
            this.addStudentButton.TabIndex = 18;
            this.addStudentButton.Text = "Добавить студента";
            this.addStudentButton.UseVisualStyleBackColor = true;
            this.addStudentButton.Visible = false;
            this.addStudentButton.Click += new System.EventHandler(this.addStudentButton_Click);
            // 
            // showGroupListButton
            // 
            this.showGroupListButton.Location = new System.Drawing.Point(300, 10);
            this.showGroupListButton.Name = "showGroupListButton";
            this.showGroupListButton.Size = new System.Drawing.Size(254, 23);
            this.showGroupListButton.TabIndex = 19;
            this.showGroupListButton.Text = "Отобразить список группы";
            this.showGroupListButton.UseVisualStyleBackColor = true;
            this.showGroupListButton.Click += new System.EventHandler(this.showGroupListButton_Click);
            // 
            // workingButton
            // 
            this.workingButton.Location = new System.Drawing.Point(300, 39);
            this.workingButton.Name = "workingButton";
            this.workingButton.Size = new System.Drawing.Size(254, 23);
            this.workingButton.TabIndex = 20;
            this.workingButton.Text = "Выполнить обработку";
            this.workingButton.UseVisualStyleBackColor = true;
            this.workingButton.Click += new System.EventHandler(this.workingButton_Click);
            // 
            // studentsCountLabel
            // 
            this.studentsCountLabel.AutoSize = true;
            this.studentsCountLabel.Location = new System.Drawing.Point(572, 77);
            this.studentsCountLabel.Name = "studentsCountLabel";
            this.studentsCountLabel.Size = new System.Drawing.Size(114, 13);
            this.studentsCountLabel.TabIndex = 21;
            this.studentsCountLabel.Text = "Количество записей:";
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(650, 10);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 22;
            this.exitButton.Text = "Выход";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // usersButton
            // 
            this.usersButton.Location = new System.Drawing.Point(575, 39);
            this.usersButton.Name = "usersButton";
            this.usersButton.Size = new System.Drawing.Size(150, 23);
            this.usersButton.TabIndex = 23;
            this.usersButton.Text = "Список пользователей";
            this.usersButton.UseVisualStyleBackColor = true;
            this.usersButton.Visible = false;
            this.usersButton.Click += new System.EventHandler(this.usersButton_Click);
            // 
            // fieldGroupBox
            // 
            this.fieldGroupBox.Controls.Add(this.label9);
            this.fieldGroupBox.Controls.Add(this.label8);
            this.fieldGroupBox.Controls.Add(this.label7);
            this.fieldGroupBox.Controls.Add(this.label6);
            this.fieldGroupBox.Controls.Add(this.foundationComboBox);
            this.fieldGroupBox.Controls.Add(this.debtsTextBox);
            this.fieldGroupBox.Controls.Add(this.noteTextBox);
            this.fieldGroupBox.Controls.Add(this.label5);
            this.fieldGroupBox.Controls.Add(this.label4);
            this.fieldGroupBox.Controls.Add(this.label3);
            this.fieldGroupBox.Controls.Add(this.label2);
            this.fieldGroupBox.Controls.Add(this.label1);
            this.fieldGroupBox.Controls.Add(this.genderComboBox);
            this.fieldGroupBox.Controls.Add(this.birthDateDateTimePicker);
            this.fieldGroupBox.Controls.Add(this.studentsIDTextBox);
            this.fieldGroupBox.Controls.Add(this.middleNameTextBox);
            this.fieldGroupBox.Controls.Add(this.lastNameTextBox);
            this.fieldGroupBox.Controls.Add(this.firstNameTextBox);
            this.fieldGroupBox.Location = new System.Drawing.Point(12, 12);
            this.fieldGroupBox.Name = "fieldGroupBox";
            this.fieldGroupBox.Size = new System.Drawing.Size(282, 616);
            this.fieldGroupBox.TabIndex = 24;
            this.fieldGroupBox.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(41, 561);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 13);
            this.label9.TabIndex = 35;
            this.label9.Text = "Примечание";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(41, 490);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(200, 13);
            this.label8.TabIndex = 34;
            this.label8.Text = "Кол-во задолженностей (при наличии)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(41, 419);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 13);
            this.label7.TabIndex = 33;
            this.label7.Text = "Основа обучения";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 345);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "№ студенческого билета";
            // 
            // foundationComboBox
            // 
            this.foundationComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.foundationComboBox.FormattingEnabled = true;
            this.foundationComboBox.Items.AddRange(new object[] {
            "Бюджетная",
            "Платная"});
            this.foundationComboBox.Location = new System.Drawing.Point(44, 435);
            this.foundationComboBox.Name = "foundationComboBox";
            this.foundationComboBox.Size = new System.Drawing.Size(197, 21);
            this.foundationComboBox.TabIndex = 31;
            // 
            // debtsTextBox
            // 
            this.debtsTextBox.Location = new System.Drawing.Point(42, 506);
            this.debtsTextBox.Name = "debtsTextBox";
            this.debtsTextBox.Size = new System.Drawing.Size(199, 20);
            this.debtsTextBox.TabIndex = 30;
            // 
            // noteTextBox
            // 
            this.noteTextBox.Location = new System.Drawing.Point(44, 577);
            this.noteTextBox.Name = "noteTextBox";
            this.noteTextBox.Size = new System.Drawing.Size(197, 20);
            this.noteTextBox.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 278);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Пол";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Дата рождения";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Отчество";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Фамилия";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Имя";
            // 
            // genderComboBox
            // 
            this.genderComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genderComboBox.Items.AddRange(new object[] {
            "Мужской",
            "Женский"});
            this.genderComboBox.Location = new System.Drawing.Point(44, 294);
            this.genderComboBox.Name = "genderComboBox";
            this.genderComboBox.Size = new System.Drawing.Size(197, 21);
            this.genderComboBox.TabIndex = 23;
            // 
            // birthDateDateTimePicker
            // 
            this.birthDateDateTimePicker.Location = new System.Drawing.Point(44, 224);
            this.birthDateDateTimePicker.MaxDate = new System.DateTime(2022, 10, 18, 0, 0, 0, 0);
            this.birthDateDateTimePicker.Name = "birthDateDateTimePicker";
            this.birthDateDateTimePicker.Size = new System.Drawing.Size(197, 20);
            this.birthDateDateTimePicker.TabIndex = 22;
            this.birthDateDateTimePicker.Value = new System.DateTime(2022, 10, 18, 0, 0, 0, 0);
            // 
            // studentsIDTextBox
            // 
            this.studentsIDTextBox.Location = new System.Drawing.Point(44, 361);
            this.studentsIDTextBox.Name = "studentsIDTextBox";
            this.studentsIDTextBox.Size = new System.Drawing.Size(199, 20);
            this.studentsIDTextBox.TabIndex = 21;
            // 
            // middleNameTextBox
            // 
            this.middleNameTextBox.Location = new System.Drawing.Point(42, 157);
            this.middleNameTextBox.Name = "middleNameTextBox";
            this.middleNameTextBox.Size = new System.Drawing.Size(199, 20);
            this.middleNameTextBox.TabIndex = 20;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(42, 94);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(199, 20);
            this.lastNameTextBox.TabIndex = 19;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(42, 36);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(199, 20);
            this.firstNameTextBox.TabIndex = 18;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 662);
            this.Controls.Add(this.fieldGroupBox);
            this.Controls.Add(this.usersButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.studentsCountLabel);
            this.Controls.Add(this.workingButton);
            this.Controls.Add(this.showGroupListButton);
            this.Controls.Add(this.addStudentButton);
            this.Name = "MainForm";
            this.Text = "Красильщиков Никита Денисович ЭПЭ211";
            this.fieldGroupBox.ResumeLayout(false);
            this.fieldGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button addStudentButton;
        private System.Windows.Forms.Button showGroupListButton;
        private System.Windows.Forms.Button workingButton;
        private System.Windows.Forms.Label studentsCountLabel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button usersButton;
        private System.Windows.Forms.GroupBox fieldGroupBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox foundationComboBox;
        private System.Windows.Forms.TextBox debtsTextBox;
        private System.Windows.Forms.TextBox noteTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox genderComboBox;
        private System.Windows.Forms.DateTimePicker birthDateDateTimePicker;
        private System.Windows.Forms.TextBox studentsIDTextBox;
        private System.Windows.Forms.TextBox middleNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
    }
}

