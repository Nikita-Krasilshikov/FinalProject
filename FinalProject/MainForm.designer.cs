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
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.middleNameTextBox = new System.Windows.Forms.TextBox();
            this.studentsIDTextBox = new System.Windows.Forms.TextBox();
            this.birthDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.genderComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.noteTextBox = new System.Windows.Forms.TextBox();
            this.debtsTextBox = new System.Windows.Forms.TextBox();
            this.foundationComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.addStudentButton = new System.Windows.Forms.Button();
            this.showGroupListButton = new System.Windows.Forms.Button();
            this.workingButton = new System.Windows.Forms.Button();
            this.studentsCountLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(29, 36);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(199, 20);
            this.firstNameTextBox.TabIndex = 0;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(29, 94);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(199, 20);
            this.lastNameTextBox.TabIndex = 1;
            // 
            // middleNameTextBox
            // 
            this.middleNameTextBox.Location = new System.Drawing.Point(29, 157);
            this.middleNameTextBox.Name = "middleNameTextBox";
            this.middleNameTextBox.Size = new System.Drawing.Size(199, 20);
            this.middleNameTextBox.TabIndex = 2;
            // 
            // studentsIDTextBox
            // 
            this.studentsIDTextBox.Location = new System.Drawing.Point(31, 361);
            this.studentsIDTextBox.Name = "studentsIDTextBox";
            this.studentsIDTextBox.Size = new System.Drawing.Size(199, 20);
            this.studentsIDTextBox.TabIndex = 3;
            // 
            // birthDateDateTimePicker
            // 
            this.birthDateDateTimePicker.Location = new System.Drawing.Point(31, 224);
            this.birthDateDateTimePicker.MaxDate = new System.DateTime(2022, 10, 18, 0, 0, 0, 0);
            this.birthDateDateTimePicker.Name = "birthDateDateTimePicker";
            this.birthDateDateTimePicker.Size = new System.Drawing.Size(197, 20);
            this.birthDateDateTimePicker.TabIndex = 4;
            this.birthDateDateTimePicker.Value = new System.DateTime(2022, 10, 18, 0, 0, 0, 0);
            // 
            // genderComboBox
            // 
            this.genderComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genderComboBox.Items.AddRange(new object[] {
            "Мужской",
            "Женский"});
            this.genderComboBox.Location = new System.Drawing.Point(31, 294);
            this.genderComboBox.Name = "genderComboBox";
            this.genderComboBox.Size = new System.Drawing.Size(197, 21);
            this.genderComboBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Имя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Фамилия";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Отчество";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Дата рождения";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 278);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Пол";
            // 
            // noteTextBox
            // 
            this.noteTextBox.Location = new System.Drawing.Point(31, 577);
            this.noteTextBox.Name = "noteTextBox";
            this.noteTextBox.Size = new System.Drawing.Size(197, 20);
            this.noteTextBox.TabIndex = 11;
            // 
            // debtsTextBox
            // 
            this.debtsTextBox.Location = new System.Drawing.Point(29, 506);
            this.debtsTextBox.Name = "debtsTextBox";
            this.debtsTextBox.Size = new System.Drawing.Size(199, 20);
            this.debtsTextBox.TabIndex = 12;
            // 
            // foundationComboBox
            // 
            this.foundationComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.foundationComboBox.FormattingEnabled = true;
            this.foundationComboBox.Items.AddRange(new object[] {
            "Бюджетная",
            "Платная"});
            this.foundationComboBox.Location = new System.Drawing.Point(31, 435);
            this.foundationComboBox.Name = "foundationComboBox";
            this.foundationComboBox.Size = new System.Drawing.Size(197, 21);
            this.foundationComboBox.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 345);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "№ студенческого билета";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 419);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Основа обучения";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 490);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(200, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Кол-во задолженностей (при наличии)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(28, 561);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Примечание";
            // 
            // addStudentButton
            // 
            this.addStudentButton.Location = new System.Drawing.Point(12, 634);
            this.addStudentButton.Name = "addStudentButton";
            this.addStudentButton.Size = new System.Drawing.Size(713, 23);
            this.addStudentButton.TabIndex = 18;
            this.addStudentButton.Text = "Добавить студента";
            this.addStudentButton.UseVisualStyleBackColor = true;
            this.addStudentButton.Click += new System.EventHandler(this.addStudentButton_Click);
            // 
            // showGroupListButton
            // 
            this.showGroupListButton.Location = new System.Drawing.Point(392, 180);
            this.showGroupListButton.Name = "showGroupListButton";
            this.showGroupListButton.Size = new System.Drawing.Size(254, 23);
            this.showGroupListButton.TabIndex = 19;
            this.showGroupListButton.Text = "Отобразить список группы";
            this.showGroupListButton.UseVisualStyleBackColor = true;
            this.showGroupListButton.Click += new System.EventHandler(this.showGroupListButton_Click);
            // 
            // workingButton
            // 
            this.workingButton.Location = new System.Drawing.Point(392, 322);
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
            this.studentsCountLabel.Location = new System.Drawing.Point(389, 468);
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 669);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.studentsCountLabel);
            this.Controls.Add(this.workingButton);
            this.Controls.Add(this.showGroupListButton);
            this.Controls.Add(this.addStudentButton);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.foundationComboBox);
            this.Controls.Add(this.debtsTextBox);
            this.Controls.Add(this.noteTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.genderComboBox);
            this.Controls.Add(this.birthDateDateTimePicker);
            this.Controls.Add(this.studentsIDTextBox);
            this.Controls.Add(this.middleNameTextBox);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.firstNameTextBox);
            this.Name = "MainForm";
            this.Text = "Лабораторная работа №3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox middleNameTextBox;
        private System.Windows.Forms.TextBox studentsIDTextBox;
        private System.Windows.Forms.DateTimePicker birthDateDateTimePicker;
        private System.Windows.Forms.ComboBox genderComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox noteTextBox;
        private System.Windows.Forms.TextBox debtsTextBox;
        private System.Windows.Forms.ComboBox foundationComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button addStudentButton;
        private System.Windows.Forms.Button showGroupListButton;
        private System.Windows.Forms.Button workingButton;
        private System.Windows.Forms.Label studentsCountLabel;
        private System.Windows.Forms.Button exitButton;
    }
}

