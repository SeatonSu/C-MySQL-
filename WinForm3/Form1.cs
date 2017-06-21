using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;


namespace WinForm3
{
    public partial class 登陆 : Form
    {
        public 登陆()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {            
            string strSql = "SELECT * FROM student where name='"+txtName.Text + "' and password='"+txtPassword.Text +"'";
            MySqlDataReader r = MySqlHelper.ExecuteReader(MySqlHelper.MySqlConn, CommandType.Text, strSql, null);
            if (r.Read())
            {
                MessageBox.Show("登陆成功！");
                MainForm frm2 = new MainForm();
                frm2.Show();               
                return;
            }
            else
                MessageBox.Show("登陆失败！");
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
