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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
			this.comboBoxMachines = new System.Windows.Forms.ComboBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.Machine = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.OutputResource = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.OutputTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.InputResource = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.InputTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.panelTop = new System.Windows.Forms.Panel();
			this.panelMaximize = new System.Windows.Forms.Panel();
			this.panelClose = new System.Windows.Forms.Panel();
			this.panelMinimize = new System.Windows.Forms.Panel();
			this.pictureBoxSatisfactoryIcon = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxSatisfactoryIcon)).BeginInit();
			this.SuspendLayout();
			// 
			// comboBoxMachines
			// 
			this.comboBoxMachines.FormattingEnabled = true;
			this.comboBoxMachines.Location = new System.Drawing.Point(12, 58);
			this.comboBoxMachines.Name = "comboBoxMachines";
			this.comboBoxMachines.Size = new System.Drawing.Size(124, 21);
			this.comboBoxMachines.TabIndex = 0;
			// 
			// dataGridView1
			// 
			this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Machine,
            this.Qty,
            this.OutputResource,
            this.OutputTotal,
            this.InputResource,
            this.InputTotal});
			this.dataGridView1.Location = new System.Drawing.Point(12, 85);
			this.dataGridView1.Name = "dataGridView1";
			dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
			this.dataGridView1.RowHeadersVisible = false;
			this.dataGridView1.Size = new System.Drawing.Size(774, 335);
			this.dataGridView1.TabIndex = 1;
			// 
			// Machine
			// 
			this.Machine.HeaderText = "Machine";
			this.Machine.Name = "Machine";
			// 
			// Qty
			// 
			this.Qty.HeaderText = "Qty";
			this.Qty.Name = "Qty";
			// 
			// OutputResource
			// 
			this.OutputResource.HeaderText = "Output Resource";
			this.OutputResource.Name = "OutputResource";
			// 
			// OutputTotal
			// 
			this.OutputTotal.HeaderText = "Output Total";
			this.OutputTotal.Name = "OutputTotal";
			// 
			// InputResource
			// 
			this.InputResource.HeaderText = "Input Resource";
			this.InputResource.Name = "InputResource";
			// 
			// InputTotal
			// 
			this.InputTotal.HeaderText = "Input Total";
			this.InputTotal.Name = "InputTotal";
			// 
			// panelTop
			// 
			this.panelTop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panelTop.Location = new System.Drawing.Point(136, 0);
			this.panelTop.Margin = new System.Windows.Forms.Padding(0);
			this.panelTop.Name = "panelTop";
			this.panelTop.Size = new System.Drawing.Size(518, 32);
			this.panelTop.TabIndex = 4;
			this.panelTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseDown);
			// 
			// panelMaximize
			// 
			this.panelMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.panelMaximize.BackgroundImage = global::satisfactory_calculator.Properties.Resources.maximize_16x16;
			this.panelMaximize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.panelMaximize.Location = new System.Drawing.Point(702, 0);
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
			this.panelClose.Location = new System.Drawing.Point(750, 0);
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
			this.panelMinimize.Location = new System.Drawing.Point(654, 0);
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
			// FormMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(798, 432);
			this.Controls.Add(this.panelMaximize);
			this.Controls.Add(this.panelClose);
			this.Controls.Add(this.panelTop);
			this.Controls.Add(this.panelMinimize);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.pictureBoxSatisfactoryIcon);
			this.Controls.Add(this.comboBoxMachines);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FormMain";
			this.Text = "Satisfactory Calculator";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxSatisfactoryIcon)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ComboBox comboBoxMachines;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Machine;
		private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
		private System.Windows.Forms.DataGridViewTextBoxColumn OutputResource;
		private System.Windows.Forms.DataGridViewTextBoxColumn OutputTotal;
		private System.Windows.Forms.DataGridViewTextBoxColumn InputResource;
		private System.Windows.Forms.DataGridViewTextBoxColumn InputTotal;
		private System.Windows.Forms.PictureBox pictureBoxSatisfactoryIcon;
		private System.Windows.Forms.Panel panelTop;
		private System.Windows.Forms.Panel panelMaximize;
		private System.Windows.Forms.Panel panelClose;
		private System.Windows.Forms.Panel panelMinimize;
	}
}

