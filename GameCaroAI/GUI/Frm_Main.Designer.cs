using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameCaroAI.GUI
{
    partial class Frm_Main
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Main));
			this.btn_TwoPlayer = new Guna.UI2.WinForms.Guna2GradientButton();
			this.btn_PlayOnl = new Guna.UI2.WinForms.Guna2GradientButton();
			this.btn_VsComputer = new Guna.UI2.WinForms.Guna2GradientButton();
			this.btn_Exit = new Guna.UI2.WinForms.Guna2GradientButton();
			this.ptb_Exit = new Guna.UI2.WinForms.Guna2PictureBox();
			this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
			this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			this.btn_backToSignIn = new Guna.UI2.WinForms.Guna2GradientButton();
			this.cb_Rules = new Guna.UI2.WinForms.Guna2ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.ptb_Exit)).BeginInit();
			this.SuspendLayout();
			// 
			// btn_TwoPlayer
			// 
			this.btn_TwoPlayer.BackColor = System.Drawing.Color.Transparent;
			this.btn_TwoPlayer.BorderColor = System.Drawing.Color.White;
			this.btn_TwoPlayer.BorderRadius = 20;
			this.btn_TwoPlayer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btn_TwoPlayer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btn_TwoPlayer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btn_TwoPlayer.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btn_TwoPlayer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btn_TwoPlayer.FillColor = System.Drawing.Color.Transparent;
			this.btn_TwoPlayer.FillColor2 = System.Drawing.Color.Black;
			this.btn_TwoPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
			this.btn_TwoPlayer.ForeColor = System.Drawing.Color.White;
			this.btn_TwoPlayer.HoverState.Image = global::GameCaroAI.Properties.Resources.mũitengo1;
			this.btn_TwoPlayer.Location = new System.Drawing.Point(319, 320);
			this.btn_TwoPlayer.Margin = new System.Windows.Forms.Padding(4);
			this.btn_TwoPlayer.Name = "btn_TwoPlayer";
			this.btn_TwoPlayer.Size = new System.Drawing.Size(231, 54);
			this.btn_TwoPlayer.TabIndex = 0;
			this.btn_TwoPlayer.Text = "HAI NGƯỜI CHƠI";
			this.btn_TwoPlayer.Click += new System.EventHandler(this.btn_TwoPlayer_Click);
			// 
			// btn_PlayOnl
			// 
			this.btn_PlayOnl.BackColor = System.Drawing.Color.Transparent;
			this.btn_PlayOnl.BorderRadius = 20;
			this.btn_PlayOnl.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btn_PlayOnl.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btn_PlayOnl.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btn_PlayOnl.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btn_PlayOnl.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btn_PlayOnl.FillColor = System.Drawing.Color.Transparent;
			this.btn_PlayOnl.FillColor2 = System.Drawing.Color.Black;
			this.btn_PlayOnl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
			this.btn_PlayOnl.ForeColor = System.Drawing.Color.White;
			this.btn_PlayOnl.HoverState.Image = global::GameCaroAI.Properties.Resources.mũitengo1;
			this.btn_PlayOnl.Location = new System.Drawing.Point(319, 392);
			this.btn_PlayOnl.Margin = new System.Windows.Forms.Padding(4);
			this.btn_PlayOnl.Name = "btn_PlayOnl";
			this.btn_PlayOnl.Size = new System.Drawing.Size(231, 54);
			this.btn_PlayOnl.TabIndex = 0;
			this.btn_PlayOnl.Text = "CHƠI ONLINE";
			this.btn_PlayOnl.Click += new System.EventHandler(this.btn_PlayOnl_Click);
			// 
			// btn_VsComputer
			// 
			this.btn_VsComputer.BackColor = System.Drawing.Color.Transparent;
			this.btn_VsComputer.BorderColor = System.Drawing.Color.Transparent;
			this.btn_VsComputer.BorderRadius = 20;
			this.btn_VsComputer.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.btn_VsComputer.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.btn_VsComputer.CustomImages.ImageSize = new System.Drawing.Size(320, 290);
			this.btn_VsComputer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btn_VsComputer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btn_VsComputer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btn_VsComputer.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btn_VsComputer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btn_VsComputer.FillColor = System.Drawing.Color.Transparent;
			this.btn_VsComputer.FillColor2 = System.Drawing.Color.Black;
			this.btn_VsComputer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
			this.btn_VsComputer.ForeColor = System.Drawing.Color.White;
			this.btn_VsComputer.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
			this.btn_VsComputer.Location = new System.Drawing.Point(319, 242);
			this.btn_VsComputer.Margin = new System.Windows.Forms.Padding(4);
			this.btn_VsComputer.Name = "btn_VsComputer";
			this.btn_VsComputer.Size = new System.Drawing.Size(231, 57);
			this.btn_VsComputer.TabIndex = 0;
			this.btn_VsComputer.Text = "ĐÁNH VỚI MÁY";
			this.btn_VsComputer.Click += new System.EventHandler(this.btn_VsComputer_Click);
			// 
			// btn_Exit
			// 
			this.btn_Exit.BackColor = System.Drawing.Color.Transparent;
			this.btn_Exit.BorderRadius = 20;
			this.btn_Exit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btn_Exit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btn_Exit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btn_Exit.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btn_Exit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btn_Exit.FillColor = System.Drawing.Color.Transparent;
			this.btn_Exit.FillColor2 = System.Drawing.Color.Black;
			this.btn_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
			this.btn_Exit.ForeColor = System.Drawing.Color.White;
			this.btn_Exit.HoverState.Image = global::GameCaroAI.Properties.Resources.mũitengo1;
			this.btn_Exit.Location = new System.Drawing.Point(371, 521);
			this.btn_Exit.Name = "btn_Exit";
			this.btn_Exit.Size = new System.Drawing.Size(123, 33);
			this.btn_Exit.TabIndex = 3;
			this.btn_Exit.Text = "Thoát";
			this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
			// 
			// ptb_Exit
			// 
			this.ptb_Exit.AutoRoundedCorners = true;
			this.ptb_Exit.BackColor = System.Drawing.Color.Transparent;
			this.ptb_Exit.BorderRadius = 18;
			this.ptb_Exit.Image = global::GameCaroAI.Properties.Resources.X;
			this.ptb_Exit.ImageRotate = 0F;
			this.ptb_Exit.Location = new System.Drawing.Point(773, 55);
			this.ptb_Exit.Name = "ptb_Exit";
			this.ptb_Exit.Size = new System.Drawing.Size(40, 38);
			this.ptb_Exit.TabIndex = 8;
			this.ptb_Exit.TabStop = false;
			this.ptb_Exit.Click += new System.EventHandler(this.ptb_Exit_Click);
			// 
			// guna2Elipse1
			// 
			this.guna2Elipse1.BorderRadius = 300;
			this.guna2Elipse1.TargetControl = this;
			// 
			// btn_backToSignIn
			// 
			this.btn_backToSignIn.BackColor = System.Drawing.Color.Transparent;
			this.btn_backToSignIn.BorderRadius = 20;
			this.btn_backToSignIn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btn_backToSignIn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btn_backToSignIn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btn_backToSignIn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btn_backToSignIn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btn_backToSignIn.FillColor = System.Drawing.Color.Transparent;
			this.btn_backToSignIn.FillColor2 = System.Drawing.Color.Black;
			this.btn_backToSignIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
			this.btn_backToSignIn.ForeColor = System.Drawing.Color.White;
			this.btn_backToSignIn.HoverState.Image = global::GameCaroAI.Properties.Resources.mũitengo1;
			this.btn_backToSignIn.Location = new System.Drawing.Point(319, 454);
			this.btn_backToSignIn.Margin = new System.Windows.Forms.Padding(4);
			this.btn_backToSignIn.Name = "btn_backToSignIn";
			this.btn_backToSignIn.Size = new System.Drawing.Size(231, 54);
			this.btn_backToSignIn.TabIndex = 9;
			this.btn_backToSignIn.Text = "Quay lại";
			this.btn_backToSignIn.Click += new System.EventHandler(this.btn_backToSignIn_Click);
			// 
			// cb_Rules
			// 
			this.cb_Rules.BackColor = System.Drawing.Color.Transparent;
			this.cb_Rules.BorderColor = System.Drawing.Color.Transparent;
			this.cb_Rules.BorderRadius = 15;
			this.cb_Rules.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cb_Rules.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cb_Rules.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.cb_Rules.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.cb_Rules.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
			this.cb_Rules.ForeColor = System.Drawing.Color.DarkGray;
			this.cb_Rules.ItemHeight = 30;
			this.cb_Rules.Items.AddRange(new object[] {
            "Gomoku (Luật tự do)",
            "Gomoku (Luật tiêu chuẩn)",
            "Caro (Chặn hai đầu)",
            "Luật Renju"});
			this.cb_Rules.Location = new System.Drawing.Point(319, 175);
			this.cb_Rules.Name = "cb_Rules";
			this.cb_Rules.Size = new System.Drawing.Size(231, 36);
			this.cb_Rules.StartIndex = 0;
			this.cb_Rules.TabIndex = 1;
			// 
			// Frm_Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Black;
			this.BackgroundImage = global::GameCaroAI.Properties.Resources.unnamed;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(858, 689);
			this.Controls.Add(this.btn_backToSignIn);
			this.Controls.Add(this.ptb_Exit);
			this.Controls.Add(this.btn_Exit);
			this.Controls.Add(this.btn_TwoPlayer);
			this.Controls.Add(this.cb_Rules);
			this.Controls.Add(this.btn_PlayOnl);
			this.Controls.Add(this.btn_VsComputer);
			this.DoubleBuffered = true;
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "Frm_Main";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Đăng nhập";
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pn_LoginRight_MouseDown);
			this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pn_LoginRight_MouseMove);
			this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pn_LoginRight_MouseUp);
			((System.ComponentModel.ISupportInitialize)(this.ptb_Exit)).EndInit();
			this.ResumeLayout(false);

        }

		#endregion

		private Guna.UI2.WinForms.Guna2GradientButton btn_TwoPlayer;
		private Guna.UI2.WinForms.Guna2GradientButton btn_PlayOnl;
		private Guna.UI2.WinForms.Guna2GradientButton btn_VsComputer;
		private Guna.UI2.WinForms.Guna2GradientButton btn_Exit;
		private Guna.UI2.WinForms.Guna2PictureBox ptb_Exit;
		private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
		private BackgroundWorker backgroundWorker1;
        private Guna.UI2.WinForms.Guna2GradientButton btn_backToSignIn;
		private Guna.UI2.WinForms.Guna2ComboBox cb_Rules;
	}
}