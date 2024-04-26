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
    public partial class Frm_Main : Form
    {
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        public Frm_Main()
        {
            InitializeComponent();
        }

        private void btn_VsComputer_Click(object sender, EventArgs e)
        {
            Frm_LevelAI frmLevel = new Frm_LevelAI();
            frmLevel.ShowDialog();
            this.Show();
        }
        private void btn_TwoPlayer_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_TwoPlayers frm_two = new Frm_TwoPlayers();
            frm_two.ShowDialog();
            this.Show();
        }
        private void btn_PlayOnl_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hệ thống đang phát triển !",
                            "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void pn_LoginRight_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void pn_LoginRight_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point diff = Point.Subtract(Cursor.Position, new System.Drawing.Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new System.Drawing.Size(diff));
            }
        }

        private void pn_LoginRight_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn chắc chắn muốn thoát ?",
                                    "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
                this.Close();
            }
        }
        private void ptb_Exit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn chắc chắn muốn thoát ?",
                                    "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
                this.Close();
            }
        }
        private void btn_backToSignIn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_Signin frm_Signin = new Frm_Signin();
            frm_Signin.ShowDialog();
            this.Close();
        }
    }
}
