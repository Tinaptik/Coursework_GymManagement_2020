namespace GymManagement.Forms
{
    partial class Form1
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
            this.labelNewClient = new System.Windows.Forms.Label();
            this.labelSurname = new System.Windows.Forms.Label();
            this.textSurname = new System.Windows.Forms.TextBox();
            this.textName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.textPatronymic = new System.Windows.Forms.TextBox();
            this.labelPatronymic = new System.Windows.Forms.Label();
            this.textPhoneNumber = new System.Windows.Forms.TextBox();
            this.labelPhoneNumber = new System.Windows.Forms.Label();
            this.labelTrainingProgram = new System.Windows.Forms.Label();
            this.labelTrainer = new System.Windows.Forms.Label();
            this.buttonNewClient = new System.Windows.Forms.Button();
            this.comboTrainer = new System.Windows.Forms.ComboBox();
            this.comboTrainingProgram = new System.Windows.Forms.ComboBox();
            this.gymLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gymLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNewClient
            // 
            this.labelNewClient.AutoSize = true;
            this.labelNewClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNewClient.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelNewClient.Location = new System.Drawing.Point(132, 126);
            this.labelNewClient.Name = "labelNewClient";
            this.labelNewClient.Size = new System.Drawing.Size(188, 20);
            this.labelNewClient.TabIndex = 0;
            this.labelNewClient.Text = "Добавление клиента";
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSurname.ForeColor = System.Drawing.Color.White;
            this.labelSurname.Location = new System.Drawing.Point(57, 175);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(77, 18);
            this.labelSurname.TabIndex = 1;
            this.labelSurname.Text = "Фамилия:";
            // 
            // textSurname
            // 
            this.textSurname.Location = new System.Drawing.Point(179, 175);
            this.textSurname.Name = "textSurname";
            this.textSurname.Size = new System.Drawing.Size(242, 20);
            this.textSurname.TabIndex = 2;
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(179, 210);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(242, 20);
            this.textName.TabIndex = 4;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.ForeColor = System.Drawing.Color.White;
            this.labelName.Location = new System.Drawing.Point(57, 210);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(42, 18);
            this.labelName.TabIndex = 3;
            this.labelName.Text = "Имя:";
            // 
            // textPatronymic
            // 
            this.textPatronymic.Location = new System.Drawing.Point(179, 246);
            this.textPatronymic.Name = "textPatronymic";
            this.textPatronymic.Size = new System.Drawing.Size(242, 20);
            this.textPatronymic.TabIndex = 6;
            // 
            // labelPatronymic
            // 
            this.labelPatronymic.AutoSize = true;
            this.labelPatronymic.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPatronymic.ForeColor = System.Drawing.Color.White;
            this.labelPatronymic.Location = new System.Drawing.Point(57, 246);
            this.labelPatronymic.Name = "labelPatronymic";
            this.labelPatronymic.Size = new System.Drawing.Size(79, 18);
            this.labelPatronymic.TabIndex = 5;
            this.labelPatronymic.Text = "Отчество:";
            // 
            // textPhoneNumber
            // 
            this.textPhoneNumber.Location = new System.Drawing.Point(179, 282);
            this.textPhoneNumber.Name = "textPhoneNumber";
            this.textPhoneNumber.Size = new System.Drawing.Size(242, 20);
            this.textPhoneNumber.TabIndex = 8;
            // 
            // labelPhoneNumber
            // 
            this.labelPhoneNumber.AutoSize = true;
            this.labelPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPhoneNumber.ForeColor = System.Drawing.Color.White;
            this.labelPhoneNumber.Location = new System.Drawing.Point(57, 282);
            this.labelPhoneNumber.Name = "labelPhoneNumber";
            this.labelPhoneNumber.Size = new System.Drawing.Size(76, 18);
            this.labelPhoneNumber.TabIndex = 7;
            this.labelPhoneNumber.Text = "Телефон:";
            // 
            // labelTrainingProgram
            // 
            this.labelTrainingProgram.AutoSize = true;
            this.labelTrainingProgram.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTrainingProgram.ForeColor = System.Drawing.Color.White;
            this.labelTrainingProgram.Location = new System.Drawing.Point(57, 320);
            this.labelTrainingProgram.Name = "labelTrainingProgram";
            this.labelTrainingProgram.Size = new System.Drawing.Size(92, 18);
            this.labelTrainingProgram.TabIndex = 9;
            this.labelTrainingProgram.Text = "Программа:";
            // 
            // labelTrainer
            // 
            this.labelTrainer.AutoSize = true;
            this.labelTrainer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTrainer.ForeColor = System.Drawing.Color.White;
            this.labelTrainer.Location = new System.Drawing.Point(57, 359);
            this.labelTrainer.Name = "labelTrainer";
            this.labelTrainer.Size = new System.Drawing.Size(61, 18);
            this.labelTrainer.TabIndex = 11;
            this.labelTrainer.Text = "Тренер:";
            // 
            // buttonNewClient
            // 
            this.buttonNewClient.Location = new System.Drawing.Point(158, 422);
            this.buttonNewClient.Name = "buttonNewClient";
            this.buttonNewClient.Size = new System.Drawing.Size(137, 23);
            this.buttonNewClient.TabIndex = 19;
            this.buttonNewClient.Text = "Добавить клиента";
            this.buttonNewClient.UseVisualStyleBackColor = true;
            this.buttonNewClient.Click += new System.EventHandler(this.buttonNewClient_Click);
            // 
            // comboTrainer
            // 
            this.comboTrainer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTrainer.FormattingEnabled = true;
            this.comboTrainer.Location = new System.Drawing.Point(179, 360);
            this.comboTrainer.Name = "comboTrainer";
            this.comboTrainer.Size = new System.Drawing.Size(242, 21);
            this.comboTrainer.TabIndex = 21;
            // 
            // comboTrainingProgram
            // 
            this.comboTrainingProgram.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTrainingProgram.FormattingEnabled = true;
            this.comboTrainingProgram.Location = new System.Drawing.Point(179, 321);
            this.comboTrainingProgram.Name = "comboTrainingProgram";
            this.comboTrainingProgram.Size = new System.Drawing.Size(242, 21);
            this.comboTrainingProgram.TabIndex = 23;
            // 
            // gymLogo
            // 
            this.gymLogo.BackColor = System.Drawing.Color.Transparent;
            this.gymLogo.Image = global::GymManagement.Properties.Resources.logo;
            this.gymLogo.Location = new System.Drawing.Point(146, 21);
            this.gymLogo.Name = "gymLogo";
            this.gymLogo.Size = new System.Drawing.Size(161, 80);
            this.gymLogo.TabIndex = 22;
            this.gymLogo.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(453, 495);
            this.Controls.Add(this.comboTrainingProgram);
            this.Controls.Add(this.gymLogo);
            this.Controls.Add(this.comboTrainer);
            this.Controls.Add(this.buttonNewClient);
            this.Controls.Add(this.labelTrainer);
            this.Controls.Add(this.labelTrainingProgram);
            this.Controls.Add(this.textPhoneNumber);
            this.Controls.Add(this.labelPhoneNumber);
            this.Controls.Add(this.textPatronymic);
            this.Controls.Add(this.labelPatronymic);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textSurname);
            this.Controls.Add(this.labelSurname);
            this.Controls.Add(this.labelNewClient);
            this.Name = "Form1";
            this.Text = "Добавление клиента";
            ((System.ComponentModel.ISupportInitialize)(this.gymLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNewClient;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.TextBox textSurname;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textPatronymic;
        private System.Windows.Forms.Label labelPatronymic;
        private System.Windows.Forms.TextBox textPhoneNumber;
        private System.Windows.Forms.Label labelPhoneNumber;
        private System.Windows.Forms.Label labelTrainingProgram;
        private System.Windows.Forms.Label labelTrainer;
        private System.Windows.Forms.Button buttonNewClient;
        private System.Windows.Forms.ComboBox comboTrainer;
        private System.Windows.Forms.PictureBox gymLogo;
        private System.Windows.Forms.ComboBox comboTrainingProgram;
    }
}