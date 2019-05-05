namespace satisfactory_calculator.Forms
{
    partial class EditSettings
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
            System.Windows.Forms.TreeNode treeNode28 = new System.Windows.Forms.TreeNode("Name:");
            System.Windows.Forms.TreeNode treeNode29 = new System.Windows.Forms.TreeNode("Name:");
            System.Windows.Forms.TreeNode treeNode30 = new System.Windows.Forms.TreeNode("Qty:");
            System.Windows.Forms.TreeNode treeNode31 = new System.Windows.Forms.TreeNode("Material:", new System.Windows.Forms.TreeNode[] {
            treeNode29,
            treeNode30});
            System.Windows.Forms.TreeNode treeNode32 = new System.Windows.Forms.TreeNode("Name:");
            System.Windows.Forms.TreeNode treeNode33 = new System.Windows.Forms.TreeNode("Qty:");
            System.Windows.Forms.TreeNode treeNode34 = new System.Windows.Forms.TreeNode("Material:", new System.Windows.Forms.TreeNode[] {
            treeNode32,
            treeNode33});
            System.Windows.Forms.TreeNode treeNode35 = new System.Windows.Forms.TreeNode("Ingredients: ", new System.Windows.Forms.TreeNode[] {
            treeNode31,
            treeNode34});
            System.Windows.Forms.TreeNode treeNode36 = new System.Windows.Forms.TreeNode("Machine:", new System.Windows.Forms.TreeNode[] {
            treeNode28,
            treeNode35});
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonApply = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageMachines = new System.Windows.Forms.TabPage();
            this.tabPageRecipes = new System.Windows.Forms.TabPage();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.treeViewMachines = new System.Windows.Forms.TreeView();
            this.tabControl.SuspendLayout();
            this.tabPageMachines.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.Location = new System.Drawing.Point(370, 12);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 0;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // buttonApply
            // 
            this.buttonApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonApply.Location = new System.Drawing.Point(451, 12);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(75, 23);
            this.buttonApply.TabIndex = 1;
            this.buttonApply.Text = "Apply";
            this.buttonApply.UseVisualStyleBackColor = true;
            this.buttonApply.Click += new System.EventHandler(this.ButtonApply_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOK.Location = new System.Drawing.Point(289, 12);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 2;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.ButtonOK_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageMachines);
            this.tabControl.Controls.Add(this.tabPageRecipes);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(538, 459);
            this.tabControl.TabIndex = 3;
            // 
            // tabPageMachines
            // 
            this.tabPageMachines.Controls.Add(this.treeViewMachines);
            this.tabPageMachines.Location = new System.Drawing.Point(4, 22);
            this.tabPageMachines.Name = "tabPageMachines";
            this.tabPageMachines.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMachines.Size = new System.Drawing.Size(530, 433);
            this.tabPageMachines.TabIndex = 0;
            this.tabPageMachines.Text = "Machines";
            this.tabPageMachines.UseVisualStyleBackColor = true;
            // 
            // tabPageRecipes
            // 
            this.tabPageRecipes.Location = new System.Drawing.Point(4, 22);
            this.tabPageRecipes.Name = "tabPageRecipes";
            this.tabPageRecipes.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRecipes.Size = new System.Drawing.Size(530, 447);
            this.tabPageRecipes.TabIndex = 1;
            this.tabPageRecipes.Text = "Recipes";
            this.tabPageRecipes.UseVisualStyleBackColor = true;
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            this.splitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.tabControl);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.buttonCancel);
            this.splitContainer.Panel2.Controls.Add(this.buttonApply);
            this.splitContainer.Panel2.Controls.Add(this.buttonOK);
            this.splitContainer.Size = new System.Drawing.Size(538, 507);
            this.splitContainer.SplitterDistance = 459;
            this.splitContainer.SplitterWidth = 1;
            this.splitContainer.TabIndex = 4;
            // 
            // treeViewMachines
            // 
            this.treeViewMachines.LabelEdit = true;
            this.treeViewMachines.Location = new System.Drawing.Point(225, 6);
            this.treeViewMachines.Name = "treeViewMachines";
            treeNode28.Name = "Node8";
            treeNode28.Text = "Name:";
            treeNode29.Name = "Node11";
            treeNode29.Text = "Name:";
            treeNode30.Name = "Node12";
            treeNode30.Text = "Qty:";
            treeNode31.Name = "Node10";
            treeNode31.Text = "Material:";
            treeNode32.Name = "Node14";
            treeNode32.Text = "Name:";
            treeNode33.Name = "Node15";
            treeNode33.Text = "Qty:";
            treeNode34.Name = "Node13";
            treeNode34.Text = "Material:";
            treeNode35.Name = "Node9";
            treeNode35.Text = "Ingredients: ";
            treeNode36.Name = "Node1";
            treeNode36.Text = "Machine:";
            this.treeViewMachines.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode36});
            this.treeViewMachines.Size = new System.Drawing.Size(297, 435);
            this.treeViewMachines.TabIndex = 0;
            // 
            // EditSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 507);
            this.Controls.Add(this.splitContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "EditSettings";
            this.Text = "Edit Settings";
            this.tabControl.ResumeLayout(false);
            this.tabPageMachines.ResumeLayout(false);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonApply;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageMachines;
        private System.Windows.Forms.TabPage tabPageRecipes;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.TreeView treeViewMachines;
    }
}