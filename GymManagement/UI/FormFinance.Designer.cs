namespace GymManagement
{
    partial class FormFinance
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
            this.listClientsFinance = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelFinance = new System.Windows.Forms.Label();
            this.buttonUpdateList = new System.Windows.Forms.Button();
            this.groupDeposit = new System.Windows.Forms.GroupBox();
            this.textDepositSum = new System.Windows.Forms.TextBox();
            this.labelDepositSum = new System.Windows.Forms.Label();
            this.buttonDeposit = new System.Windows.Forms.Button();
            this.textID = new System.Windows.Forms.TextBox();
            this.labelID = new System.Windows.Forms.Label();
            this.groupSellAbonement = new System.Windows.Forms.GroupBox();
            this.textAbonementPrice = new System.Windows.Forms.TextBox();
            this.labelAbonementPrice = new System.Windows.Forms.Label();
            this.buttonSellAbonement = new System.Windows.Forms.Button();
            this.textClientID = new System.Windows.Forms.TextBox();
            this.labelClientID = new System.Windows.Forms.Label();
            this.comboAbonementTerm = new System.Windows.Forms.ComboBox();
            this.labelAbonementTerm = new System.Windows.Forms.Label();
            this.groupDeposit.SuspendLayout();
            this.groupSellAbonement.SuspendLayout();
            this.SuspendLayout();
            // 
            // listClientsFinance
            // 
            this.listClientsFinance.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listClientsFinance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.listClientsFinance.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader12});
            this.listClientsFinance.ForeColor = System.Drawing.Color.White;
            this.listClientsFinance.FullRowSelect = true;
            this.listClientsFinance.HideSelection = false;
            this.listClientsFinance.Location = new System.Drawing.Point(12, 53);
            this.listClientsFinance.Name = "listClientsFinance";
            this.listClientsFinance.Size = new System.Drawing.Size(632, 445);
            this.listClientsFinance.TabIndex = 3;
            this.listClientsFinance.UseCompatibleStateImageBehavior = false;
            this.listClientsFinance.View = System.Windows.Forms.View.Details;
            this.listClientsFinance.SelectedIndexChanged += new System.EventHandler(this.listClientsFinance_SelectedIndexChanged);
            this.listClientsFinance.DoubleClick += new System.EventHandler(this.listClientsFinance_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 27;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Фамилия";
            this.columnHeader2.Width = 75;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Имя";
            this.columnHeader3.Width = 61;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Программа";
            this.columnHeader9.Width = 97;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Счет";
            this.columnHeader10.Width = 57;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Покупка абонемента";
            this.columnHeader6.Width = 126;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Окончание абонемента";
            this.columnHeader7.Width = 131;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Оплата";
            this.columnHeader12.Width = 54;
            // 
            // labelFinance
            // 
            this.labelFinance.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelFinance.AutoSize = true;
            this.labelFinance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFinance.ForeColor = System.Drawing.Color.White;
            this.labelFinance.Location = new System.Drawing.Point(355, 18);
            this.labelFinance.Name = "labelFinance";
            this.labelFinance.Size = new System.Drawing.Size(257, 24);
            this.labelFinance.TabIndex = 6;
            this.labelFinance.Text = "Учет оплаты тренировок";
            // 
            // buttonUpdateList
            // 
            this.buttonUpdateList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonUpdateList.Location = new System.Drawing.Point(405, 515);
            this.buttonUpdateList.Name = "buttonUpdateList";
            this.buttonUpdateList.Size = new System.Drawing.Size(139, 23);
            this.buttonUpdateList.TabIndex = 9;
            this.buttonUpdateList.Text = "Обновить список";
            this.buttonUpdateList.UseVisualStyleBackColor = true;
            this.buttonUpdateList.Click += new System.EventHandler(this.buttonUpdateList_Click);
            // 
            // groupDeposit
            // 
            this.groupDeposit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupDeposit.Controls.Add(this.textDepositSum);
            this.groupDeposit.Controls.Add(this.labelDepositSum);
            this.groupDeposit.Controls.Add(this.buttonDeposit);
            this.groupDeposit.Controls.Add(this.textID);
            this.groupDeposit.Controls.Add(this.labelID);
            this.groupDeposit.ForeColor = System.Drawing.Color.White;
            this.groupDeposit.Location = new System.Drawing.Point(650, 53);
            this.groupDeposit.Name = "groupDeposit";
            this.groupDeposit.Size = new System.Drawing.Size(287, 182);
            this.groupDeposit.TabIndex = 10;
            this.groupDeposit.TabStop = false;
            this.groupDeposit.Text = "Пополнение счета клиента";
            // 
            // textDepositSum
            // 
            this.textDepositSum.Location = new System.Drawing.Point(42, 106);
            this.textDepositSum.Name = "textDepositSum";
            this.textDepositSum.Size = new System.Drawing.Size(200, 20);
            this.textDepositSum.TabIndex = 13;
            // 
            // labelDepositSum
            // 
            this.labelDepositSum.AutoSize = true;
            this.labelDepositSum.Location = new System.Drawing.Point(39, 90);
            this.labelDepositSum.Name = "labelDepositSum";
            this.labelDepositSum.Size = new System.Drawing.Size(104, 13);
            this.labelDepositSum.TabIndex = 12;
            this.labelDepositSum.Text = "Сумма пополнения";
            // 
            // buttonDeposit
            // 
            this.buttonDeposit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonDeposit.ForeColor = System.Drawing.Color.Black;
            this.buttonDeposit.Location = new System.Drawing.Point(70, 143);
            this.buttonDeposit.Name = "buttonDeposit";
            this.buttonDeposit.Size = new System.Drawing.Size(139, 23);
            this.buttonDeposit.TabIndex = 11;
            this.buttonDeposit.Text = "Пополнение счета";
            this.buttonDeposit.UseVisualStyleBackColor = true;
            this.buttonDeposit.Click += new System.EventHandler(this.buttonDeposit_Click);
            // 
            // textID
            // 
            this.textID.Location = new System.Drawing.Point(42, 52);
            this.textID.Name = "textID";
            this.textID.Size = new System.Drawing.Size(200, 20);
            this.textID.TabIndex = 7;
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(39, 36);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(62, 13);
            this.labelID.TabIndex = 6;
            this.labelID.Text = "ID клиента";
            // 
            // groupSellAbonement
            // 
            this.groupSellAbonement.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupSellAbonement.Controls.Add(this.comboAbonementTerm);
            this.groupSellAbonement.Controls.Add(this.labelAbonementTerm);
            this.groupSellAbonement.Controls.Add(this.textAbonementPrice);
            this.groupSellAbonement.Controls.Add(this.labelAbonementPrice);
            this.groupSellAbonement.Controls.Add(this.buttonSellAbonement);
            this.groupSellAbonement.Controls.Add(this.textClientID);
            this.groupSellAbonement.Controls.Add(this.labelClientID);
            this.groupSellAbonement.ForeColor = System.Drawing.Color.White;
            this.groupSellAbonement.Location = new System.Drawing.Point(650, 241);
            this.groupSellAbonement.Name = "groupSellAbonement";
            this.groupSellAbonement.Size = new System.Drawing.Size(287, 257);
            this.groupSellAbonement.TabIndex = 14;
            this.groupSellAbonement.TabStop = false;
            this.groupSellAbonement.Text = "Продажа абонемента клиенту";
            // 
            // textAbonementPrice
            // 
            this.textAbonementPrice.Location = new System.Drawing.Point(42, 159);
            this.textAbonementPrice.Name = "textAbonementPrice";
            this.textAbonementPrice.Size = new System.Drawing.Size(200, 20);
            this.textAbonementPrice.TabIndex = 13;
            // 
            // labelAbonementPrice
            // 
            this.labelAbonementPrice.AutoSize = true;
            this.labelAbonementPrice.Location = new System.Drawing.Point(39, 143);
            this.labelAbonementPrice.Name = "labelAbonementPrice";
            this.labelAbonementPrice.Size = new System.Drawing.Size(126, 13);
            this.labelAbonementPrice.TabIndex = 12;
            this.labelAbonementPrice.Text = "Стоимость абонемента";
            // 
            // buttonSellAbonement
            // 
            this.buttonSellAbonement.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonSellAbonement.ForeColor = System.Drawing.Color.Black;
            this.buttonSellAbonement.Location = new System.Drawing.Point(70, 206);
            this.buttonSellAbonement.Name = "buttonSellAbonement";
            this.buttonSellAbonement.Size = new System.Drawing.Size(139, 23);
            this.buttonSellAbonement.TabIndex = 11;
            this.buttonSellAbonement.Text = "Продажа абонемента";
            this.buttonSellAbonement.UseVisualStyleBackColor = true;
            this.buttonSellAbonement.Click += new System.EventHandler(this.buttonSellAbonement_Click);
            // 
            // textClientID
            // 
            this.textClientID.Location = new System.Drawing.Point(42, 52);
            this.textClientID.Name = "textClientID";
            this.textClientID.Size = new System.Drawing.Size(200, 20);
            this.textClientID.TabIndex = 7;
            // 
            // labelClientID
            // 
            this.labelClientID.AutoSize = true;
            this.labelClientID.Location = new System.Drawing.Point(39, 36);
            this.labelClientID.Name = "labelClientID";
            this.labelClientID.Size = new System.Drawing.Size(62, 13);
            this.labelClientID.TabIndex = 6;
            this.labelClientID.Text = "ID клиента";
            // 
            // comboAbonementTerm
            // 
            this.comboAbonementTerm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboAbonementTerm.FormattingEnabled = true;
            this.comboAbonementTerm.Items.AddRange(new object[] {
            "1 тренировка",
            "8 тренировок",
            "12 тренировок",
            "1 месяц",
            "3 месяца",
            "6 месяцев",
            "1 год"});
            this.comboAbonementTerm.Location = new System.Drawing.Point(42, 106);
            this.comboAbonementTerm.Name = "comboAbonementTerm";
            this.comboAbonementTerm.Size = new System.Drawing.Size(200, 21);
            this.comboAbonementTerm.TabIndex = 20;
            this.comboAbonementTerm.TextChanged += new System.EventHandler(this.comboAbonementTerm_TextChanged);
            // 
            // labelAbonementTerm
            // 
            this.labelAbonementTerm.AutoSize = true;
            this.labelAbonementTerm.Location = new System.Drawing.Point(39, 90);
            this.labelAbonementTerm.Name = "labelAbonementTerm";
            this.labelAbonementTerm.Size = new System.Drawing.Size(96, 13);
            this.labelAbonementTerm.TabIndex = 19;
            this.labelAbonementTerm.Text = "Срок абонемента";
            // 
            // FormFinance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(949, 559);
            this.Controls.Add(this.groupSellAbonement);
            this.Controls.Add(this.groupDeposit);
            this.Controls.Add(this.buttonUpdateList);
            this.Controls.Add(this.labelFinance);
            this.Controls.Add(this.listClientsFinance);
            this.Name = "FormFinance";
            this.Text = "Финансы";
            this.groupDeposit.ResumeLayout(false);
            this.groupDeposit.PerformLayout();
            this.groupSellAbonement.ResumeLayout(false);
            this.groupSellAbonement.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listClientsFinance;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label labelFinance;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        public System.Windows.Forms.Button buttonUpdateList;
        private System.Windows.Forms.GroupBox groupDeposit;
        private System.Windows.Forms.TextBox textDepositSum;
        private System.Windows.Forms.Label labelDepositSum;
        private System.Windows.Forms.Button buttonDeposit;
        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.GroupBox groupSellAbonement;
        private System.Windows.Forms.TextBox textAbonementPrice;
        private System.Windows.Forms.Label labelAbonementPrice;
        private System.Windows.Forms.Button buttonSellAbonement;
        private System.Windows.Forms.TextBox textClientID;
        private System.Windows.Forms.Label labelClientID;
        private System.Windows.Forms.ComboBox comboAbonementTerm;
        private System.Windows.Forms.Label labelAbonementTerm;
    }
}

