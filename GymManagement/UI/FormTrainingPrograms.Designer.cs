namespace GymManagement.UI
{
    partial class FormTrainingPrograms
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
            this.buttonUpdateList = new System.Windows.Forms.Button();
            this.labelClientList = new System.Windows.Forms.Label();
            this.buttonDeleteTrainingProgram = new System.Windows.Forms.Button();
            this.buttonNewTrainingProgram = new System.Windows.Forms.Button();
            this.groupEditClient = new System.Windows.Forms.GroupBox();
            this.text1Year = new System.Windows.Forms.TextBox();
            this.text6Months = new System.Windows.Forms.TextBox();
            this.text1Month = new System.Windows.Forms.TextBox();
            this.text8Trains = new System.Windows.Forms.TextBox();
            this.label1Year = new System.Windows.Forms.Label();
            this.label6Months = new System.Windows.Forms.Label();
            this.text3Months = new System.Windows.Forms.TextBox();
            this.label3Months = new System.Windows.Forms.Label();
            this.buttonSaveTrainingProgram = new System.Windows.Forms.Button();
            this.label1Month = new System.Windows.Forms.Label();
            this.label12Trains = new System.Windows.Forms.Label();
            this.text12Trains = new System.Windows.Forms.TextBox();
            this.label8Trains = new System.Windows.Forms.Label();
            this.text1Train = new System.Windows.Forms.TextBox();
            this.label1Train = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.listTrainingPrograms = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.buttonUpdateList.Click += new System.EventHandler(this.buttonUpdateList_Click_1);
            // 
            // labelClientList
            // 
            this.labelClientList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelClientList.AutoSize = true;
            this.labelClientList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelClientList.ForeColor = System.Drawing.Color.White;
            this.labelClientList.Location = new System.Drawing.Point(394, 15);
            this.labelClientList.Name = "labelClientList";
            this.labelClientList.Size = new System.Drawing.Size(184, 24);
            this.labelClientList.TabIndex = 11;
            this.labelClientList.Text = "Список программ";
            // 
            // buttonDeleteTrainingProgram
            // 
            this.buttonDeleteTrainingProgram.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonDeleteTrainingProgram.Location = new System.Drawing.Point(143, 509);
            this.buttonDeleteTrainingProgram.Name = "buttonDeleteTrainingProgram";
            this.buttonDeleteTrainingProgram.Size = new System.Drawing.Size(125, 23);
            this.buttonDeleteTrainingProgram.TabIndex = 10;
            this.buttonDeleteTrainingProgram.Text = "Удалить программу";
            this.buttonDeleteTrainingProgram.UseVisualStyleBackColor = true;
            this.buttonDeleteTrainingProgram.Click += new System.EventHandler(this.buttonDeleteTrainingProgram_Click);
            // 
            // buttonNewTrainingProgram
            // 
            this.buttonNewTrainingProgram.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonNewTrainingProgram.Location = new System.Drawing.Point(12, 509);
            this.buttonNewTrainingProgram.Name = "buttonNewTrainingProgram";
            this.buttonNewTrainingProgram.Size = new System.Drawing.Size(125, 23);
            this.buttonNewTrainingProgram.TabIndex = 7;
            this.buttonNewTrainingProgram.Text = "Добавить программу";
            this.buttonNewTrainingProgram.UseVisualStyleBackColor = true;
            this.buttonNewTrainingProgram.Click += new System.EventHandler(this.buttonNewTrainingProgram_Click);
            // 
            // groupEditClient
            // 
            this.groupEditClient.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupEditClient.Controls.Add(this.text1Year);
            this.groupEditClient.Controls.Add(this.text6Months);
            this.groupEditClient.Controls.Add(this.text1Month);
            this.groupEditClient.Controls.Add(this.text8Trains);
            this.groupEditClient.Controls.Add(this.label1Year);
            this.groupEditClient.Controls.Add(this.label6Months);
            this.groupEditClient.Controls.Add(this.text3Months);
            this.groupEditClient.Controls.Add(this.label3Months);
            this.groupEditClient.Controls.Add(this.buttonSaveTrainingProgram);
            this.groupEditClient.Controls.Add(this.label1Month);
            this.groupEditClient.Controls.Add(this.label12Trains);
            this.groupEditClient.Controls.Add(this.text12Trains);
            this.groupEditClient.Controls.Add(this.label8Trains);
            this.groupEditClient.Controls.Add(this.text1Train);
            this.groupEditClient.Controls.Add(this.label1Train);
            this.groupEditClient.Controls.Add(this.textName);
            this.groupEditClient.Controls.Add(this.labelName);
            this.groupEditClient.ForeColor = System.Drawing.Color.White;
            this.groupEditClient.Location = new System.Drawing.Point(646, 53);
            this.groupEditClient.Name = "groupEditClient";
            this.groupEditClient.Size = new System.Drawing.Size(287, 445);
            this.groupEditClient.TabIndex = 9;
            this.groupEditClient.TabStop = false;
            this.groupEditClient.Text = "Редактирование данных о выбранном клиенте";
            // 
            // text1Year
            // 
            this.text1Year.Location = new System.Drawing.Point(42, 372);
            this.text1Year.Name = "text1Year";
            this.text1Year.Size = new System.Drawing.Size(200, 20);
            this.text1Year.TabIndex = 29;
            // 
            // text6Months
            // 
            this.text6Months.Location = new System.Drawing.Point(42, 325);
            this.text6Months.Name = "text6Months";
            this.text6Months.Size = new System.Drawing.Size(200, 20);
            this.text6Months.TabIndex = 28;
            // 
            // text1Month
            // 
            this.text1Month.Location = new System.Drawing.Point(42, 232);
            this.text1Month.Name = "text1Month";
            this.text1Month.Size = new System.Drawing.Size(200, 20);
            this.text1Month.TabIndex = 27;
            // 
            // text8Trains
            // 
            this.text8Trains.Location = new System.Drawing.Point(42, 136);
            this.text8Trains.Name = "text8Trains";
            this.text8Trains.Size = new System.Drawing.Size(200, 20);
            this.text8Trains.TabIndex = 26;
            // 
            // label1Year
            // 
            this.label1Year.AutoSize = true;
            this.label1Year.Location = new System.Drawing.Point(39, 356);
            this.label1Year.Name = "label1Year";
            this.label1Year.Size = new System.Drawing.Size(33, 13);
            this.label1Year.TabIndex = 23;
            this.label1Year.Text = "1 год";
            // 
            // label6Months
            // 
            this.label6Months.AutoSize = true;
            this.label6Months.Location = new System.Drawing.Point(39, 309);
            this.label6Months.Name = "label6Months";
            this.label6Months.Size = new System.Drawing.Size(60, 13);
            this.label6Months.TabIndex = 22;
            this.label6Months.Text = "6 месяцев";
            // 
            // text3Months
            // 
            this.text3Months.Location = new System.Drawing.Point(42, 279);
            this.text3Months.Name = "text3Months";
            this.text3Months.Size = new System.Drawing.Size(200, 20);
            this.text3Months.TabIndex = 21;
            // 
            // label3Months
            // 
            this.label3Months.AutoSize = true;
            this.label3Months.Location = new System.Drawing.Point(39, 263);
            this.label3Months.Name = "label3Months";
            this.label3Months.Size = new System.Drawing.Size(54, 13);
            this.label3Months.TabIndex = 20;
            this.label3Months.Text = "3 месяца";
            // 
            // buttonSaveTrainingProgram
            // 
            this.buttonSaveTrainingProgram.ForeColor = System.Drawing.Color.Black;
            this.buttonSaveTrainingProgram.Location = new System.Drawing.Point(100, 405);
            this.buttonSaveTrainingProgram.Name = "buttonSaveTrainingProgram";
            this.buttonSaveTrainingProgram.Size = new System.Drawing.Size(86, 23);
            this.buttonSaveTrainingProgram.TabIndex = 5;
            this.buttonSaveTrainingProgram.Text = "Сохранить";
            this.buttonSaveTrainingProgram.UseVisualStyleBackColor = true;
            this.buttonSaveTrainingProgram.Click += new System.EventHandler(this.buttonSaveTrainingProgram_Click);
            // 
            // label1Month
            // 
            this.label1Month.AutoSize = true;
            this.label1Month.Location = new System.Drawing.Point(39, 216);
            this.label1Month.Name = "label1Month";
            this.label1Month.Size = new System.Drawing.Size(48, 13);
            this.label1Month.TabIndex = 16;
            this.label1Month.Text = "1 месяц";
            // 
            // label12Trains
            // 
            this.label12Trains.AutoSize = true;
            this.label12Trains.Location = new System.Drawing.Point(39, 166);
            this.label12Trains.Name = "label12Trains";
            this.label12Trains.Size = new System.Drawing.Size(81, 13);
            this.label12Trains.TabIndex = 14;
            this.label12Trains.Text = "12 тренировок";
            // 
            // text12Trains
            // 
            this.text12Trains.Location = new System.Drawing.Point(42, 182);
            this.text12Trains.Name = "text12Trains";
            this.text12Trains.Size = new System.Drawing.Size(200, 20);
            this.text12Trains.TabIndex = 13;
            // 
            // label8Trains
            // 
            this.label8Trains.AutoSize = true;
            this.label8Trains.Location = new System.Drawing.Point(39, 120);
            this.label8Trains.Name = "label8Trains";
            this.label8Trains.Size = new System.Drawing.Size(75, 13);
            this.label8Trains.TabIndex = 12;
            this.label8Trains.Text = "8 тренировок";
            // 
            // text1Train
            // 
            this.text1Train.Location = new System.Drawing.Point(42, 90);
            this.text1Train.Name = "text1Train";
            this.text1Train.Size = new System.Drawing.Size(200, 20);
            this.text1Train.TabIndex = 11;
            // 
            // label1Train
            // 
            this.label1Train.AutoSize = true;
            this.label1Train.Location = new System.Drawing.Point(39, 74);
            this.label1Train.Name = "label1Train";
            this.label1Train.Size = new System.Drawing.Size(75, 13);
            this.label1Train.TabIndex = 10;
            this.label1Train.Text = "1 тренировка";
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(42, 41);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(200, 20);
            this.textName.TabIndex = 9;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(39, 25);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(29, 13);
            this.labelName.TabIndex = 8;
            this.labelName.Text = "Имя";
            // 
            // listTrainingPrograms
            // 
            this.listTrainingPrograms.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listTrainingPrograms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.listTrainingPrograms.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader8,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader9});
            this.listTrainingPrograms.ForeColor = System.Drawing.Color.White;
            this.listTrainingPrograms.FullRowSelect = true;
            this.listTrainingPrograms.HideSelection = false;
            this.listTrainingPrograms.Location = new System.Drawing.Point(12, 53);
            this.listTrainingPrograms.Name = "listTrainingPrograms";
            this.listTrainingPrograms.Size = new System.Drawing.Size(628, 445);
            this.listTrainingPrograms.TabIndex = 8;
            this.listTrainingPrograms.UseCompatibleStateImageBehavior = false;
            this.listTrainingPrograms.View = System.Windows.Forms.View.Details;
            this.listTrainingPrograms.DoubleClick += new System.EventHandler(this.listTrainingPrograms_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 27;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Название";
            this.columnHeader8.Width = 98;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "1 тренировка";
            this.columnHeader2.Width = 83;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "8 тренировок";
            this.columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "12 тренировок";
            this.columnHeader4.Width = 87;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "1 месяц";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "3 месяца";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "6 месяцев";
            this.columnHeader7.Width = 69;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "1 год";
            // 
            // FormTrainingPrograms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(949, 559);
            this.Controls.Add(this.buttonUpdateList);
            this.Controls.Add(this.labelClientList);
            this.Controls.Add(this.buttonDeleteTrainingProgram);
            this.Controls.Add(this.buttonNewTrainingProgram);
            this.Controls.Add(this.groupEditClient);
            this.Controls.Add(this.listTrainingPrograms);
            this.Name = "FormTrainingPrograms";
            this.Text = "Тренировочные программы";
            this.groupEditClient.ResumeLayout(false);
            this.groupEditClient.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button buttonUpdateList;
        private System.Windows.Forms.Label labelClientList;
        private System.Windows.Forms.Button buttonDeleteTrainingProgram;
        private System.Windows.Forms.Button buttonNewTrainingProgram;
        private System.Windows.Forms.GroupBox groupEditClient;
        private System.Windows.Forms.Button buttonSaveTrainingProgram;
        private System.Windows.Forms.Label label1Month;
        private System.Windows.Forms.Label label12Trains;
        private System.Windows.Forms.TextBox text12Trains;
        private System.Windows.Forms.Label label8Trains;
        private System.Windows.Forms.TextBox text1Train;
        private System.Windows.Forms.Label label1Train;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.ListView listTrainingPrograms;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Label label1Year;
        private System.Windows.Forms.Label label6Months;
        private System.Windows.Forms.TextBox text3Months;
        private System.Windows.Forms.Label label3Months;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.TextBox text1Year;
        private System.Windows.Forms.TextBox text6Months;
        private System.Windows.Forms.TextBox text1Month;
        private System.Windows.Forms.TextBox text8Trains;
    }
}