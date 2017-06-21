namespace WinForm3
{
    partial class Form3
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("水蜜桃");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("樱桃");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("苹果");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("有核", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("香蕉");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("橙子");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("火龙果");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("去皮", new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode6,
            treeNode7});
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("水果", new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode8});
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(84, 65);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "节点2";
            treeNode1.Text = "水蜜桃";
            treeNode2.Name = "节点5";
            treeNode2.Text = "樱桃";
            treeNode3.Name = "节点6";
            treeNode3.Text = "苹果";
            treeNode4.Name = "节点1";
            treeNode4.Text = "有核";
            treeNode5.Name = "节点8";
            treeNode5.Text = "香蕉";
            treeNode6.Name = "节点9";
            treeNode6.Text = "橙子";
            treeNode7.Name = "节点11";
            treeNode7.Text = "火龙果";
            treeNode8.Name = "节点7";
            treeNode8.Text = "去皮";
            treeNode9.Name = "节点0";
            treeNode9.Text = "水果";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode9});
            this.treeView1.Size = new System.Drawing.Size(120, 325);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(492, 161);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(100, 23);
            this.btn1.TabIndex = 1;
            this.btn1.Text = "动态添加节点";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(492, 234);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(100, 23);
            this.btn2.TabIndex = 2;
            this.btn2.Text = "挂载事件";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(492, 292);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(100, 23);
            this.btn3.TabIndex = 3;
            this.btn3.Text = "弹窗";
            this.btn3.UseVisualStyleBackColor = true;
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(633, 234);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(100, 23);
            this.btn4.TabIndex = 4;
            this.btn4.Text = "取消挂载";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 458);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.treeView1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
    }
}