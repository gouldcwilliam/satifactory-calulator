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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.comboBoxMachine = new System.Windows.Forms.ComboBox();
            this.dgvMachines = new System.Windows.Forms.DataGridView();
            this.columnMachinesIndex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnMachinesMachine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnMachinesQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnMachinesOutputResource = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnMachinesOutputTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelTop = new System.Windows.Forms.Panel();
            this.panelMaximize = new System.Windows.Forms.Panel();
            this.panelClose = new System.Windows.Forms.Panel();
            this.panelMinimize = new System.Windows.Forms.Panel();
            this.pictureBoxSatisfactoryIcon = new System.Windows.Forms.PictureBox();
            this.groupBoxMachine = new System.Windows.Forms.GroupBox();
            this.groupBoxQty = new System.Windows.Forms.GroupBox();
            this.numericUpDownQty = new System.Windows.Forms.NumericUpDown();
            this.groupBoxResource = new System.Windows.Forms.GroupBox();
            this.comboBoxResource = new System.Windows.Forms.ComboBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.dgvUsage = new System.Windows.Forms.DataGridView();
            this.columnMachineUsage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnInputTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.dgvGlobalTotals = new System.Windows.Forms.DataGridView();
            this.columnResource = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnOutput = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnInput = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMachines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSatisfactoryIcon)).BeginInit();
            this.groupBoxMachine.SuspendLayout();
            this.groupBoxQty.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQty)).BeginInit();
            this.groupBoxResource.SuspendLayout();
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMachines.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMachines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMachines.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnMachinesIndex,
            this.columnMachinesMachine,
            this.columnMachinesQty,
            this.columnMachinesOutputResource,
            this.columnMachinesOutputTotal});
            this.dgvMachines.Location = new System.Drawing.Point(12, 58);
            this.dgvMachines.MultiSelect = false;
            this.dgvMachines.Name = "dgvMachines";
            this.dgvMachines.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMachines.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMachines.RowHeadersVisible = false;
            this.dgvMachines.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMachines.Size = new System.Drawing.Size(503, 540);
            this.dgvMachines.TabIndex = 1;
            this.dgvMachines.SelectionChanged += new System.EventHandler(this.dataGridViewMachines_SelectionChanged);
            // 
            // columnMachinesIndex
            // 
            this.columnMachinesIndex.HeaderText = "Index";
            this.columnMachinesIndex.Name = "columnMachinesIndex";
            this.columnMachinesIndex.ReadOnly = true;
            this.columnMachinesIndex.Visible = false;
            // 
            // columnMachinesMachine
            // 
            this.columnMachinesMachine.HeaderText = "Machine";
            this.columnMachinesMachine.Name = "columnMachinesMachine";
            this.columnMachinesMachine.ReadOnly = true;
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
            // groupBoxResource
            // 
            this.groupBoxResource.Controls.Add(this.comboBoxResource);
            this.groupBoxResource.Location = new System.Drawing.Point(521, 116);
            this.groupBoxResource.Name = "groupBoxResource";
            this.groupBoxResource.Size = new System.Drawing.Size(165, 52);
            this.groupBoxResource.TabIndex = 11;
            this.groupBoxResource.TabStop = false;
            this.groupBoxResource.Text = "Resource";
            // 
            // comboBoxResource
            // 
            this.comboBoxResource.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxResource.FormattingEnabled = true;
            this.comboBoxResource.Location = new System.Drawing.Point(6, 19);
            this.comboBoxResource.Name = "comboBoxResource";
            this.comboBoxResource.Size = new System.Drawing.Size(153, 21);
            this.comboBoxResource.TabIndex = 0;
            this.comboBoxResource.TextChanged += new System.EventHandler(this.comboBoxResource_TextChanged);
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsage.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvUsage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsage.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnMachineUsage,
            this.columnInputTotal});
            this.dgvUsage.Location = new System.Drawing.Point(521, 187);
            this.dgvUsage.MultiSelect = false;
            this.dgvUsage.Name = "dgvUsage";
            this.dgvUsage.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsage.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvUsage.RowHeadersVisible = false;
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
            this.dgvGlobalTotals.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvGlobalTotals.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGlobalTotals.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvGlobalTotals.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGlobalTotals.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvGlobalTotals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGlobalTotals.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnResource,
            this.columnOutput,
            this.columnInput});
            this.dgvGlobalTotals.Location = new System.Drawing.Point(521, 302);
            this.dgvGlobalTotals.MultiSelect = false;
            this.dgvGlobalTotals.Name = "dgvGlobalTotals";
            this.dgvGlobalTotals.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGlobalTotals.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvGlobalTotals.RowHeadersVisible = false;
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
            this.columnOutput.FillWeight = 40F;
            this.columnOutput.HeaderText = "Output";
            this.columnOutput.Name = "columnOutput";
            this.columnOutput.ReadOnly = true;
            // 
            // columnInput
            // 
            this.columnInput.FillWeight = 40F;
            this.columnInput.HeaderText = "Input";
            this.columnInput.Name = "columnInput";
            this.columnInput.ReadOnly = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 610);
            this.Controls.Add(this.dgvGlobalTotals);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.dgvUsage);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.groupBoxResource);
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
            this.groupBoxResource.ResumeLayout(false);
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
		private System.Windows.Forms.GroupBox groupBoxResource;
		private System.Windows.Forms.ComboBox comboBoxResource;
		private System.Windows.Forms.Button buttonAdd;
		private System.Windows.Forms.DataGridView dgvUsage;
		private System.Windows.Forms.Button buttonEdit;
		private System.Windows.Forms.DataGridView dgvGlobalTotals;
		private System.Windows.Forms.DataGridViewTextBoxColumn columnMachineUsage;
		private System.Windows.Forms.DataGridViewTextBoxColumn columnInputTotal;
		private System.Windows.Forms.DataGridViewTextBoxColumn columnResource;
		private System.Windows.Forms.DataGridViewTextBoxColumn columnOutput;
		private System.Windows.Forms.DataGridViewTextBoxColumn columnInput;
		private System.Windows.Forms.NumericUpDown numericUpDownQty;
		private System.Windows.Forms.DataGridViewTextBoxColumn columnMachinesIndex;
		private System.Windows.Forms.DataGridViewTextBoxColumn columnMachinesMachine;
		private System.Windows.Forms.DataGridViewTextBoxColumn columnMachinesQty;
		private System.Windows.Forms.DataGridViewTextBoxColumn columnMachinesOutputResource;
		private System.Windows.Forms.DataGridViewTextBoxColumn columnMachinesOutputTotal;
    }
}

