using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GameCaroAI.Classes;

namespace GameCaroAI.GUI
{
    public partial class Frm_Signin : Form
    {
        DataProcesser dtBase = new DataProcesser();
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        public Frm_Signin()
        {
            InitializeComponent();
        }

        private void lb_signUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_Signup frm_Signup = new Frm_Signup();
            frm_Signup.ShowDialog();
            this.Close();
        }
        public static string HashPassword(string password)
        {
            using (MD5 md5 = MD5.Create())
            {
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(password);
                byte[] hashBytes = md5.ComputeHash(inputBytes);
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("X2"));
                }
                return sb.ToString();
            }
        }
        private void btn_signIn_Click(object sender, EventArgs e)
        {
            string userName = txb_Username.Text;
            string password = txb_Password.Text;
            if(userName == "" || password == "")
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin !");
                return;
            }
            string hashedPassword = HashPassword(password);

            Dictionary<string, object> param = new Dictionary<string, object>()
            {
                {"@Username", userName },
                {"@Password", hashedPassword }
            };
            DataTable dt = dtBase.SearchData("Exec CheckLogin @Username, @Password", param);
            if (dt.Rows.Count > 0)
            {
                PlayerInfo.Username = userName;             
                MessageBox.Show("Đăng nhập thành công !");
                this.Hide();
                Frm_Main frmMain = new Frm_Main();
                frmMain.ShowDialog();
            }
            else
            {
                MessageBox.Show("Tên tài khoản hoặc mật khẩu không chính xác !");
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
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

