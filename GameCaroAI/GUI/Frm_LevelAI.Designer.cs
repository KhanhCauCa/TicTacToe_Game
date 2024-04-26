namespace GameCaroAI.GUI
{
    partial class Frm_LevelAI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_LevelAI));
            this.rdb_hard = new System.Windows.Forms.RadioButton();
            this.rdb_medium = new System.Windows.Forms.RadioButton();
            this.rdb_easy = new System.Windows.Forms.RadioButton();
            this.btn_Start = new Guna.UI2.WinForms.Guna2GradientButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ptb_Exit = new Guna.UI2.WinForms.Guna2PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Exit)).BeginInit();
            this.SuspendLayout();
            // 
            // rdb_hard
            // 
            this.rdb_hard.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rdb_hard.AutoSize = true;
            this.rdb_hard.BackColor = System.Drawing.Color.Transparent;
            this.rdb_hard.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rdb_hard.BackgroundImage")));
            this.rdb_hard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdb_hard.Font = new System.Drawing.Font("MV Boli", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_hard.ForeColor = System.Drawing.Color.Transparent;
            this.rdb_hard.Location = new System.Drawing.Point(242, 270);
            this.rdb_hard.Name = "rdb_hard";
            this.rdb_hard.Size = new System.Drawing.Size(90, 41);
            this.rdb_hard.TabIndex = 13;
            this.rdb_hard.TabStop = true;
            this.rdb_hard.Text = "Khó";
            this.rdb_hard.UseVisualStyleBackColor = false;
            // 
            // rdb_medium
            // 
            this.rdb_medium.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rdb_medium.AutoSize = true;
            this.rdb_medium.BackColor = System.Drawing.Color.Transparent;
            this.rdb_medium.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rdb_medium.BackgroundImage")));
            this.rdb_medium.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdb_medium.Font = new System.Drawing.Font("MV Boli", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_medium.ForeColor = System.Drawing.Color.Transparent;
            this.rdb_medium.Location = new System.Drawing.Point(242, 214);
            this.rdb_medium.Name = "rdb_medium";
            this.rdb_medium.Size = new System.Drawing.Size(190, 41);
            this.rdb_medium.TabIndex = 12;
            this.rdb_medium.TabStop = true;
            this.rdb_medium.Text = "Trung Bình";
            this.rdb_medium.UseVisualStyleBackColor = false;
            // 
            // rdb_easy
            // 
            this.rdb_easy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rdb_easy.AutoSize = true;
            this.rdb_easy.BackColor = System.Drawing.Color.Transparent;
            this.rdb_easy.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rdb_easy.BackgroundImage")));
            this.rdb_easy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdb_easy.Font = new System.Drawing.Font("MV Boli", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_easy.ForeColor = System.Drawing.Color.Transparent;
            this.rdb_easy.Location = new System.Drawing.Point(242, 152);
            this.rdb_easy.Name = "rdb_easy";
            this.rdb_easy.Size = new System.Drawing.Size(76, 41);
            this.rdb_easy.TabIndex = 11;
            this.rdb_easy.TabStop = true;
            this.rdb_easy.Text = "Dễ";
            this.rdb_easy.UseVisualStyleBackColor = false;
            // 
            // btn_Start
            // 
            this.btn_Start.BackColor = System.Drawing.Color.Transparent;
            this.btn_Start.BorderRadius = 20;
            this.btn_Start.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Start.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Start.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Start.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Start.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Start.FillColor = System.Drawing.Color.Transparent;
            this.btn_Start.FillColor2 = System.Drawing.Color.PapayaWhip;
            this.btn_Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Start.ForeColor = System.Drawing.Color.White;
            this.btn_Start.Location = new System.Drawing.Point(216, 332);
            this.btn_Start.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(133, 47);
            this.btn_Start.TabIndex = 17;
            this.btn_Start.Text = "Bắt đầu";
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(94, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 37);
            this.label1.TabIndex = 18;
            this.label1.Text = "Hãy chọn mức độ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Cornsilk;
            this.panel1.Controls.Add(this.ptb_Exit);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(76, 76);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(438, 61);
            this.panel1.TabIndex = 19;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // ptb_Exit
            // 
            this.ptb_Exit.AutoRoundedCorners = true;
            this.ptb_Exit.BackColor = System.Drawing.Color.Transparent;
            this.ptb_Exit.BorderRadius = 18;
            this.ptb_Exit.Image = global::GameCaroAI.Properties.Resources.X;
            this.ptb_Exit.ImageRotate = 0F;
            this.ptb_Exit.Location = new System.Drawing.Point(395, 3);
            this.ptb_Exit.Name = "ptb_Exit";
            this.ptb_Exit.Size = new System.Drawing.Size(40, 38);
            this.ptb_Exit.TabIndex = 19;
            this.ptb_Exit.TabStop = false;
            this.ptb_Exit.Click += new System.EventHandler(this.ptb_Exit_Click);
            // 
            // Frm_LevelAI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImage = global::GameCaroAI.Properties.Resources.wooden1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(592, 443);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_Start);
            this.Controls.Add(this.rdb_hard);
            this.Controls.Add(this.rdb_medium);
            this.Controls.Add(this.rdb_easy);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Frm_LevelAI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Mức độ ";
            this.TransparencyKey = System.Drawing.SystemColors.ControlLight;
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Exit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

		#endregion
		private System.Windows.Forms.RadioButton rdb_hard;
		private System.Windows.Forms.RadioButton rdb_medium;
		private System.Windows.Forms.RadioButton rdb_easy;
		private Guna.UI2.WinForms.Guna2GradientButton btn_Start;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel1;
		private Guna.UI2.WinForms.Guna2PictureBox ptb_Exit;
	}
}