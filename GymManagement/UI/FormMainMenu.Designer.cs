namespace GymManagement
{
    partial class FormMainMenu
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
            this.components = new System.ComponentModel.Container();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.buttonTrainingProgram = new FontAwesome.Sharp.IconButton();
            this.buttonStaff = new FontAwesome.Sharp.IconButton();
            this.buttonClients = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.buttonHome = new System.Windows.Forms.PictureBox();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.buttonMinimize = new FontAwesome.Sharp.IconPictureBox();
            this.buttonMaximize = new FontAwesome.Sharp.IconPictureBox();
            this.buttonExit = new FontAwesome.Sharp.IconPictureBox();
            this.labelTitleChildForm = new System.Windows.Forms.Label();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.panelShadow = new System.Windows.Forms.Panel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timerTime = new System.Windows.Forms.Timer(this.components);
            this.timerDate = new System.Windows.Forms.Timer(this.components);
            this.buttonSchedule = new FontAwesome.Sharp.IconButton();
            this.buttonFinance = new FontAwesome.Sharp.IconButton();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonHome)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonMaximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            this.panelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panelMenu.Controls.Add(this.buttonFinance);
            this.panelMenu.Controls.Add(this.buttonSchedule);
            this.panelMenu.Controls.Add(this.buttonTrainingProgram);
            this.panelMenu.Controls.Add(this.buttonStaff);
            this.panelMenu.Controls.Add(this.buttonClients);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 631);
            this.panelMenu.TabIndex = 0;
            // 
            // buttonTrainingProgram
            // 
            this.buttonTrainingProgram.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonTrainingProgram.FlatAppearance.BorderSize = 0;
            this.buttonTrainingProgram.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTrainingProgram.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.buttonTrainingProgram.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonTrainingProgram.IconChar = FontAwesome.Sharp.IconChar.Dumbbell;
            this.buttonTrainingProgram.IconColor = System.Drawing.Color.Gainsboro;
            this.buttonTrainingProgram.IconSize = 32;
            this.buttonTrainingProgram.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonTrainingProgram.Location = new System.Drawing.Point(0, 260);
            this.buttonTrainingProgram.Name = "buttonTrainingProgram";
            this.buttonTrainingProgram.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.buttonTrainingProgram.Rotation = 0D;
            this.buttonTrainingProgram.Size = new System.Drawing.Size(220, 60);
            this.buttonTrainingProgram.TabIndex = 2;
            this.buttonTrainingProgram.Text = "Программы тренировок";
            this.buttonTrainingProgram.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonTrainingProgram.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonTrainingProgram.UseVisualStyleBackColor = true;
            this.buttonTrainingProgram.Click += new System.EventHandler(this.buttonTrainingProgram_Click);
            // 
            // buttonStaff
            // 
            this.buttonStaff.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonStaff.FlatAppearance.BorderSize = 0;
            this.buttonStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStaff.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.buttonStaff.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonStaff.IconChar = FontAwesome.Sharp.IconChar.UserTie;
            this.buttonStaff.IconColor = System.Drawing.Color.Gainsboro;
            this.buttonStaff.IconSize = 32;
            this.buttonStaff.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonStaff.Location = new System.Drawing.Point(0, 200);
            this.buttonStaff.Name = "buttonStaff";
            this.buttonStaff.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.buttonStaff.Rotation = 0D;
            this.buttonStaff.Size = new System.Drawing.Size(220, 60);
            this.buttonStaff.TabIndex = 1;
            this.buttonStaff.Text = "Тренеры";
            this.buttonStaff.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonStaff.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonStaff.UseVisualStyleBackColor = true;
            this.buttonStaff.Click += new System.EventHandler(this.buttonStaff_Click);
            // 
            // buttonClients
            // 
            this.buttonClients.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonClients.FlatAppearance.BorderSize = 0;
            this.buttonClients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClients.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.buttonClients.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonClients.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.buttonClients.IconColor = System.Drawing.Color.Gainsboro;
            this.buttonClients.IconSize = 32;
            this.buttonClients.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonClients.Location = new System.Drawing.Point(0, 140);
            this.buttonClients.Name = "buttonClients";
            this.buttonClients.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.buttonClients.Rotation = 0D;
            this.buttonClients.Size = new System.Drawing.Size(220, 60);
            this.buttonClients.TabIndex = 0;
            this.buttonClients.Text = "Клиенты";
            this.buttonClients.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonClients.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonClients.UseVisualStyleBackColor = true;
            this.buttonClients.Click += new System.EventHandler(this.buttonClients_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.buttonHome);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 140);
            this.panelLogo.TabIndex = 0;
            // 
            // buttonHome
            // 
            this.buttonHome.BackColor = System.Drawing.Color.Transparent;
            this.buttonHome.Image = global::GymManagement.Properties.Resources.logo;
            this.buttonHome.Location = new System.Drawing.Point(28, 30);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(161, 80);
            this.buttonHome.TabIndex = 0;
            this.buttonHome.TabStop = false;
            this.buttonHome.Click += new System.EventHandler(this.buttonHome_Click);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panelTitleBar.Controls.Add(this.buttonMinimize);
            this.panelTitleBar.Controls.Add(this.buttonMaximize);
            this.panelTitleBar.Controls.Add(this.buttonExit);
            this.panelTitleBar.Controls.Add(this.labelTitleChildForm);
            this.panelTitleBar.Controls.Add(this.iconCurrentChildForm);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(220, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(948, 75);
            this.panelTitleBar.TabIndex = 1;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // buttonMinimize
            // 
            this.buttonMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.buttonMinimize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(127)))), ((int)(((byte)(163)))));
            this.buttonMinimize.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.buttonMinimize.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(127)))), ((int)(((byte)(163)))));
            this.buttonMinimize.Location = new System.Drawing.Point(837, 3);
            this.buttonMinimize.Name = "buttonMinimize";
            this.buttonMinimize.Size = new System.Drawing.Size(32, 32);
            this.buttonMinimize.TabIndex = 4;
            this.buttonMinimize.TabStop = false;
            this.buttonMinimize.Click += new System.EventHandler(this.buttonMinimize_Click);
            // 
            // buttonMaximize
            // 
            this.buttonMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMaximize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.buttonMaximize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(127)))), ((int)(((byte)(163)))));
            this.buttonMaximize.IconChar = FontAwesome.Sharp.IconChar.WindowRestore;
            this.buttonMaximize.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(127)))), ((int)(((byte)(163)))));
            this.buttonMaximize.Location = new System.Drawing.Point(875, 3);
            this.buttonMaximize.Name = "buttonMaximize";
            this.buttonMaximize.Size = new System.Drawing.Size(32, 32);
            this.buttonMaximize.TabIndex = 3;
            this.buttonMaximize.TabStop = false;
            this.buttonMaximize.Click += new System.EventHandler(this.buttonMaximize_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.buttonExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(127)))), ((int)(((byte)(163)))));
            this.buttonExit.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.buttonExit.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(127)))), ((int)(((byte)(163)))));
            this.buttonExit.Location = new System.Drawing.Point(913, 3);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(32, 32);
            this.buttonExit.TabIndex = 2;
            this.buttonExit.TabStop = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // labelTitleChildForm
            // 
            this.labelTitleChildForm.AutoSize = true;
            this.labelTitleChildForm.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelTitleChildForm.Location = new System.Drawing.Point(53, 35);
            this.labelTitleChildForm.Name = "labelTitleChildForm";
            this.labelTitleChildForm.Size = new System.Drawing.Size(99, 13);
            this.labelTitleChildForm.TabIndex = 1;
            this.labelTitleChildForm.Text = "Главная страница";
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.iconCurrentChildForm.ForeColor = System.Drawing.Color.MediumPurple;
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconCurrentChildForm.IconColor = System.Drawing.Color.MediumPurple;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(18, 26);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(32, 32);
            this.iconCurrentChildForm.TabIndex = 0;
            this.iconCurrentChildForm.TabStop = false;
            // 
            // panelShadow
            // 
            this.panelShadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
            this.panelShadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelShadow.Location = new System.Drawing.Point(220, 75);
            this.panelShadow.Name = "panelShadow";
            this.panelShadow.Size = new System.Drawing.Size(948, 9);
            this.panelShadow.TabIndex = 2;
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panelDesktop.Controls.Add(this.labelDate);
            this.panelDesktop.Controls.Add(this.labelTime);
            this.panelDesktop.Controls.Add(this.pictureBox1);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(220, 84);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(948, 547);
            this.panelDesktop.TabIndex = 0;
            // 
            // labelDate
            // 
            this.labelDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelDate.ForeColor = System.Drawing.Color.Silver;
            this.labelDate.Location = new System.Drawing.Point(419, 371);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(100, 24);
            this.labelDate.TabIndex = 3;
            this.labelDate.Text = "31.12.2020";
            // 
            // labelTime
            // 
            this.labelTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.labelTime.ForeColor = System.Drawing.Color.White;
            this.labelTime.Location = new System.Drawing.Point(402, 326);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(133, 36);
            this.labelTime.TabIndex = 3;
            this.labelTime.Text = "99:99:99";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::GymManagement.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(394, 234);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // timerTime
            // 
            this.timerTime.Enabled = true;
            this.timerTime.Tick += new System.EventHandler(this.timerTime_Tick);
            // 
            // timerDate
            // 
            this.timerDate.Enabled = true;
            this.timerDate.Tick += new System.EventHandler(this.timerDate_Tick);
            // 
            // buttonSchedule
            // 
            this.buttonSchedule.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonSchedule.FlatAppearance.BorderSize = 0;
            this.buttonSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSchedule.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.buttonSchedule.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonSchedule.IconChar = FontAwesome.Sharp.IconChar.CalendarAlt;
            this.buttonSchedule.IconColor = System.Drawing.Color.Gainsboro;
            this.buttonSchedule.IconSize = 32;
            this.buttonSchedule.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSchedule.Location = new System.Drawing.Point(0, 320);
            this.buttonSchedule.Name = "buttonSchedule";
            this.buttonSchedule.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.buttonSchedule.Rotation = 0D;
            this.buttonSchedule.Size = new System.Drawing.Size(220, 60);
            this.buttonSchedule.TabIndex = 3;
            this.buttonSchedule.Text = "Расписание";
            this.buttonSchedule.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSchedule.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSchedule.UseVisualStyleBackColor = true;
            this.buttonSchedule.Click += new System.EventHandler(this.buttonSchedule_Click_1);
            // 
            // buttonFinance
            // 
            this.buttonFinance.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonFinance.FlatAppearance.BorderSize = 0;
            this.buttonFinance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFinance.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.buttonFinance.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonFinance.IconChar = FontAwesome.Sharp.IconChar.Wallet;
            this.buttonFinance.IconColor = System.Drawing.Color.Gainsboro;
            this.buttonFinance.IconSize = 32;
            this.buttonFinance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonFinance.Location = new System.Drawing.Point(0, 380);
            this.buttonFinance.Name = "buttonFinance";
            this.buttonFinance.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.buttonFinance.Rotation = 0D;
            this.buttonFinance.Size = new System.Drawing.Size(220, 60);
            this.buttonFinance.TabIndex = 4;
            this.buttonFinance.Text = "Финансы";
            this.buttonFinance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonFinance.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonFinance.UseVisualStyleBackColor = true;
            this.buttonFinance.Click += new System.EventHandler(this.buttonFinance_Click_1);
            // 
            // FormMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 631);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelShadow);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Name = "FormMainMenu";
            this.Text = "Управление тренажерным залом";
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.buttonHome)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonMaximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            this.panelDesktop.ResumeLayout(false);
            this.panelDesktop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private FontAwesome.Sharp.IconButton buttonClients;
        private FontAwesome.Sharp.IconButton buttonStaff;
        private System.Windows.Forms.PictureBox buttonHome;
        private System.Windows.Forms.Panel panelTitleBar;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private System.Windows.Forms.Label labelTitleChildForm;
        private System.Windows.Forms.Panel panelShadow;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconPictureBox buttonExit;
        private FontAwesome.Sharp.IconPictureBox buttonMaximize;
        private FontAwesome.Sharp.IconPictureBox buttonMinimize;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Timer timerTime;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Timer timerDate;
        private FontAwesome.Sharp.IconButton buttonTrainingProgram;
        private FontAwesome.Sharp.IconButton buttonFinance;
        private FontAwesome.Sharp.IconButton buttonSchedule;
    }
}

