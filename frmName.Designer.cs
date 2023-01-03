namespace WindowsFormsApp8
{
    partial class frmName
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("User Profile");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Shopping Iteams");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("My Inventory");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Statistics And Charts");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Home inventory system", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4});
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lbllogo = new System.Windows.Forms.Label();
            this.panelApp = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblusername = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelnavegation = new System.Windows.Forms.Panel();
            this.panelcontent = new System.Windows.Forms.Panel();
            this.treeViewnavigation = new System.Windows.Forms.TreeView();
            this.panelHeader.SuspendLayout();
            this.panelApp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelnavegation.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.White;
            this.panelHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelHeader.Controls.Add(this.lbllogo);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(4);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(871, 91);
            this.panelHeader.TabIndex = 0;
            // 
            // lbllogo
            // 
            this.lbllogo.AutoSize = true;
            this.lbllogo.Location = new System.Drawing.Point(12, 33);
            this.lbllogo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbllogo.Name = "lbllogo";
            this.lbllogo.Size = new System.Drawing.Size(180, 19);
            this.lbllogo.TabIndex = 0;
            this.lbllogo.Text = "Home inventory system";
            // 
            // panelApp
            // 
            this.panelApp.BackColor = System.Drawing.Color.White;
            this.panelApp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelApp.Controls.Add(this.btnExit);
            this.panelApp.Controls.Add(this.lblusername);
            this.panelApp.Controls.Add(this.pictureBox1);
            this.panelApp.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelApp.Location = new System.Drawing.Point(0, 91);
            this.panelApp.Margin = new System.Windows.Forms.Padding(4);
            this.panelApp.Name = "panelApp";
            this.panelApp.Size = new System.Drawing.Size(871, 100);
            this.panelApp.TabIndex = 1;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(783, 68);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblusername
            // 
            this.lblusername.AutoSize = true;
            this.lblusername.Location = new System.Drawing.Point(99, 42);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(110, 19);
            this.lblusername.TabIndex = 1;
            this.lblusername.Text = "Reem Badawi";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp8.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(3, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(90, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelnavegation
            // 
            this.panelnavegation.BackColor = System.Drawing.Color.White;
            this.panelnavegation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelnavegation.Controls.Add(this.treeViewnavigation);
            this.panelnavegation.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelnavegation.Location = new System.Drawing.Point(0, 191);
            this.panelnavegation.Margin = new System.Windows.Forms.Padding(4);
            this.panelnavegation.Name = "panelnavegation";
            this.panelnavegation.Size = new System.Drawing.Size(299, 449);
            this.panelnavegation.TabIndex = 2;
            // 
            // panelcontent
            // 
            this.panelcontent.BackColor = System.Drawing.Color.White;
            this.panelcontent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelcontent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelcontent.Location = new System.Drawing.Point(299, 191);
            this.panelcontent.Margin = new System.Windows.Forms.Padding(4);
            this.panelcontent.Name = "panelcontent";
            this.panelcontent.Size = new System.Drawing.Size(572, 449);
            this.panelcontent.TabIndex = 3;
            // 
            // treeViewnavigation
            // 
            this.treeViewnavigation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewnavigation.Location = new System.Drawing.Point(0, 0);
            this.treeViewnavigation.Name = "treeViewnavigation";
            treeNode1.Name = "NodeUserProfile";
            treeNode1.Text = "User Profile";
            treeNode2.Name = "Node2ShoppingIteams";
            treeNode2.Text = "Shopping Iteams";
            treeNode3.Name = "Node3MyInventory";
            treeNode3.Text = "My Inventory";
            treeNode4.Name = "Node4StatisticsAndCharts";
            treeNode4.Text = "Statistics And Charts";
            treeNode5.Name = "NodeRoot";
            treeNode5.Text = "Home inventory system";
            this.treeViewnavigation.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode5});
            this.treeViewnavigation.Size = new System.Drawing.Size(297, 447);
            this.treeViewnavigation.TabIndex = 0;
            // 
            // frmName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 640);
            this.Controls.Add(this.panelcontent);
            this.Controls.Add(this.panelnavegation);
            this.Controls.Add(this.panelApp);
            this.Controls.Add(this.panelHeader);
            this.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmName";
            this.Text = "Home inventory system";
            this.Load += new System.EventHandler(this.frmName_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelApp.ResumeLayout(false);
            this.panelApp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelnavegation.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panelApp;
        private System.Windows.Forms.Panel panelnavegation;
        private System.Windows.Forms.Panel panelcontent;
        private System.Windows.Forms.Label lbllogo;
        private System.Windows.Forms.Label lblusername;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TreeView treeViewnavigation;
    }
}