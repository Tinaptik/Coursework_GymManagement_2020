namespace GymManagement.UI
{
    partial class FormAddTrainer
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
            this.comboTrainingProgram = new System.Windows.Forms.ComboBox();
            this.gymLogo = new System.Windows.Forms.PictureBox();
            this.buttonNewTrainer = new System.Windows.Forms.Button();
            this.labelTrainingProgram = new System.Windows.Forms.Label();
            this.textPhoneNumber = new System.Windows.Forms.TextBox();
            this.labelPhoneNumber = new System.Windows.Forms.Label();
            this.textPatronymic = new System.Windows.Forms.TextBox();
            this.labelPatronymic = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.textSurname = new System.Windows.Forms.TextBox();
            this.labelSurname = new System.Windows.Forms.Label();
            this.labelNewTrainer = new System.Windows.Forms.Label();
            this.textSalary = new System.Windows.Forms.TextBox();
            this.labelSalary = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gymLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // comboTrainingProgram
            // 
            this.comboTrainingProgram.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTrainingProgram.FormattingEnabled = true;
            this.comboTrainingProgram.Location = new System.Drawing.Point(179, 321);
            this.comboTrainingProgram.Name = "comboTrainingProgram";
            this.comboTrainingProgram.Size = new System.Drawing.Size(242, 21);
            this.comboTrainingProgram.TabIndex = 38;
            // 
            // gymLogo
            // 
            this.gymLogo.BackColor = System.Drawing.Color.Transparent;
            this.gymLogo.Image = global::GymManagement.Properties.Resources.logo;
            this.gymLogo.Location = new System.Drawing.Point(146, 21);
            this.gymLogo.Name = "gymLogo";
            this.gymLogo.Size = new System.Drawing.Size(161, 80);
            this.gymLogo.TabIndex = 37;
            this.gymLogo.TabStop = false;
            // 
            // buttonNewTrainer
            // 
            this.buttonNewTrainer.Location = new System.Drawing.Point(158, 415);
            this.buttonNewTrainer.Name = "buttonNewTrainer";
            this.buttonNewTrainer.Size = new System.Drawing.Size(137, 23);
            this.buttonNewTrainer.TabIndex = 35;
            this.buttonNewTrainer.Text = "Добавить тренера";
            this.buttonNewTrainer.UseVisualStyleBackColor = true;
            this.buttonNewTrainer.Click += new System.EventHandler(this.buttonNewTrainer_Click);
            // 
            // labelTrainingProgram
            // 
            this.labelTrainingProgram.AutoSize = true;
            this.labelTrainingProgram.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTrainingProgram.ForeColor = System.Drawing.Color.White;
            this.labelTrainingProgram.Location = new System.Drawing.Point(57, 320);
            this.labelTrainingProgram.Name = "labelTrainingProgram";
            this.labelTrainingProgram.Size = new System.Drawing.Size(92, 18);
            this.labelTrainingProgram.TabIndex = 33;
            this.labelTrainingProgram.Text = "Программа:";
            // 
            // textPhoneNumber
            // 
            this.textPhoneNumber.Location = new System.Drawing.Point(179, 282);
            this.textPhoneNumber.Name = "textPhoneNumber";
            this.textPhoneNumber.Size = new System.Drawing.Size(242, 20);
            this.textPhoneNumber.TabIndex = 32;
            // 
            // labelPhoneNumber
            // 
            this.labelPhoneNumber.AutoSize = true;
            this.labelPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPhoneNumber.ForeColor = System.Drawing.Color.White;
            this.labelPhoneNumber.Location = new System.Drawing.Point(57, 282);
            this.labelPhoneNumber.Name = "labelPhoneNumber";
            this.labelPhoneNumber.Size = new System.Drawing.Size(76, 18);
            this.labelPhoneNumber.TabIndex = 31;
            this.labelPhoneNumber.Text = "Телефон:";
            // 
            // textPatronymic
            // 
            this.textPatronymic.Location = new System.Drawing.Point(179, 246);
            this.textPatronymic.Name = "textPatronymic";
            this.textPatronymic.Size = new System.Drawing.Size(242, 20);
            this.textPatronymic.TabIndex = 30;
            // 
            // labelPatronymic
            // 
            this.labelPatronymic.AutoSize = true;
            this.labelPatronymic.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPatronymic.ForeColor = System.Drawing.Color.White;
            this.labelPatronymic.Location = new System.Drawing.Point(57, 246);
            this.labelPatronymic.Name = "labelPatronymic";
            this.labelPatronymic.Size = new System.Drawing.Size(79, 18);
            this.labelPatronymic.TabIndex = 29;
            this.labelPatronymic.Text = "Отчество:";
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(179, 210);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(242, 20);
            this.textName.TabIndex = 28;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.ForeColor = System.Drawing.Color.White;
            this.labelName.Location = new System.Drawing.Point(57, 210);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(42, 18);
            this.labelName.TabIndex = 27;
            this.labelName.Text = "Имя:";
            // 
            // textSurname
            // 
            this.textSurname.Location = new System.Drawing.Point(179, 175);
            this.textSurname.Name = "textSurname";
            this.textSurname.Size = new System.Drawing.Size(242, 20);
            this.textSurname.TabIndex = 26;
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSurname.ForeColor = System.Drawing.Color.White;
            this.labelSurname.Location = new System.Drawing.Point(57, 175);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(77, 18);
            this.labelSurname.TabIndex = 25;
            this.labelSurname.Text = "Фамилия:";
            // 
            // labelNewTrainer
            // 
            this.labelNewTrainer.AutoSize = true;
            this.labelNewTrainer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNewTrainer.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelNewTrainer.Location = new System.Drawing.Point(132, 126);
            this.labelNewTrainer.Name = "labelNewTrainer";
            this.labelNewTrainer.Size = new System.Drawing.Size(188, 20);
            this.labelNewTrainer.TabIndex = 24;
            this.labelNewTrainer.Text = "Добавление тренера";
            // 
            // textSalary
            // 
            this.textSalary.Location = new System.Drawing.Point(179, 361);
            this.textSalary.Name = "textSalary";
            this.textSalary.Size = new System.Drawing.Size(242, 20);
            this.textSalary.TabIndex = 40;
            // 
            // labelSalary
            // 
            this.labelSalary.AutoSize = true;
            this.labelSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSalary.ForeColor = System.Drawing.Color.White;
            this.labelSalary.Location = new System.Drawing.Point(57, 361);
            this.labelSalary.Name = "labelSalary";
            this.labelSalary.Size = new System.Drawing.Size(78, 18);
            this.labelSalary.TabIndex = 39;
            this.labelSalary.Text = "Зарплата:";
            // 
            // FormAddTrainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(453, 471);
            this.Controls.Add(this.textSalary);
            this.Controls.Add(this.labelSalary);
            this.Controls.Add(this.comboTrainingProgram);
            this.Controls.Add(this.gymLogo);
            this.Controls.Add(this.buttonNewTrainer);
            this.Controls.Add(this.labelTrainingProgram);
            this.Controls.Add(this.textPhoneNumber);
            this.Controls.Add(this.labelPhoneNumber);
            this.Controls.Add(this.textPatronymic);
            this.Controls.Add(this.labelPatronymic);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textSurname);
            this.Controls.Add(this.labelSurname);
            this.Controls.Add(this.labelNewTrainer);
            this.Name = "FormAddTrainer";
            this.Text = "FormAddTrainer";
            ((System.ComponentModel.ISupportInitialize)(this.gymLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboTrainingProgram;
        private System.Windows.Forms.PictureBox gymLogo;
        private System.Windows.Forms.Button buttonNewTrainer;
        private System.Windows.Forms.Label labelTrainingProgram;
        private System.Windows.Forms.TextBox textPhoneNumber;
        private System.Windows.Forms.Label labelPhoneNumber;
        private System.Windows.Forms.TextBox textPatronymic;
        private System.Windows.Forms.Label labelPatronymic;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textSurname;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.Label labelNewTrainer;
        private System.Windows.Forms.TextBox textSalary;
        private System.Windows.Forms.Label labelSalary;
    }
}