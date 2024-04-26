using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GameCaroAI.Classes;

namespace GameCaroAI.GUI
{
    public partial class Frm_Signup : Form
    {
        DataProcesser dtBase = new DataProcesser();
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        public Frm_Signup()
        {
            InitializeComponent();
        }
        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_Signin frm_signin = new Frm_Signin();
            frm_signin.ShowDialog();
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
        private void btn_singUp_Click(object sender, EventArgs e)
        {
            if(txb_Username.Text == "" || txb_Password.Text == "" || txb_RePassword.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin !");
                return;
            }
            if (txb_Password.Text != txb_RePassword.Text)
            {
                MessageBox.Show("Mật khẩu nhập lại không khớp. Vui lòng nhập lại!");
                return;
            }
            DataTable dataAcc = dtBase.ReadData("select * from Player where Username = N'" + txb_Username.Text + "'");
            if (dataAcc.Rows.Count > 0)
            {
                MessageBox.Show("Tài khoản đã tồn tại. Vui lòng chọn tài khoản khác!");
                return;
            }
            string newPlayerID = dtBase.GeneratePlayerID();
            string hashedPassword = HashPassword(txb_Password.Text);
            string sqlInsert = "Insert into Player (PlayerID, Username, Password, CreateAt) values (@PlayerID, @Username, @Password, getdate())";
            Dictionary<string, object> parameters = new Dictionary<string, object>()
            {
                {"@PlayerID", newPlayerID},
                {"@Username", txb_Username.Text},
                {"@Password", hashedPassword}
            };
            if (dtBase.ChangeData(sqlInsert, parameters))
            {
                MessageBox.Show("Tạo tài khoản mới thành công! Đăng nhập để chơi game nào !");
                this.Hide();
                Frm_Signin frm_signin = new Frm_Signin();
                frm_signin.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Tạo tài khoản thất bại!");
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
    }
}
