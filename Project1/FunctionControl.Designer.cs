using Gizmox.WebGUI.Forms;
using Gizmox.WebGUI.Common;

namespace Project1
{
    partial class FunctionControl
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

        #region Visual WebGui UserControl Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.navigationTabs1 = new Gizmox.WebGUI.Forms.NavigationTabs();
            this.viewTab = new Gizmox.WebGUI.Forms.NavigationTab();
            this.AdminTab = new Gizmox.WebGUI.Forms.NavigationTab();
            this.treeView1 = new Gizmox.WebGUI.Forms.TreeView();
            this.treeNode1 = new Gizmox.WebGUI.Forms.TreeNode();
            this.treeNode2 = new Gizmox.WebGUI.Forms.TreeNode();
            this.treeNode3 = new Gizmox.WebGUI.Forms.TreeNode();
            this.treeNode4 = new Gizmox.WebGUI.Forms.TreeNode();
            ((System.ComponentModel.ISupportInitialize)(this.navigationTabs1)).BeginInit();
            this.navigationTabs1.SuspendLayout();
            this.AdminTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // navigationTabs1
            // 
            this.navigationTabs1.Controls.Add(this.viewTab);
            this.navigationTabs1.Controls.Add(this.AdminTab);
            this.navigationTabs1.CustomStyle = "Navigation";
            this.navigationTabs1.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.navigationTabs1.Location = new System.Drawing.Point(0, 0);
            this.navigationTabs1.Name = "navigationTabs1";
            this.navigationTabs1.SelectedIndex = 0;
            this.navigationTabs1.SelectOnRightClick = true;
            this.navigationTabs1.Size = new System.Drawing.Size(433, 495);
            this.navigationTabs1.TabIndex = 0;
            // 
            // viewTab
            // 
            this.viewTab.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.viewTab.Extra = false;
            this.viewTab.Location = new System.Drawing.Point(0, 0);
            this.viewTab.Name = "viewTab";
            this.viewTab.Size = new System.Drawing.Size(425, 466);
            this.viewTab.TabIndex = 0;
            this.viewTab.Text = "View";
            // 
            // AdminTab
            // 
            this.AdminTab.Controls.Add(this.treeView1);
            this.AdminTab.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.AdminTab.Extra = false;
            this.AdminTab.Location = new System.Drawing.Point(0, 0);
            this.AdminTab.Name = "AdminTab";
            this.AdminTab.Size = new System.Drawing.Size(425, 466);
            this.AdminTab.TabIndex = 1;
            this.AdminTab.Text = "Administration";
            // 
            // treeView1
            // 
            this.treeView1.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            this.treeView1.Nodes.AddRange(new Gizmox.WebGUI.Forms.TreeNode[] {
            this.treeNode1});
            this.treeView1.Size = new System.Drawing.Size(425, 466);
            this.treeView1.TabIndex = 0;
            // 
            // treeNode1
            // 
            this.treeNode1.Name = "";
            this.treeNode1.Nodes.AddRange(new Gizmox.WebGUI.Forms.TreeNode[] {
            this.treeNode2,
            this.treeNode3,
            this.treeNode4});
            this.treeNode1.Text = "Security";
            // 
            // treeNode2
            // 
            this.treeNode2.Name = "";
            this.treeNode2.Text = "Users Management";
            // 
            // treeNode3
            // 
            this.treeNode3.Name = "";
            this.treeNode3.Text = "Groups Management";
            // 
            // treeNode4
            // 
            this.treeNode4.Name = "";
            this.treeNode4.Text = "Roles management";
            // 
            // FunctionControl
            // 
            this.Controls.Add(this.navigationTabs1);
            this.Size = new System.Drawing.Size(433, 495);
            this.Text = "FunctionControl";
            ((System.ComponentModel.ISupportInitialize)(this.navigationTabs1)).EndInit();
            this.navigationTabs1.ResumeLayout(false);
            this.AdminTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private NavigationTabs navigationTabs1;
        private NavigationTab viewTab;
        private NavigationTab AdminTab;
        private TreeView treeView1;
        private TreeNode treeNode1;
        private TreeNode treeNode2;
        private TreeNode treeNode3;
        private TreeNode treeNode4;



    }
}