namespace satisfactory_calculator
{
	partial class FormMain
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle37 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle38 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle39 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle40 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle41 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle42 = new System.Windows.Forms.DataGridViewCellStyle();
            this.comboBoxMachine = new System.Windows.Forms.ComboBox();
            this.dgvMachines = new System.Windows.Forms.DataGridView();
            this.columnMachinesMachine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnMachinesQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnMachinesOutputResource = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnMachinesOutputTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnMachinesCurrentRecipe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelTop = new System.Windows.Forms.Panel();
            this.panelMaximize = new System.Windows.Forms.Panel();
            this.panelClose = new System.Windows.Forms.Panel();
            this.panelMinimize = new System.Windows.Forms.Panel();
            this.pictureBoxSatisfactoryIcon = new System.Windows.Forms.PictureBox();
            this.groupBoxMachine = new System.Windows.Forms.GroupBox();
            this.groupBoxQty = new System.Windows.Forms.GroupBox();
            this.numericUpDownQty = new System.Windows.Forms.NumericUpDown();
            this.groupBoxRecipe = new System.Windows.Forms.GroupBox();
            this.comboBoxRecipe = new System.Windows.Forms.ComboBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.dgvUsage = new System.Windows.Forms.DataGridView();
            this.columnMachineUsage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnInputTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.dgvGlobalTotals = new System.Windows.Forms.DataGridView();
            this.columnResource = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnOutput = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnInput = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonReadConf = new System.Windows.Forms.Button();
            this.buttonWriteConf = new System.Windows.Forms.Button();
            this.buttonReadTest = new System.Windows.Forms.Button();
            this.buttonWriteTest = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMachines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSatisfactoryIcon)).BeginInit();
            this.groupBoxMachine.SuspendLayout();
            this.groupBoxQty.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQty)).BeginInit();
            this.groupBoxRecipe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGlobalTotals)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxMachine
            // 
            this.comboBoxMachine.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxMachine.FormattingEnabled = true;
            this.comboBoxMachine.Location = new System.Drawing.Point(6, 19);
            this.comboBoxMachine.Name = "comboBoxMachine";
            this.comboBoxMachine.Size = new System.Drawing.Size(189, 21);
            this.comboBoxMachine.TabIndex = 0;
            this.comboBoxMachine.SelectedIndexChanged += new System.EventHandler(this.comboBoxMachine_SelectedIndexChanged);
            this.comboBoxMachine.TextChanged += new System.EventHandler(this.comboBoxMachine_TextChanged);
            // 
            // dgvMachines
            // 
            this.dgvMachines.AllowUserToAddRows = false;
            this.dgvMachines.AllowUserToDeleteRows = false;
            this.dgvMachines.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvMachines.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMachines.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle37.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle37.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle37.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle37.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle37.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle37.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle37.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMachines.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle37;
            this.dgvMachines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMachines.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnMachinesMachine,
            this.columnMachinesQty,
            this.columnMachinesOutputResource,
            this.columnMachinesOutputTotal,
            this.columnMachinesCurrentRecipe});
            this.dgvMachines.Location = new System.Drawing.Point(12, 58);
            this.dgvMachines.MultiSelect = false;
            this.dgvMachines.Name = "dgvMachines";
            this.dgvMachines.ReadOnly = true;
            dataGridViewCellStyle38.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle38.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle38.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle38.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle38.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle38.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle38.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMachines.RowHeadersDefaultCellStyle = dataGridViewCellStyle38;
            this.dgvMachines.RowHeadersVisible = false;
            this.dgvMachines.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMachines.Size = new System.Drawing.Size(503, 540);
            this.dgvMachines.TabIndex = 1;
            this.dgvMachines.SelectionChanged += new System.EventHandler(this.dataGridViewMachines_SelectionChanged);
            // 
            // columnMachinesMachine
            // 
            this.columnMachinesMachine.HeaderText = "Machine";
            this.columnMachinesMachine.Name = "columnMachinesMachine";
            this.columnMachinesMachine.ReadOnly = true;
            this.columnMachinesMachine.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // columnMachinesQty
            // 
            this.columnMachinesQty.FillWeight = 40F;
            this.columnMachinesQty.HeaderText = "Qty";
            this.columnMachinesQty.Name = "columnMachinesQty";
            this.columnMachinesQty.ReadOnly = true;
            // 
            // columnMachinesOutputResource
            // 
            this.columnMachinesOutputResource.FillWeight = 115F;
            this.columnMachinesOutputResource.HeaderText = "Output Resource";
            this.columnMachinesOutputResource.Name = "columnMachinesOutputResource";
            this.columnMachinesOutputResource.ReadOnly = true;
            // 
            // columnMachinesOutputTotal
            // 
            this.columnMachinesOutputTotal.FillWeight = 40F;
            this.columnMachinesOutputTotal.HeaderText = "Total";
            this.columnMachinesOutputTotal.Name = "columnMachinesOutputTotal";
            this.columnMachinesOutputTotal.ReadOnly = true;
            // 
            // columnMachinesCurrentRecipe
            // 
            this.columnMachinesCurrentRecipe.HeaderText = "CurrentRecipe";
            this.columnMachinesCurrentRecipe.Name = "columnMachinesCurrentRecipe";
            this.columnMachinesCurrentRecipe.ReadOnly = true;
            this.columnMachinesCurrentRecipe.Visible = false;
            // 
            // panelTop
            // 
            this.panelTop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTop.Location = new System.Drawing.Point(136, 0);
            this.panelTop.Margin = new System.Windows.Forms.Padding(0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(522, 32);
            this.panelTop.TabIndex = 4;
            this.panelTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseDown);
            // 
            // panelMaximize
            // 
            this.panelMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMaximize.BackgroundImage = global::satisfactory_calculator.Properties.Resources.maximize_16x16;
            this.panelMaximize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelMaximize.Location = new System.Drawing.Point(706, 0);
            this.panelMaximize.Margin = new System.Windows.Forms.Padding(0);
            this.panelMaximize.Name = "panelMaximize";
            this.panelMaximize.Size = new System.Drawing.Size(48, 32);
            this.panelMaximize.TabIndex = 7;
            this.panelMaximize.Click += new System.EventHandler(this.panelMaximize_Click);
            this.panelMaximize.MouseEnter += new System.EventHandler(this.panelButton_MouseEnter);
            this.panelMaximize.MouseLeave += new System.EventHandler(this.panelButton_MouseLeave);
            // 
            // panelClose
            // 
            this.panelClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelClose.BackgroundImage = global::satisfactory_calculator.Properties.Resources.close_16x16;
            this.panelClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelClose.Location = new System.Drawing.Point(754, 0);
            this.panelClose.Margin = new System.Windows.Forms.Padding(0);
            this.panelClose.Name = "panelClose";
            this.panelClose.Size = new System.Drawing.Size(48, 32);
            this.panelClose.TabIndex = 7;
            this.panelClose.Click += new System.EventHandler(this.panelClose_Click);
            this.panelClose.MouseEnter += new System.EventHandler(this.panelButton_MouseEnter);
            this.panelClose.MouseLeave += new System.EventHandler(this.panelButton_MouseLeave);
            // 
            // panelMinimize
            // 
            this.panelMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMinimize.BackgroundImage = global::satisfactory_calculator.Properties.Resources.minimize_16x16;
            this.panelMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelMinimize.Location = new System.Drawing.Point(658, 0);
            this.panelMinimize.Margin = new System.Windows.Forms.Padding(0);
            this.panelMinimize.Name = "panelMinimize";
            this.panelMinimize.Size = new System.Drawing.Size(48, 32);
            this.panelMinimize.TabIndex = 6;
            this.panelMinimize.Click += new System.EventHandler(this.panelMinimize_Click);
            this.panelMinimize.MouseEnter += new System.EventHandler(this.panelButton_MouseEnter);
            this.panelMinimize.MouseLeave += new System.EventHandler(this.panelButton_MouseLeave);
            // 
            // pictureBoxSatisfactoryIcon
            // 
            this.pictureBoxSatisfactoryIcon.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxSatisfactoryIcon.Name = "pictureBoxSatisfactoryIcon";
            this.pictureBoxSatisfactoryIcon.Size = new System.Drawing.Size(136, 52);
            this.pictureBoxSatisfactoryIcon.TabIndex = 2;
            this.pictureBoxSatisfactoryIcon.TabStop = false;
            // 
            // groupBoxMachine
            // 
            this.groupBoxMachine.Controls.Add(this.comboBoxMachine);
            this.groupBoxMachine.Location = new System.Drawing.Point(521, 58);
            this.groupBoxMachine.Name = "groupBoxMachine";
            this.groupBoxMachine.Size = new System.Drawing.Size(201, 52);
            this.groupBoxMachine.TabIndex = 9;
            this.groupBoxMachine.TabStop = false;
            this.groupBoxMachine.Text = "Machines";
            // 
            // groupBoxQty
            // 
            this.groupBoxQty.Controls.Add(this.numericUpDownQty);
            this.groupBoxQty.Location = new System.Drawing.Point(728, 58);
            this.groupBoxQty.Name = "groupBoxQty";
            this.groupBoxQty.Size = new System.Drawing.Size(62, 52);
            this.groupBoxQty.TabIndex = 10;
            this.groupBoxQty.TabStop = false;
            this.groupBoxQty.Text = "Qty";
            // 
            // numericUpDownQty
            // 
            this.numericUpDownQty.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownQty.Location = new System.Drawing.Point(6, 20);
            this.numericUpDownQty.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownQty.Name = "numericUpDownQty";
            this.numericUpDownQty.Size = new System.Drawing.Size(50, 20);
            this.numericUpDownQty.TabIndex = 17;
            this.numericUpDownQty.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownQty.ValueChanged += new System.EventHandler(this.numericUpDownQty_ValueChanged);
            // 
            // groupBoxRecipe
            // 
            this.groupBoxRecipe.Controls.Add(this.comboBoxRecipe);
            this.groupBoxRecipe.Location = new System.Drawing.Point(521, 116);
            this.groupBoxRecipe.Name = "groupBoxRecipe";
            this.groupBoxRecipe.Size = new System.Drawing.Size(165, 52);
            this.groupBoxRecipe.TabIndex = 11;
            this.groupBoxRecipe.TabStop = false;
            this.groupBoxRecipe.Text = "Recipe";
            // 
            // comboBoxRecipe
            // 
            this.comboBoxRecipe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxRecipe.FormattingEnabled = true;
            this.comboBoxRecipe.Location = new System.Drawing.Point(6, 19);
            this.comboBoxRecipe.Name = "comboBoxRecipe";
            this.comboBoxRecipe.Size = new System.Drawing.Size(153, 21);
            this.comboBoxRecipe.TabIndex = 0;
            this.comboBoxRecipe.TextChanged += new System.EventHandler(this.comboBoxResource_TextChanged);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(746, 133);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(38, 23);
            this.buttonAdd.TabIndex = 12;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // dgvUsage
            // 
            this.dgvUsage.AllowUserToAddRows = false;
            this.dgvUsage.AllowUserToDeleteRows = false;
            this.dgvUsage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvUsage.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsage.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle39.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle39.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle39.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle39.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle39.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle39.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle39.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsage.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle39;
            this.dgvUsage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsage.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnMachineUsage,
            this.columnInputTotal});
            this.dgvUsage.Location = new System.Drawing.Point(521, 187);
            this.dgvUsage.MultiSelect = false;
            this.dgvUsage.Name = "dgvUsage";
            this.dgvUsage.ReadOnly = true;
            dataGridViewCellStyle40.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle40.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle40.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle40.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle40.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle40.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle40.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsage.RowHeadersDefaultCellStyle = dataGridViewCellStyle40;
            this.dgvUsage.RowHeadersVisible = false;
            this.dgvUsage.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvUsage.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsage.Size = new System.Drawing.Size(269, 109);
            this.dgvUsage.TabIndex = 14;
            // 
            // columnMachineUsage
            // 
            this.columnMachineUsage.HeaderText = "MachineUsage";
            this.columnMachineUsage.Name = "columnMachineUsage";
            this.columnMachineUsage.ReadOnly = true;
            // 
            // columnInputTotal
            // 
            this.columnInputTotal.FillWeight = 40F;
            this.columnInputTotal.HeaderText = "Total";
            this.columnInputTotal.Name = "columnInputTotal";
            this.columnInputTotal.ReadOnly = true;
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(702, 133);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(38, 23);
            this.buttonEdit.TabIndex = 15;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // dgvGlobalTotals
            // 
            this.dgvGlobalTotals.AllowUserToAddRows = false;
            this.dgvGlobalTotals.AllowUserToDeleteRows = false;
            this.dgvGlobalTotals.AllowUserToResizeRows = false;
            this.dgvGlobalTotals.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvGlobalTotals.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGlobalTotals.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvGlobalTotals.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle41.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle41.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle41.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle41.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle41.NullValue = null;
            dataGridViewCellStyle41.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle41.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle41.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGlobalTotals.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle41;
            this.dgvGlobalTotals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGlobalTotals.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnResource,
            this.columnOutput,
            this.columnInput});
            this.dgvGlobalTotals.Location = new System.Drawing.Point(521, 302);
            this.dgvGlobalTotals.MultiSelect = false;
            this.dgvGlobalTotals.Name = "dgvGlobalTotals";
            this.dgvGlobalTotals.ReadOnly = true;
            dataGridViewCellStyle42.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle42.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle42.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle42.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle42.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle42.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle42.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGlobalTotals.RowHeadersDefaultCellStyle = dataGridViewCellStyle42;
            this.dgvGlobalTotals.RowHeadersVisible = false;
            this.dgvGlobalTotals.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvGlobalTotals.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGlobalTotals.Size = new System.Drawing.Size(269, 296);
            this.dgvGlobalTotals.TabIndex = 16;
            // 
            // columnResource
            // 
            this.columnResource.HeaderText = "Resource";
            this.columnResource.Name = "columnResource";
            this.columnResource.ReadOnly = true;
            // 
            // columnOutput
            // 
            this.columnOutput.FillWeight = 45F;
            this.columnOutput.HeaderText = "Output";
            this.columnOutput.Name = "columnOutput";
            this.columnOutput.ReadOnly = true;
            // 
            // columnInput
            // 
            this.columnInput.FillWeight = 50F;
            this.columnInput.HeaderText = "Input";
            this.columnInput.Name = "columnInput";
            this.columnInput.ReadOnly = true;
            // 
            // buttonReadConf
            // 
            this.buttonReadConf.Location = new System.Drawing.Point(142, 35);
            this.buttonReadConf.Name = "buttonReadConf";
            this.buttonReadConf.Size = new System.Drawing.Size(75, 23);
            this.buttonReadConf.TabIndex = 0;
            this.buttonReadConf.Text = "read conf";
            this.buttonReadConf.UseVisualStyleBackColor = true;
            this.buttonReadConf.Visible = false;
            this.buttonReadConf.Click += new System.EventHandler(this.ButtonReadConf_Click);
            // 
            // buttonWriteConf
            // 
            this.buttonWriteConf.Location = new System.Drawing.Point(223, 35);
            this.buttonWriteConf.Name = "buttonWriteConf";
            this.buttonWriteConf.Size = new System.Drawing.Size(75, 23);
            this.buttonWriteConf.TabIndex = 17;
            this.buttonWriteConf.Text = "write conf";
            this.buttonWriteConf.UseVisualStyleBackColor = true;
            this.buttonWriteConf.Visible = false;
            this.buttonWriteConf.Click += new System.EventHandler(this.ButtonWriteConf_Click);
            // 
            // buttonReadTest
            // 
            this.buttonReadTest.Location = new System.Drawing.Point(304, 35);
            this.buttonReadTest.Name = "buttonReadTest";
            this.buttonReadTest.Size = new System.Drawing.Size(75, 23);
            this.buttonReadTest.TabIndex = 18;
            this.buttonReadTest.Text = "Read Test";
            this.buttonReadTest.UseVisualStyleBackColor = true;
            this.buttonReadTest.Visible = false;
            this.buttonReadTest.Click += new System.EventHandler(this.ButtonReadTest_Click);
            // 
            // buttonWriteTest
            // 
            this.buttonWriteTest.Location = new System.Drawing.Point(385, 35);
            this.buttonWriteTest.Name = "buttonWriteTest";
            this.buttonWriteTest.Size = new System.Drawing.Size(75, 23);
            this.buttonWriteTest.TabIndex = 19;
            this.buttonWriteTest.Text = "Write Test";
            this.buttonWriteTest.UseVisualStyleBackColor = true;
            this.buttonWriteTest.Visible = false;
            this.buttonWriteTest.Click += new System.EventHandler(this.ButtonWriteTest_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(466, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "Write New";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(547, 35);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 21;
            this.button2.Text = "Add New";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(628, 35);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 22;
            this.button3.Text = "Add2List";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 610);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonWriteTest);
            this.Controls.Add(this.buttonReadTest);
            this.Controls.Add(this.buttonWriteConf);
            this.Controls.Add(this.buttonReadConf);
            this.Controls.Add(this.dgvGlobalTotals);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.dgvUsage);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.groupBoxRecipe);
            this.Controls.Add(this.groupBoxQty);
            this.Controls.Add(this.groupBoxMachine);
            this.Controls.Add(this.panelMaximize);
            this.Controls.Add(this.panelClose);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelMinimize);
            this.Controls.Add(this.dgvMachines);
            this.Controls.Add(this.pictureBoxSatisfactoryIcon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Satisfactory Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMachines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSatisfactoryIcon)).EndInit();
            this.groupBoxMachine.ResumeLayout(false);
            this.groupBoxQty.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQty)).EndInit();
            this.groupBoxRecipe.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGlobalTotals)).EndInit();
            this.ResumeLayout(false);

		}

        #endregion



        private System.Windows.Forms.ComboBox comboBoxMachine;
		private System.Windows.Forms.DataGridView dgvMachines;
		private System.Windows.Forms.PictureBox pictureBoxSatisfactoryIcon;
		private System.Windows.Forms.Panel panelTop;
		private System.Windows.Forms.Panel panelMaximize;
		private System.Windows.Forms.Panel panelClose;
		private System.Windows.Forms.Panel panelMinimize;
		private System.Windows.Forms.GroupBox groupBoxMachine;
		private System.Windows.Forms.GroupBox groupBoxQty;
		private System.Windows.Forms.GroupBox groupBoxRecipe;
		private System.Windows.Forms.ComboBox comboBoxRecipe;
		private System.Windows.Forms.Button buttonAdd;
		private System.Windows.Forms.DataGridView dgvUsage;
		private System.Windows.Forms.Button buttonEdit;
		private System.Windows.Forms.DataGridView dgvGlobalTotals;
		private System.Windows.Forms.DataGridViewTextBoxColumn columnMachineUsage;
		private System.Windows.Forms.DataGridViewTextBoxColumn columnInputTotal;
		private System.Windows.Forms.NumericUpDown numericUpDownQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnResource;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnOutput;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnInput;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnMachinesMachine;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnMachinesQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnMachinesOutputResource;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnMachinesOutputTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnMachinesCurrentRecipe;
        private System.Windows.Forms.Button buttonReadConf;
        private System.Windows.Forms.Button buttonWriteConf;
        private System.Windows.Forms.Button buttonReadTest;
        private System.Windows.Forms.Button buttonWriteTest;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

