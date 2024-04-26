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
    public partial class Frm_LevelAI : Form
    {
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        public Frm_LevelAI()
        {
            InitializeComponent();
        }
        private void btn_Start_Click(object sender, EventArgs e)
        {
            int level;
            if (rdb_easy.Checked)
                level = 0;
            else if (rdb_medium.Checked)
                level = 1;
            else if (rdb_hard.Checked)
                level = 2;
            else
                level = 0;
            this.Hide();
            FrmAI frmAI = new FrmAI(level);
            frmAI.ShowDialog();
            this.Close();
        }
		private void ptb_Exit_Click(object sender, EventArgs e)
		{
            this.Close();
		}
        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point diff = Point.Subtract(Cursor.Position, new System.Drawing.Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new System.Drawing.Size(diff));
            }
        }
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }
    }
}
