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
using System.Data.OleDb;

namespace WinForm3
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void cbDepartment_SelectedValueChanged(object sender, EventArgs e)
        {
            cbClass.Items.Clear();
            if (cbDepartment.SelectedItem.ToString().Equals("地科院"))         
            //if (cbDepartment.SelectedIndex == 1)
            {
                cbClass.Items.Add("小地信");
                cbClass.Items.Add("大地信");
                cbClass.Items.Add("见不得人的地信");
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {           
            String INFO = get_Info();
            TSSL1.Text = INFO;
            txtSum.Text = INFO;
        }

        private string get_Info()
        {
            txtSum.Text = "";
            string sum_txt;
            string tab = "    ";
            sum_txt = txtName.Text + tab;
            if (rdMale.Checked)
            {
                sum_txt += "男" + tab;
            }
            else sum_txt += "女" + tab;

            sum_txt += txtAge.Text + tab + txtNumber.Text + tab + cbDepartment.Text + tab +
                cbClass.Text + tab + txtAddress.Text + tab + dateTimePicker1.Value.ToString("yyyy-MM-dd");
            foreach (CheckBox ckb in this.gpBoxHobby.Controls)
            {
                if (ckb.Checked) sum_txt += ckb.Text + tab;
            }
            return sum_txt;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            pgB.Minimum = 1;
            pgB.Maximum = 100;
            pgB.Value = 1;
            pgB.Step = 10;
            tm1.Enabled = true;
            tm1.Interval = 500;
            //dataGridView1.DataSource = MySqlHelper.GetDataSet(MySqlHelper.Conn,  CommandType.Text, "select * from wp_posts", null).Tables[0].DefaultView;
        }

        private void txtSum_TextChanged(object sender, EventArgs e)
        {

        }

        private void 打开ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            readTXT();
        }

        private void readTXT()
        {
            string path = @"D:\用户目录\我的文档\Visual Studio 2013\Projects\C#_class\WinForm3\待读文件.txt";
            OpenFileDialog dlg = new OpenFileDialog();
            string[] temp;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                System.IO.StreamReader file = new System.IO.StreamReader(path, true);
                string xm;
                while ((xm = file.ReadLine()) != null)
                {
                    temp = xm.Split(new char[] { '：', '、' });
                    if (temp[0] == "姓名") txtName.Text = temp[temp.Length - 1];
                    else if (temp[0] == "性别") rdMale.Checked = true;
                    else if (temp[0] == "学院") cbDepartment.Text = temp[temp.Length - 1];
                    else if (temp[0] == "兴趣爱好")
                    {
                        if (temp.Contains("网络爬虫")) ckSpider.Checked = true;
                        if (temp.Contains("自然语言处理")) ckNLP.Checked = true;
                        if (temp.Contains("数据挖掘")) ckDM.Checked = true;

                    }
                }
            }
        }

        int num = 1;
        private void tm1_Tick(object sender, EventArgs e)
        {           
            if (num <= 10) pgB.PerformStep();
            num++;
            string TimeNow = DateTime.Now.ToString();                       
            TSSL2.Text = TimeNow;
        }

        private void 统计ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string INFO = get_Info();
            TSSL1.Text = INFO;
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            string INFO = get_Info();
            TSSL1.Text = INFO;
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            clcINFO();
        }

        private void clcINFO()
        {
            txtName.Text = "";
            txtNumber.Text = "";
            txtAddress.Text = "";
            txtAge.Text = "";
            txtSum.Text = "";
            TSSL1.Text = "信息";
            cbClass.Text = "";
            cbDepartment.Text = "";
            ckDM.Checked = false;
            ckNLP.Checked = false;
            ckSpider.Checked = false;
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            clcINFO();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //pictureBox1.Image = Image.FromFile("D:\\用户目录\\我的图片\\Camera Roll\\360壁纸 25331.jpg");
            try
            {
                openFileDialog1.Filter = "JPEG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png|BMP Files (*.bmp)|*.bmp|All files (*.*)|*.*";
                openFileDialog1.FilterIndex = 1;
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Load(openFileDialog1.FileName);
                }
            }
            catch
            {
                MessageBox.Show("图片加载失败", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void 关闭ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 保存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveINFO();
        }

        private void saveINFO()
        {
            string path = @"D:\用户目录\我的文档\Visual Studio 2013\Projects\C#_class\WinForm3\学生信息.txt";
            System.IO.StreamWriter sw = new System.IO.StreamWriter(path);
            sw.WriteLine("姓名：" + txtName.Text);
            if (rdMale.Checked == true) sw.WriteLine("性别：" + "男");
            else sw.WriteLine("性别：" + "女");
            sw.WriteLine("年龄：" + txtAge.Text);
            sw.WriteLine("学号：" + txtNumber.Text);
            sw.WriteLine("院系：" + cbDepartment.Text);
            sw.WriteLine("班级：" + cbClass.Text);
            sw.WriteLine("班级：" + cbClass.Text);
            sw.WriteLine("宿舍地址：" + txtAddress.Text);
            sw.WriteLine("出生日期：" + dateTimePicker1.Value.ToString());
            sw.Write("兴趣爱好：");
            if (ckDM.Checked) sw.Write("数据挖掘  ");
            if (ckNLP.Checked) sw.Write("自然语言处理  ");
            if (ckSpider.Checked) sw.Write("网络爬虫  ");
            sw.WriteLine();
            sw.Close();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            readTXT();
        }

        private void 加载ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.IO.FileStream fs = System.IO.File.OpenRead(@"D:\用户目录\我的图片\Camera Roll\360壁纸 25331.jpg");
            System.Drawing.Image result = System.Drawing.Image.FromStream(fs);
            fs.Close();
            pictureBox1.Image = result;
        }



        private void 保存图片ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Image img = pictureBox1.Image;
            Bitmap bit = new Bitmap(img);
            bit.Save(@"D:\用户目录\我的文档\Visual Studio 2013\Projects\C#_class\WinForm3\王金宝头像.jpg");
        }


        private void button1_Click(object sender, EventArgs e)
        {
            //ExecuteReader
            string strSql = "SELECT * FROM student";
            MySqlDataReader r = MySqlHelper.ExecuteReader(MySqlHelper.MySqlConn, CommandType.Text, strSql, null);            
            while (r.Read())
            {
                MessageBox.Show(r[3].ToString());
            }

        }


        private void btnSelect_Click(object sender, EventArgs e)
        {
            string strSql = "SELECT * FROM student";
            MySqlDataReader r = MySqlHelper.ExecuteReader(MySqlHelper.MySqlConn, CommandType.Text, strSql, null);          

            if (r.Read())
            {
                txtName.Text = r["name"].ToString();
                txtAge.Text = r["age"].ToString();
                if (r["sex"].ToString() == "男") rdMale.Checked = true;
                else rdFemale.Checked = true;
                txtNumber.Text = r["schoolID"].ToString();
                cbDepartment.Text = r["faculty"].ToString();
                cbClass.Text = r["class"].ToString();
                txtAddress.Text = r["address"].ToString();
                if (r["Spider"].ToString() == "1") ckSpider.Checked = true; else ckSpider.Checked = false;
                if (r["NLP"].ToString() == "1") ckNLP.Checked = true; else ckNLP.Checked = false;
                if (r["DM"].ToString() == "1") ckDM.Checked = true; else ckDM.Checked = false;
                dateTimePicker1.Value = r.GetDateTime("birthday");                
                //MessageBox.Show(r["birthday"].ToString());
            }
        }

        private void btnSelectMAX_Click(object sender, EventArgs e)
        {
            string strSql = "SELECT MAX(grade) FROM student";
            object r = MySqlHelper.ExecuteScalar(MySqlHelper.MySqlConn, CommandType.Text, strSql, null);
            MessageBox.Show(r.ToString());
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string strSql = "UPDATE student SET password='这是修改过的数据！' WHERE name='盖宸德'";
            int i = MySqlHelper.ExecuteNonQuery(MySqlHelper.MySqlConn, CommandType.Text, strSql, null);
            if(i==1) MessageBox.Show("修改数据成功！");
            else MessageBox.Show("修改数据失败！");
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string sex, NLP, Spider, DM;
            if(rdFemale.Checked) sex="女";
            else sex="男";
            if (ckDM.Checked) DM = "1";
            else DM = "0";
            if (ckNLP.Checked) NLP = "1";
            else NLP = "0";
            if (ckSpider.Checked) Spider = "1";
            else Spider = "0";            
            string column = "INSERT INTO student(schoolID,name,age,faculty,class,address,sex,Spider,NLP,DM,birthday) ";
            string values = "values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}')";
            string strSql = string.Format(column + values, txtNumber.Text, txtName.Text, txtAge.Text, cbDepartment.Text,
                cbClass.Text, txtAddress.Text, sex, Spider, NLP, DM, dateTimePicker1.Value.ToString());
            int i = MySqlHelper.ExecuteNonQuery(MySqlHelper.MySqlConn, CommandType.Text, strSql, null);            
            if (i == 1) MessageBox.Show("插入数据成功！");
            else MessageBox.Show("插入数据失败！");           
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string strSql = "DELETE FROM student WHERE name='孙晨星'";
            int i = MySqlHelper.ExecuteNonQuery(MySqlHelper.MySqlConn, CommandType.Text, strSql, null);
            if (i == 1) MessageBox.Show("删除数据成功！");
            else MessageBox.Show("删除数据失败！");
        }

        private void btnShowData_Click(object sender, EventArgs e)
        {
            string strSql = "SELECT name,grade FROM student";
            DataSet ds = MySqlHelper.GetDataSet(MySqlHelper.MySqlConn, CommandType.Text, strSql, null);            
            DataTable table = ds.Tables[0];
            dataGridView1.DataSource = table;
        }

        private void DataSet_Click(object sender, EventArgs e)
        {
            
            string connection = @"Provider=MySqlProv;Data Source=localhost;Data Base=test;User Id=root;" +
            "Password=Su199649";
            if (txtName.Text == "" && txtNumber.Text == "")
            {
                MessageBox.Show("学号或者名字不能为空！");
                return;
            }
            string str = "";
            if (txtNumber.Text != "")
            {
                str = "schoolID='"+txtNumber.Text+"'";
            }
            if (txtName.Text != "")
            {
                if (str == "") str = "name='" + txtName.Text + "'";
                else str = "and name='" + txtName.Text + "'";
            }            
            OleDbConnection conn = new OleDbConnection(connection);            
            string sql = "select grade from student where" + str;
            OleDbCommand cmd = new OleDbCommand(sql, conn);            
            try
            {
                conn.Open();
                MessageBox.Show("读到数据");
                OleDbDataReader read = cmd.ExecuteReader();
                
                while (read.Read())
                {
                    MessageBox.Show("读到数据");
                    txtName.Text = read["name"].ToString();
                    txtNumber.Text = read["number"].ToString();
                    txtAge.Text = read["grade"].ToString();
                }
            }
            catch (Exception ex)
            {
                string message = ex.Message;
                MessageBox.Show(message);
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }
        }
    }
}