namespace GameCaroAI.GUI
{
    partial class Frm_Signup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Signup));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txb_RePassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_Back = new Guna.UI2.WinForms.Guna2Button();
            this.btn_singUp = new Guna.UI2.WinForms.Guna2Button();
            this.txb_Password = new Guna.UI2.WinForms.Guna2TextBox();
            this.txb_Username = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ptb_Exit = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Exit)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ptb_Exit);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txb_RePassword);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btn_Back);
            this.panel1.Controls.Add(this.btn_singUp);
            this.panel1.Controls.Add(this.txb_Password);
            this.panel1.Controls.Add(this.txb_Username);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(509, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(399, 502);
            this.panel1.TabIndex = 2;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.Location = new System.Drawing.Point(91, 312);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 29);
            this.label3.TabIndex = 36;
            this.label3.Text = "     ";
            // 
            // txb_RePassword
            // 
            this.txb_RePassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txb_RePassword.BorderColor = System.Drawing.Color.RosyBrown;
            this.txb_RePassword.BorderRadius = 20;
            this.txb_RePassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txb_RePassword.DefaultText = "";
            this.txb_RePassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txb_RePassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txb_RePassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_RePassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_RePassword.FillColor = System.Drawing.SystemColors.Info;
            this.txb_RePassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_RePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txb_RePassword.ForeColor = System.Drawing.Color.Black;
            this.txb_RePassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_RePassword.Location = new System.Drawing.Point(43, 356);
            this.txb_RePassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txb_RePassword.Name = "txb_RePassword";
            this.txb_RePassword.PasswordChar = '●';
            this.txb_RePassword.PlaceholderForeColor = System.Drawing.Color.White;
            this.txb_RePassword.PlaceholderText = "";
            this.txb_RePassword.SelectedText = "";
            this.txb_RePassword.Size = new System.Drawing.Size(308, 47);
            this.txb_RePassword.TabIndex = 35;
            this.txb_RePassword.UseSystemPasswordChar = true;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(4)))), ((int)(((byte)(118)))));
            this.label7.Location = new System.Drawing.Point(138, 312);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(161, 29);
            this.label7.TabIndex = 34;
            this.label7.Text = "RePassword";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Image = ((System.Drawing.Image)(resources.GetObject("label6.Image")));
            this.label6.Location = new System.Drawing.Point(104, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 29);
            this.label6.TabIndex = 33;
            this.label6.Text = "     ";
            // 
            // btn_Back
            // 
            this.btn_Back.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Back.BorderRadius = 25;
            this.btn_Back.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Back.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Back.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Back.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btn_Back.ForeColor = System.Drawing.Color.White;
            this.btn_Back.Location = new System.Drawing.Point(227, 430);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(121, 48);
            this.btn_Back.TabIndex = 31;
            this.btn_Back.Text = "Back";
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // btn_singUp
            // 
            this.btn_singUp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_singUp.BorderRadius = 25;
            this.btn_singUp.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_singUp.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_singUp.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_singUp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_singUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_singUp.ForeColor = System.Drawing.Color.White;
            this.btn_singUp.Location = new System.Drawing.Point(61, 430);
            this.btn_singUp.Name = "btn_singUp";
            this.btn_singUp.Size = new System.Drawing.Size(121, 48);
            this.btn_singUp.TabIndex = 32;
            this.btn_singUp.Text = "Sign Up";
            this.btn_singUp.Click += new System.EventHandler(this.btn_singUp_Click);
            // 
            // txb_Password
            // 
            this.txb_Password.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txb_Password.BorderColor = System.Drawing.Color.RosyBrown;
            this.txb_Password.BorderRadius = 20;
            this.txb_Password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txb_Password.DefaultText = "";
            this.txb_Password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txb_Password.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txb_Password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_Password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_Password.FillColor = System.Drawing.SystemColors.Info;
            this.txb_Password.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txb_Password.ForeColor = System.Drawing.Color.Black;
            this.txb_Password.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_Password.Location = new System.Drawing.Point(43, 242);
            this.txb_Password.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txb_Password.Name = "txb_Password";
            this.txb_Password.PasswordChar = '●';
            this.txb_Password.PlaceholderForeColor = System.Drawing.Color.White;
            this.txb_Password.PlaceholderText = "";
            this.txb_Password.SelectedText = "";
            this.txb_Password.Size = new System.Drawing.Size(308, 47);
            this.txb_Password.TabIndex = 29;
            this.txb_Password.UseSystemPasswordChar = true;
            // 
            // txb_Username
            // 
            this.txb_Username.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txb_Username.AutoRoundedCorners = true;
            this.txb_Username.BorderColor = System.Drawing.Color.RosyBrown;
            this.txb_Username.BorderRadius = 21;
            this.txb_Username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txb_Username.DefaultText = "";
            this.txb_Username.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txb_Username.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txb_Username.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_Username.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_Username.FillColor = System.Drawing.SystemColors.Info;
            this.txb_Username.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txb_Username.ForeColor = System.Drawing.Color.Black;
            this.txb_Username.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_Username.Location = new System.Drawing.Point(46, 125);
            this.txb_Username.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txb_Username.Name = "txb_Username";
            this.txb_Username.PasswordChar = '\0';
            this.txb_Username.PlaceholderText = "";
            this.txb_Username.SelectedText = "";
            this.txb_Username.Size = new System.Drawing.Size(305, 45);
            this.txb_Username.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.Image = ((System.Drawing.Image)(resources.GetObject("label5.Image")));
            this.label5.Location = new System.Drawing.Point(104, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 32);
            this.label5.TabIndex = 30;
            this.label5.Text = "     ";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(4)))), ((int)(((byte)(118)))));
            this.label1.Location = new System.Drawing.Point(151, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 29);
            this.label1.TabIndex = 27;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(4)))), ((int)(((byte)(118)))));
            this.label2.Location = new System.Drawing.Point(151, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 29);
            this.label2.TabIndex = 28;
            this.label2.Text = "Password";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(126, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 42);
            this.label4.TabIndex = 25;
            this.label4.Text = "Sign Up";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(509, 502);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // ptb_Exit
            // 
            this.ptb_Exit.Image = ((System.Drawing.Image)(resources.GetObject("ptb_Exit.Image")));
            this.ptb_Exit.Location = new System.Drawing.Point(359, 0);
            this.ptb_Exit.Name = "ptb_Exit";
            this.ptb_Exit.Size = new System.Drawing.Size(40, 43);
            this.ptb_Exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_Exit.TabIndex = 37;
            this.ptb_Exit.TabStop = false;
            this.ptb_Exit.Click += new System.EventHandler(this.ptb_Exit_Click);
            // 
            // Frm_Signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(908, 502);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Frm_Signup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Signup";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Exit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label label6;
        public Guna.UI2.WinForms.Guna2Button btn_Back;
        public Guna.UI2.WinForms.Guna2Button btn_singUp;
        public Guna.UI2.WinForms.Guna2TextBox txb_Password;
        public Guna.UI2.WinForms.Guna2TextBox txb_Username;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label3;
        public Guna.UI2.WinForms.Guna2TextBox txb_RePassword;
        public System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox ptb_Exit;
    }
}