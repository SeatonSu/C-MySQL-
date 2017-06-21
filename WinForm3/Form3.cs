using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm3
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            TreeNode tN1 = new TreeNode("西红柿");
            TreeNode tN2 = new TreeNode("西瓜");
            TreeNode tN3 = new TreeNode("梨");            
            //this.treeView1 = new System.Windows.Forms.TreeView();
            tN1.Name = "节点10";
            tN1.Text = "西红柿";
            tN2.Name = "节点11";
            tN2.Text = "西瓜";
            tN3.Name = "节点12";
            tN3.Text = "梨";

            this.treeView1.Nodes[0].Nodes.Add("其他水果");
            this.treeView1.Nodes[0].Nodes[1].Nodes.Add(tN1);
            this.treeView1.Nodes[0].Nodes[1].Nodes.Add(tN2);
            this.treeView1.Nodes[0].Nodes[2].Nodes.Add(tN3);          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("弹窗");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            this.btn3.Click += new System.EventHandler(this.button1_Click);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            this.btn3.Click -= new System.EventHandler(this.button1_Click);
        }
    }
}
