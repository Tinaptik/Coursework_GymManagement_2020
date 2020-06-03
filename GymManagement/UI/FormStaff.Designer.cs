namespace GymManagement
{
    partial class FormStaff
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
            this.buttonUpdateList = new System.Windows.Forms.Button();
            this.labelTrainerList = new System.Windows.Forms.Label();
            this.buttonDeleteTrainer = new System.Windows.Forms.Button();
            this.buttonNewTrainer = new System.Windows.Forms.Button();
            this.groupEditClient = new System.Windows.Forms.GroupBox();
            this.textSalary = new System.Windows.Forms.TextBox();
            this.labelSalary = new System.Windows.Forms.Label();
            this.comboTrainingProgram = new System.Windows.Forms.ComboBox();
            this.buttonSaveTrainer = new System.Windows.Forms.Button();
            this.labelTrainingProgram = new System.Windows.Forms.Label();
            this.textPhoneNumber = new System.Windows.Forms.TextBox();
            this.labelPhoneNumber = new System.Windows.Forms.Label();
            this.textPatronymic = new System.Windows.Forms.TextBox();
            this.labelPatronymic = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.textSurname = new System.Windows.Forms.TextBox();
            this.labelSurname = new System.Windows.Forms.Label();
            this.listTrainers = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupEditClient.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonUpdateList
            // 
            this.buttonUpdateList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonUpdateList.Location = new System.Drawing.Point(515, 509);
            this.buttonUpdateList.Name = "buttonUpdateList";
            this.buttonUpdateList.Size = new System.Drawing.Size(125, 23);
            this.buttonUpdateList.TabIndex = 12;
            this.buttonUpdateList.Text = "Обновить список";
            this.buttonUpdateList.UseVisualStyleBackColor = true;
            this.buttonUpdateList.Click += new System.EventHandler(this.buttonUpdateList_Click);
            // 
            // labelTrainerList
            // 
            this.labelTrainerList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTrainerList.AutoSize = true;
            this.labelTrainerList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTrainerList.ForeColor = System.Drawing.Color.White;
            this.labelTrainerList.Location = new System.Drawing.Point(394, 15);
            this.labelTrainerList.Name = "labelTrainerList";
            this.labelTrainerList.Size = new System.Drawing.Size(182, 24);
            this.labelTrainerList.TabIndex = 11;
            this.labelTrainerList.Text = "Список тренеров";
            // 
            // buttonDeleteTrainer
            // 
            this.buttonDeleteTrainer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonDeleteTrainer.Location = new System.Drawing.Point(143, 509);
            this.buttonDeleteTrainer.Name = "buttonDeleteTrainer";
            this.buttonDeleteTrainer.Size = new System.Drawing.Size(125, 23);
            this.buttonDeleteTrainer.TabIndex = 10;
            this.buttonDeleteTrainer.Text = "Удалить тренера";
            this.buttonDeleteTrainer.UseVisualStyleBackColor = true;
            this.buttonDeleteTrainer.Click += new System.EventHandler(this.buttonDeleteTrainer_Click);
            // 
            // buttonNewTrainer
            // 
            this.buttonNewTrainer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonNewTrainer.Location = new System.Drawing.Point(12, 509);
            this.buttonNewTrainer.Name = "buttonNewTrainer";
            this.buttonNewTrainer.Size = new System.Drawing.Size(125, 23);
            this.buttonNewTrainer.TabIndex = 7;
            this.buttonNewTrainer.Text = "Добавить тренера";
            this.buttonNewTrainer.UseVisualStyleBackColor = true;
            this.buttonNewTrainer.Click += new System.EventHandler(this.buttonNewTrainer_Click);
            // 
            // groupEditClient
            // 
            this.groupEditClient.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupEditClient.Controls.Add(this.textSalary);
            this.groupEditClient.Controls.Add(this.labelSalary);
            this.groupEditClient.Controls.Add(this.comboTrainingProgram);
            this.groupEditClient.Controls.Add(this.buttonSaveTrainer);
            this.groupEditClient.Controls.Add(this.labelTrainingProgram);
            this.groupEditClient.Controls.Add(this.textPhoneNumber);
            this.groupEditClient.Controls.Add(this.labelPhoneNumber);
            this.groupEditClient.Controls.Add(this.textPatronymic);
            this.groupEditClient.Controls.Add(this.labelPatronymic);
            this.groupEditClient.Controls.Add(this.textName);
            this.groupEditClient.Controls.Add(this.labelName);
            this.groupEditClient.Controls.Add(this.textSurname);
            this.groupEditClient.Controls.Add(this.labelSurname);
            this.groupEditClient.ForeColor = System.Drawing.Color.White;
            this.groupEditClient.Location = new System.Drawing.Point(646, 53);
            this.groupEditClient.Name = "groupEditClient";
            this.groupEditClient.Size = new System.Drawing.Size(287, 445);
            this.groupEditClient.TabIndex = 9;
            this.groupEditClient.TabStop = false;
            this.groupEditClient.Text = "Редактирование данных о выбранном тренере";
            // 
            // textSalary
            // 
            this.textSalary.Location = new System.Drawing.Point(42, 345);
            this.textSalary.Name = "textSalary";
            this.textSalary.Size = new System.Drawing.Size(200, 20);
            this.textSalary.TabIndex = 20;
            // 
            // labelSalary
            // 
            this.labelSalary.AutoSize = true;
            this.labelSalary.Location = new System.Drawing.Point(39, 329);
            this.labelSalary.Name = "labelSalary";
            this.labelSalary.Size = new System.Drawing.Size(55, 13);
            this.labelSalary.TabIndex = 19;
            this.labelSalary.Text = "Зарплата";
            // 
            // comboTrainingProgram
            // 
            this.comboTrainingProgram.FormattingEnabled = true;
            this.comboTrainingProgram.Items.AddRange(new object[] {
            "Индивидуальная",
            "Групповая"});
            this.comboTrainingProgram.Location = new System.Drawing.Point(42, 287);
            this.comboTrainingProgram.Name = "comboTrainingProgram";
            this.comboTrainingProgram.Size = new System.Drawing.Size(200, 21);
            this.comboTrainingProgram.TabIndex = 18;
            // 
            // buttonSaveTrainer
            // 
            this.buttonSaveTrainer.ForeColor = System.Drawing.Color.Black;
            this.buttonSaveTrainer.Location = new System.Drawing.Point(100, 390);
            this.buttonSaveTrainer.Name = "buttonSaveTrainer";
            this.buttonSaveTrainer.Size = new System.Drawing.Size(86, 23);
            this.buttonSaveTrainer.TabIndex = 5;
            this.buttonSaveTrainer.Text = "Сохранить";
            this.buttonSaveTrainer.UseVisualStyleBackColor = true;
            this.buttonSaveTrainer.Click += new System.EventHandler(this.buttonSaveTrainer_Click);
            // 
            // labelTrainingProgram
            // 
            this.labelTrainingProgram.AutoSize = true;
            this.labelTrainingProgram.Location = new System.Drawing.Point(39, 271);
            this.labelTrainingProgram.Name = "labelTrainingProgram";
            this.labelTrainingProgram.Size = new System.Drawing.Size(66, 13);
            this.labelTrainingProgram.TabIndex = 14;
            this.labelTrainingProgram.Text = "Программа";
            // 
            // textPhoneNumber
            // 
            this.textPhoneNumber.Location = new System.Drawing.Point(42, 231);
            this.textPhoneNumber.Name = "textPhoneNumber";
            this.textPhoneNumber.Size = new System.Drawing.Size(200, 20);
            this.textPhoneNumber.TabIndex = 13;
            // 
            // labelPhoneNumber
            // 
            this.labelPhoneNumber.AutoSize = true;
            this.labelPhoneNumber.Location = new System.Drawing.Point(39, 215);
            this.labelPhoneNumber.Name = "labelPhoneNumber";
            this.labelPhoneNumber.Size = new System.Drawing.Size(52, 13);
            this.labelPhoneNumber.TabIndex = 12;
            this.labelPhoneNumber.Text = "Телефон";
            // 
            // textPatronymic
            // 
            this.textPatronymic.Location = new System.Drawing.Point(42, 173);
            this.textPatronymic.Name = "textPatronymic";
            this.textPatronymic.Size = new System.Drawing.Size(200, 20);
            this.textPatronymic.TabIndex = 11;
            // 
            // labelPatronymic
            // 
            this.labelPatronymic.AutoSize = true;
            this.labelPatronymic.Location = new System.Drawing.Point(39, 157);
            this.labelPatronymic.Name = "labelPatronymic";
            this.labelPatronymic.Size = new System.Drawing.Size(54, 13);
            this.labelPatronymic.TabIndex = 10;
            this.labelPatronymic.Text = "Отчество";
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(42, 115);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(200, 20);
            this.textName.TabIndex = 9;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(39, 99);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(29, 13);
            this.labelName.TabIndex = 8;
            this.labelName.Text = "Имя";
            // 
            // textSurname
            // 
            this.textSurname.Location = new System.Drawing.Point(42, 58);
            this.textSurname.Name = "textSurname";
            this.textSurname.Size = new System.Drawing.Size(200, 20);
            this.textSurname.TabIndex = 7;
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Location = new System.Drawing.Point(39, 42);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(56, 13);
            this.labelSurname.TabIndex = 6;
            this.labelSurname.Text = "Фамилия";
            // 
            // listTrainers
            // 
            this.listTrainers.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listTrainers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.listTrainers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.listTrainers.ForeColor = System.Drawing.Color.White;
            this.listTrainers.FullRowSelect = true;
            this.listTrainers.HideSelection = false;
            this.listTrainers.Location = new System.Drawing.Point(12, 53);
            this.listTrainers.Name = "listTrainers";
            this.listTrainers.Size = new System.Drawing.Size(628, 445);
            this.listTrainers.TabIndex = 8;
            this.listTrainers.UseCompatibleStateImageBehavior = false;
            this.listTrainers.View = System.Windows.Forms.View.Details;
            this.listTrainers.DoubleClick += new System.EventHandler(this.listTrainers_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 27;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Фамилия";
            this.columnHeader2.Width = 92;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Имя";
            this.columnHeader3.Width = 83;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Отчество";
            this.columnHeader4.Width = 101;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Телефон";
            this.columnHeader5.Width = 84;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Программа";
            this.columnHeader6.Width = 100;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Зарплата";
            this.columnHeader7.Width = 137;
            // 
            // FormStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(949, 559);
            this.Controls.Add(this.buttonUpdateList);
            this.Controls.Add(this.labelTrainerList);
            this.Controls.Add(this.buttonDeleteTrainer);
            this.Controls.Add(this.buttonNewTrainer);
            this.Controls.Add(this.groupEditClient);
            this.Controls.Add(this.listTrainers);
            this.Name = "FormStaff";
            this.Text = "Тренеры";
            this.groupEditClient.ResumeLayout(false);
            this.groupEditClient.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button buttonUpdateList;
        private System.Windows.Forms.Label labelTrainerList;
        private System.Windows.Forms.Button buttonDeleteTrainer;
        private System.Windows.Forms.Button buttonNewTrainer;
        private System.Windows.Forms.GroupBox groupEditClient;
        private System.Windows.Forms.ComboBox comboTrainingProgram;
        private System.Windows.Forms.Button buttonSaveTrainer;
        private System.Windows.Forms.Label labelTrainingProgram;
        private System.Windows.Forms.TextBox textPhoneNumber;
        private System.Windows.Forms.Label labelPhoneNumber;
        private System.Windows.Forms.TextBox textPatronymic;
        private System.Windows.Forms.Label labelPatronymic;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textSurname;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.ListView listTrainers;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.TextBox textSalary;
        private System.Windows.Forms.Label labelSalary;
    }
}

