namespace GymManagement
{
    partial class FormClients
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
            this.listClients = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupEditClient = new System.Windows.Forms.GroupBox();
            this.comboTrainer = new System.Windows.Forms.ComboBox();
            this.comboTrainingProgram = new System.Windows.Forms.ComboBox();
            this.buttonSaveClient = new System.Windows.Forms.Button();
            this.labelTrainer = new System.Windows.Forms.Label();
            this.labelTrainingProgram = new System.Windows.Forms.Label();
            this.textPhoneNumber = new System.Windows.Forms.TextBox();
            this.labelPhoneNumber = new System.Windows.Forms.Label();
            this.textPatronymic = new System.Windows.Forms.TextBox();
            this.labelPatronymic = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.textSurname = new System.Windows.Forms.TextBox();
            this.labelSurname = new System.Windows.Forms.Label();
            this.buttonNewClient = new System.Windows.Forms.Button();
            this.buttonDeleteClient = new System.Windows.Forms.Button();
            this.labelClientList = new System.Windows.Forms.Label();
            this.buttonUpdateList = new System.Windows.Forms.Button();
            this.groupEditClient.SuspendLayout();
            this.SuspendLayout();
            // 
            // listClients
            // 
            this.listClients.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listClients.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.listClients.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.listClients.ForeColor = System.Drawing.Color.White;
            this.listClients.FullRowSelect = true;
            this.listClients.HideSelection = false;
            this.listClients.Location = new System.Drawing.Point(12, 53);
            this.listClients.Name = "listClients";
            this.listClients.Size = new System.Drawing.Size(628, 445);
            this.listClients.TabIndex = 2;
            this.listClients.UseCompatibleStateImageBehavior = false;
            this.listClients.View = System.Windows.Forms.View.Details;
            this.listClients.DoubleClick += new System.EventHandler(this.listClients_DoubleClick);
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
            this.columnHeader7.Text = "Тренер";
            this.columnHeader7.Width = 136;
            // 
            // groupEditClient
            // 
            this.groupEditClient.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupEditClient.Controls.Add(this.comboTrainer);
            this.groupEditClient.Controls.Add(this.comboTrainingProgram);
            this.groupEditClient.Controls.Add(this.buttonSaveClient);
            this.groupEditClient.Controls.Add(this.labelTrainer);
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
            this.groupEditClient.TabIndex = 3;
            this.groupEditClient.TabStop = false;
            this.groupEditClient.Text = "Редактирование данных о выбранном клиенте";
            // 
            // comboTrainer
            // 
            this.comboTrainer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTrainer.FormattingEnabled = true;
            this.comboTrainer.Items.AddRange(new object[] {
            "С тренером",
            "Без тренера"});
            this.comboTrainer.Location = new System.Drawing.Point(42, 345);
            this.comboTrainer.Name = "comboTrainer";
            this.comboTrainer.Size = new System.Drawing.Size(200, 21);
            this.comboTrainer.TabIndex = 19;
            // 
            // comboTrainingProgram
            // 
            this.comboTrainingProgram.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTrainingProgram.FormattingEnabled = true;
            this.comboTrainingProgram.Items.AddRange(new object[] {
            "Индивидуальная",
            "Групповая"});
            this.comboTrainingProgram.Location = new System.Drawing.Point(42, 287);
            this.comboTrainingProgram.Name = "comboTrainingProgram";
            this.comboTrainingProgram.Size = new System.Drawing.Size(200, 21);
            this.comboTrainingProgram.TabIndex = 18;
            // 
            // buttonSaveClient
            // 
            this.buttonSaveClient.ForeColor = System.Drawing.Color.Black;
            this.buttonSaveClient.Location = new System.Drawing.Point(100, 390);
            this.buttonSaveClient.Name = "buttonSaveClient";
            this.buttonSaveClient.Size = new System.Drawing.Size(86, 23);
            this.buttonSaveClient.TabIndex = 5;
            this.buttonSaveClient.Text = "Сохранить";
            this.buttonSaveClient.UseVisualStyleBackColor = true;
            this.buttonSaveClient.Click += new System.EventHandler(this.buttonSaveClient_Click);
            // 
            // labelTrainer
            // 
            this.labelTrainer.AutoSize = true;
            this.labelTrainer.Location = new System.Drawing.Point(39, 329);
            this.labelTrainer.Name = "labelTrainer";
            this.labelTrainer.Size = new System.Drawing.Size(44, 13);
            this.labelTrainer.TabIndex = 16;
            this.labelTrainer.Text = "Тренер";
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
            // buttonNewClient
            // 
            this.buttonNewClient.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonNewClient.Location = new System.Drawing.Point(12, 509);
            this.buttonNewClient.Name = "buttonNewClient";
            this.buttonNewClient.Size = new System.Drawing.Size(125, 23);
            this.buttonNewClient.TabIndex = 0;
            this.buttonNewClient.Text = "Добавить клиента";
            this.buttonNewClient.UseVisualStyleBackColor = true;
            this.buttonNewClient.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonDeleteClient
            // 
            this.buttonDeleteClient.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonDeleteClient.Location = new System.Drawing.Point(143, 509);
            this.buttonDeleteClient.Name = "buttonDeleteClient";
            this.buttonDeleteClient.Size = new System.Drawing.Size(125, 23);
            this.buttonDeleteClient.TabIndex = 4;
            this.buttonDeleteClient.Text = "Удалить клиента";
            this.buttonDeleteClient.UseVisualStyleBackColor = true;
            this.buttonDeleteClient.Click += new System.EventHandler(this.buttonDeleteClient_Click_1);
            // 
            // labelClientList
            // 
            this.labelClientList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelClientList.AutoSize = true;
            this.labelClientList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelClientList.ForeColor = System.Drawing.Color.White;
            this.labelClientList.Location = new System.Drawing.Point(394, 15);
            this.labelClientList.Name = "labelClientList";
            this.labelClientList.Size = new System.Drawing.Size(179, 24);
            this.labelClientList.TabIndex = 5;
            this.labelClientList.Text = "Список клиентов";
            // 
            // buttonUpdateList
            // 
            this.buttonUpdateList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonUpdateList.Location = new System.Drawing.Point(515, 509);
            this.buttonUpdateList.Name = "buttonUpdateList";
            this.buttonUpdateList.Size = new System.Drawing.Size(125, 23);
            this.buttonUpdateList.TabIndex = 6;
            this.buttonUpdateList.Text = "Обновить список";
            this.buttonUpdateList.UseVisualStyleBackColor = true;
            this.buttonUpdateList.Click += new System.EventHandler(this.buttonUpdateList_Click);
            // 
            // FormClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(949, 559);
            this.Controls.Add(this.buttonUpdateList);
            this.Controls.Add(this.labelClientList);
            this.Controls.Add(this.buttonDeleteClient);
            this.Controls.Add(this.buttonNewClient);
            this.Controls.Add(this.groupEditClient);
            this.Controls.Add(this.listClients);
            this.Name = "FormClients";
            this.Text = "Клиенты";
            this.groupEditClient.ResumeLayout(false);
            this.groupEditClient.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView listClients;
        private System.Windows.Forms.GroupBox groupEditClient;
        private System.Windows.Forms.Button buttonNewClient;
        private System.Windows.Forms.Button buttonDeleteClient;
        private System.Windows.Forms.Button buttonSaveClient;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.Label labelTrainer;
        private System.Windows.Forms.Label labelTrainingProgram;
        private System.Windows.Forms.TextBox textPhoneNumber;
        private System.Windows.Forms.Label labelPhoneNumber;
        private System.Windows.Forms.TextBox textPatronymic;
        private System.Windows.Forms.Label labelPatronymic;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textSurname;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ComboBox comboTrainer;
        private System.Windows.Forms.ComboBox comboTrainingProgram;
        private System.Windows.Forms.Label labelClientList;
        public System.Windows.Forms.Button buttonUpdateList;
    }
}

