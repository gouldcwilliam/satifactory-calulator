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
			this.dataGridViewMachines = new System.Windows.Forms.DataGridView();
			this.columnMachine = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.columnQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.columnOutputResource = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.columnOutputTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.panelTop = new System.Windows.Forms.Panel();
			this.panelMaximize = new System.Windows.Forms.Panel();
			this.panelClose = new System.Windows.Forms.Panel();
			this.panelMinimize = new System.Windows.Forms.Panel();
			this.pictureBoxSatisfactoryIcon = new System.Windows.Forms.PictureBox();
			this.groupBoxMachine = new System.Windows.Forms.GroupBox();
			this.groupBoxQty = new System.Windows.Forms.GroupBox();
			this.comboBoxQty = new System.Windows.Forms.ComboBox();
			this.groupBoxResource = new System.Windows.Forms.GroupBox();
			this.comboBoxResource = new System.Windows.Forms.ComboBox();
			this.buttonAdd = new System.Windows.Forms.Button();
			this.dataGridMachineInput = new System.Windows.Forms.DataGridView();
			this.columnMachineUsage = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.columnInputTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.buttonEdit = new System.Windows.Forms.Button();
			this.dataGridViewTotals = new System.Windows.Forms.DataGridView();
			this.columnResource = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.columnOutput = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.columnInput = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewMachines)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxSatisfactoryIcon)).BeginInit();
			this.groupBoxMachine.SuspendLayout();
			this.groupBoxQty.SuspendLayout();
			this.groupBoxResource.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridMachineInput)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewTotals)).BeginInit();
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
			// 
			// dataGridViewMachines
			// 
			this.dataGridViewMachines.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.dataGridViewMachines.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridViewMachines.BackgroundColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridViewMachines.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dataGridViewMachines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewMachines.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnMachine,
            this.columnQty,
            this.columnOutputResource,
            this.columnOutputTotal});
			this.dataGridViewMachines.Location = new System.Drawing.Point(12, 58);
			this.dataGridViewMachines.Name = "dataGridViewMachines";
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridViewMachines.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dataGridViewMachines.RowHeadersVisible = false;
			this.dataGridViewMachines.Size = new System.Drawing.Size(503, 540);
			this.dataGridViewMachines.TabIndex = 1;
			// 
			// columnMachine
			// 
			this.columnMachine.HeaderText = "Machine";
			this.columnMachine.Name = "columnMachine";
			// 
			// columnQty
			// 
			this.columnQty.FillWeight = 40F;
			this.columnQty.HeaderText = "Qty";
			this.columnQty.Name = "columnQty";
			// 
			// columnOutputResource
			// 
			this.columnOutputResource.HeaderText = "Output Resource";
			this.columnOutputResource.Name = "columnOutputResource";
			// 
			// columnOutputTotal
			// 
			this.columnOutputTotal.FillWeight = 40F;
			this.columnOutputTotal.HeaderText = "Total";
			this.columnOutputTotal.Name = "columnOutputTotal";
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
			this.groupBoxQty.Controls.Add(this.comboBoxQty);
			this.groupBoxQty.Location = new System.Drawing.Point(728, 58);
			this.groupBoxQty.Name = "groupBoxQty";
			this.groupBoxQty.Size = new System.Drawing.Size(62, 52);
			this.groupBoxQty.TabIndex = 10;
			this.groupBoxQty.TabStop = false;
			this.groupBoxQty.Text = "Qty";
			// 
			// comboBoxQty
			// 
			this.comboBoxQty.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.comboBoxQty.FormattingEnabled = true;
			this.comboBoxQty.Location = new System.Drawing.Point(6, 19);
			this.comboBoxQty.Name = "comboBoxQty";
			this.comboBoxQty.Size = new System.Drawing.Size(50, 21);
			this.comboBoxQty.TabIndex = 0;
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
			// dataGridMachineInput
			// 
			this.dataGridMachineInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridMachineInput.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridMachineInput.BackgroundColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridMachineInput.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.dataGridMachineInput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridMachineInput.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnMachineUsage,
            this.columnInputTotal});
			this.dataGridMachineInput.Location = new System.Drawing.Point(521, 174);
			this.dataGridMachineInput.Name = "dataGridMachineInput";
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridMachineInput.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
			this.dataGridMachineInput.RowHeadersVisible = false;
			this.dataGridMachineInput.Size = new System.Drawing.Size(269, 109);
			this.dataGridMachineInput.TabIndex = 14;
			// 
			// columnMachineUsage
			// 
			this.columnMachineUsage.HeaderText = "MachineUsage";
			this.columnMachineUsage.Name = "columnMachineUsage";
			// 
			// columnInputTotal
			// 
			this.columnInputTotal.FillWeight = 40F;
			this.columnInputTotal.HeaderText = "Total";
			this.columnInputTotal.Name = "columnInputTotal";
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
			// dataGridViewTotals
			// 
			this.dataGridViewTotals.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.dataGridViewTotals.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridViewTotals.BackgroundColor = System.Drawing.SystemColors.Control;
			this.dataGridViewTotals.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridViewTotals.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
			this.dataGridViewTotals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewTotals.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnResource,
            this.columnOutput,
            this.columnInput});
			this.dataGridViewTotals.Location = new System.Drawing.Point(521, 302);
			this.dataGridViewTotals.Name = "dataGridViewTotals";
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridViewTotals.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
			this.dataGridViewTotals.RowHeadersVisible = false;
			this.dataGridViewTotals.Size = new System.Drawing.Size(269, 296);
			this.dataGridViewTotals.TabIndex = 16;
			// 
			// columnResource
			// 
			this.columnResource.HeaderText = "Resource";
			this.columnResource.Name = "columnResource";
			// 
			// columnOutput
			// 
			this.columnOutput.FillWeight = 40F;
			this.columnOutput.HeaderText = "Output";
			this.columnOutput.Name = "columnOutput";
			// 
			// columnInput
			// 
			this.columnInput.FillWeight = 40F;
			this.columnInput.HeaderText = "Input";
			this.columnInput.Name = "columnInput";
			// 
			// FormMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(802, 610);
			this.Controls.Add(this.dataGridViewTotals);
			this.Controls.Add(this.buttonEdit);
			this.Controls.Add(this.dataGridMachineInput);
			this.Controls.Add(this.buttonAdd);
			this.Controls.Add(this.groupBoxResource);
			this.Controls.Add(this.groupBoxQty);
			this.Controls.Add(this.groupBoxMachine);
			this.Controls.Add(this.panelMaximize);
			this.Controls.Add(this.panelClose);
			this.Controls.Add(this.panelTop);
			this.Controls.Add(this.panelMinimize);
			this.Controls.Add(this.dataGridViewMachines);
			this.Controls.Add(this.pictureBoxSatisfactoryIcon);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FormMain";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.Text = "Satisfactory Calculator";
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewMachines)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxSatisfactoryIcon)).EndInit();
			this.groupBoxMachine.ResumeLayout(false);
			this.groupBoxQty.ResumeLayout(false);
			this.groupBoxResource.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridMachineInput)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewTotals)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ComboBox comboBoxMachine;
		private System.Windows.Forms.DataGridView dataGridViewMachines;
		private System.Windows.Forms.PictureBox pictureBoxSatisfactoryIcon;
		private System.Windows.Forms.Panel panelTop;
		private System.Windows.Forms.Panel panelMaximize;
		private System.Windows.Forms.Panel panelClose;
		private System.Windows.Forms.Panel panelMinimize;
		private System.Windows.Forms.GroupBox groupBoxMachine;
		private System.Windows.Forms.GroupBox groupBoxQty;
		private System.Windows.Forms.ComboBox comboBoxQty;
		private System.Windows.Forms.GroupBox groupBoxResource;
		private System.Windows.Forms.ComboBox comboBoxResource;
		private System.Windows.Forms.Button buttonAdd;
		private System.Windows.Forms.DataGridView dataGridMachineInput;
		private System.Windows.Forms.Button buttonEdit;
		private System.Windows.Forms.DataGridView dataGridViewTotals;
		private System.Windows.Forms.DataGridViewTextBoxColumn columnMachine;
		private System.Windows.Forms.DataGridViewTextBoxColumn columnQty;
		private System.Windows.Forms.DataGridViewTextBoxColumn columnOutputResource;
		private System.Windows.Forms.DataGridViewTextBoxColumn columnOutputTotal;
		private System.Windows.Forms.DataGridViewTextBoxColumn columnMachineUsage;
		private System.Windows.Forms.DataGridViewTextBoxColumn columnInputTotal;
		private System.Windows.Forms.DataGridViewTextBoxColumn columnResource;
		private System.Windows.Forms.DataGridViewTextBoxColumn columnOutput;
		private System.Windows.Forms.DataGridViewTextBoxColumn columnInput;
	}
}

