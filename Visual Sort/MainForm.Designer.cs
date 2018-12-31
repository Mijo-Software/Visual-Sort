namespace Visual_Sort
{
	partial class MainForm
	{
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Verwendete Ressourcen bereinigen.
		/// </summary>
		/// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Vom Windows Form-Designer generierter Code

		/// <summary>
		/// Erforderliche Methode für die Designerunterstützung.
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.buttonSort = new System.Windows.Forms.Button();
			this.buttonShuffle = new System.Windows.Forms.Button();
			this.comboBoxSortAlgorithms = new System.Windows.Forms.ComboBox();
			this.panelDraw = new System.Windows.Forms.PictureBox();
			this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
			this.labelRuntimeValue = new System.Windows.Forms.Label();
			this.labelRuntime = new System.Windows.Forms.Label();
			this.labelSwapValue = new System.Windows.Forms.Label();
			this.labelSwap = new System.Windows.Forms.Label();
			this.labelComparisonValue = new System.Windows.Forms.Label();
			this.labelComparison = new System.Windows.Forms.Label();
			this.comboBoxScheme = new System.Windows.Forms.ComboBox();
			this.groupBoxVisualisationDepth = new System.Windows.Forms.GroupBox();
			this.VisualisationDepthDetailed = new System.Windows.Forms.RadioButton();
			this.VisualisationDepthSimple = new System.Windows.Forms.RadioButton();
			this.checkBoxDataProcessingSpeed = new System.Windows.Forms.CheckBox();
			((System.ComponentModel.ISupportInitialize)(this.panelDraw)).BeginInit();
			this.tableLayoutPanel.SuspendLayout();
			this.groupBoxVisualisationDepth.SuspendLayout();
			this.SuspendLayout();
			// 
			// buttonSort
			// 
			this.buttonSort.Location = new System.Drawing.Point(143, 150);
			this.buttonSort.Name = "buttonSort";
			this.buttonSort.Size = new System.Drawing.Size(125, 23);
			this.buttonSort.TabIndex = 1;
			this.buttonSort.Text = "Start";
			this.buttonSort.UseVisualStyleBackColor = true;
			this.buttonSort.Click += new System.EventHandler(this.ButtonSort_Click);
			// 
			// buttonShuffle
			// 
			this.buttonShuffle.Location = new System.Drawing.Point(12, 150);
			this.buttonShuffle.Name = "buttonShuffle";
			this.buttonShuffle.Size = new System.Drawing.Size(125, 23);
			this.buttonShuffle.TabIndex = 2;
			this.buttonShuffle.Text = "Shuffle";
			this.buttonShuffle.UseVisualStyleBackColor = true;
			this.buttonShuffle.Click += new System.EventHandler(this.ButtonShuffle_Click);
			// 
			// comboBoxSortAlgorithms
			// 
			this.comboBoxSortAlgorithms.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxSortAlgorithms.FormattingEnabled = true;
			this.comboBoxSortAlgorithms.Items.AddRange(new object[] {
            "Bubble Sort"});
			this.comboBoxSortAlgorithms.Location = new System.Drawing.Point(12, 12);
			this.comboBoxSortAlgorithms.Name = "comboBoxSortAlgorithms";
			this.comboBoxSortAlgorithms.Size = new System.Drawing.Size(256, 21);
			this.comboBoxSortAlgorithms.TabIndex = 3;
			// 
			// panelDraw
			// 
			this.panelDraw.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panelDraw.Location = new System.Drawing.Point(12, 179);
			this.panelDraw.Name = "panelDraw";
			this.panelDraw.Size = new System.Drawing.Size(256, 256);
			this.panelDraw.TabIndex = 4;
			this.panelDraw.TabStop = false;
			// 
			// tableLayoutPanel
			// 
			this.tableLayoutPanel.ColumnCount = 2;
			this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
			this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
			this.tableLayoutPanel.Controls.Add(this.labelRuntimeValue, 1, 2);
			this.tableLayoutPanel.Controls.Add(this.labelRuntime, 0, 2);
			this.tableLayoutPanel.Controls.Add(this.labelSwapValue, 1, 1);
			this.tableLayoutPanel.Controls.Add(this.labelSwap, 0, 1);
			this.tableLayoutPanel.Controls.Add(this.labelComparisonValue, 1, 0);
			this.tableLayoutPanel.Controls.Add(this.labelComparison, 0, 0);
			this.tableLayoutPanel.Location = new System.Drawing.Point(13, 442);
			this.tableLayoutPanel.Name = "tableLayoutPanel";
			this.tableLayoutPanel.RowCount = 3;
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel.Size = new System.Drawing.Size(255, 57);
			this.tableLayoutPanel.TabIndex = 5;
			// 
			// labelRuntimeValue
			// 
			this.labelRuntimeValue.AutoSize = true;
			this.labelRuntimeValue.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelRuntimeValue.Location = new System.Drawing.Point(105, 38);
			this.labelRuntimeValue.Name = "labelRuntimeValue";
			this.labelRuntimeValue.Size = new System.Drawing.Size(147, 19);
			this.labelRuntimeValue.TabIndex = 5;
			this.labelRuntimeValue.Text = "0";
			this.labelRuntimeValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// labelRuntime
			// 
			this.labelRuntime.AutoSize = true;
			this.labelRuntime.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelRuntime.Location = new System.Drawing.Point(3, 38);
			this.labelRuntime.Name = "labelRuntime";
			this.labelRuntime.Size = new System.Drawing.Size(96, 19);
			this.labelRuntime.TabIndex = 4;
			this.labelRuntime.Text = "Time:";
			this.labelRuntime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// labelSwapValue
			// 
			this.labelSwapValue.AutoSize = true;
			this.labelSwapValue.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelSwapValue.Location = new System.Drawing.Point(105, 19);
			this.labelSwapValue.Name = "labelSwapValue";
			this.labelSwapValue.Size = new System.Drawing.Size(147, 19);
			this.labelSwapValue.TabIndex = 3;
			this.labelSwapValue.Text = "0";
			this.labelSwapValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// labelSwap
			// 
			this.labelSwap.AutoSize = true;
			this.labelSwap.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelSwap.Location = new System.Drawing.Point(3, 19);
			this.labelSwap.Name = "labelSwap";
			this.labelSwap.Size = new System.Drawing.Size(96, 19);
			this.labelSwap.TabIndex = 2;
			this.labelSwap.Text = "Swaps:";
			this.labelSwap.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// labelComparisonValue
			// 
			this.labelComparisonValue.AutoSize = true;
			this.labelComparisonValue.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelComparisonValue.Location = new System.Drawing.Point(105, 0);
			this.labelComparisonValue.Name = "labelComparisonValue";
			this.labelComparisonValue.Size = new System.Drawing.Size(147, 19);
			this.labelComparisonValue.TabIndex = 1;
			this.labelComparisonValue.Text = "0";
			this.labelComparisonValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// labelComparison
			// 
			this.labelComparison.AutoSize = true;
			this.labelComparison.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelComparison.Location = new System.Drawing.Point(3, 0);
			this.labelComparison.Name = "labelComparison";
			this.labelComparison.Size = new System.Drawing.Size(96, 19);
			this.labelComparison.TabIndex = 0;
			this.labelComparison.Text = "Comparisons:";
			this.labelComparison.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// comboBoxScheme
			// 
			this.comboBoxScheme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxScheme.FormattingEnabled = true;
			this.comboBoxScheme.Items.AddRange(new object[] {
            "lines",
            "dotes"});
			this.comboBoxScheme.Location = new System.Drawing.Point(12, 40);
			this.comboBoxScheme.Name = "comboBoxScheme";
			this.comboBoxScheme.Size = new System.Drawing.Size(256, 21);
			this.comboBoxScheme.TabIndex = 6;
			// 
			// groupBoxVisualisationDepth
			// 
			this.groupBoxVisualisationDepth.Controls.Add(this.VisualisationDepthDetailed);
			this.groupBoxVisualisationDepth.Controls.Add(this.VisualisationDepthSimple);
			this.groupBoxVisualisationDepth.Location = new System.Drawing.Point(13, 67);
			this.groupBoxVisualisationDepth.Name = "groupBoxVisualisationDepth";
			this.groupBoxVisualisationDepth.Size = new System.Drawing.Size(255, 48);
			this.groupBoxVisualisationDepth.TabIndex = 7;
			this.groupBoxVisualisationDepth.TabStop = false;
			this.groupBoxVisualisationDepth.Text = "Darstellungstiefe";
			// 
			// VisualisationDepthDetailed
			// 
			this.VisualisationDepthDetailed.AutoSize = true;
			this.VisualisationDepthDetailed.Location = new System.Drawing.Point(73, 20);
			this.VisualisationDepthDetailed.Name = "VisualisationDepthDetailed";
			this.VisualisationDepthDetailed.Size = new System.Drawing.Size(112, 17);
			this.VisualisationDepthDetailed.TabIndex = 8;
			this.VisualisationDepthDetailed.Text = "genau (langsamer)";
			this.VisualisationDepthDetailed.UseVisualStyleBackColor = true;
			// 
			// VisualisationDepthSimple
			// 
			this.VisualisationDepthSimple.AutoSize = true;
			this.VisualisationDepthSimple.Checked = true;
			this.VisualisationDepthSimple.Location = new System.Drawing.Point(7, 20);
			this.VisualisationDepthSimple.Name = "VisualisationDepthSimple";
			this.VisualisationDepthSimple.Size = new System.Drawing.Size(60, 17);
			this.VisualisationDepthSimple.TabIndex = 0;
			this.VisualisationDepthSimple.TabStop = true;
			this.VisualisationDepthSimple.Text = "einfach";
			this.VisualisationDepthSimple.UseVisualStyleBackColor = true;
			// 
			// checkBoxDataProcessingSpeed
			// 
			this.checkBoxDataProcessingSpeed.AutoSize = true;
			this.checkBoxDataProcessingSpeed.Checked = true;
			this.checkBoxDataProcessingSpeed.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBoxDataProcessingSpeed.Location = new System.Drawing.Point(12, 122);
			this.checkBoxDataProcessingSpeed.Name = "checkBoxDataProcessingSpeed";
			this.checkBoxDataProcessingSpeed.Size = new System.Drawing.Size(163, 17);
			this.checkBoxDataProcessingSpeed.TabIndex = 8;
			this.checkBoxDataProcessingSpeed.Text = "Show data processing speed";
			this.checkBoxDataProcessingSpeed.UseVisualStyleBackColor = true;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(283, 507);
			this.Controls.Add(this.checkBoxDataProcessingSpeed);
			this.Controls.Add(this.groupBoxVisualisationDepth);
			this.Controls.Add(this.comboBoxScheme);
			this.Controls.Add(this.tableLayoutPanel);
			this.Controls.Add(this.panelDraw);
			this.Controls.Add(this.comboBoxSortAlgorithms);
			this.Controls.Add(this.buttonShuffle);
			this.Controls.Add(this.buttonSort);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Visual Sort";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
			this.Load += new System.EventHandler(this.MainForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.panelDraw)).EndInit();
			this.tableLayoutPanel.ResumeLayout(false);
			this.tableLayoutPanel.PerformLayout();
			this.groupBoxVisualisationDepth.ResumeLayout(false);
			this.groupBoxVisualisationDepth.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button buttonSort;
		private System.Windows.Forms.Button buttonShuffle;
		private System.Windows.Forms.ComboBox comboBoxSortAlgorithms;
		private System.Windows.Forms.PictureBox panelDraw;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
		private System.Windows.Forms.Label labelRuntimeValue;
		private System.Windows.Forms.Label labelRuntime;
		private System.Windows.Forms.Label labelSwapValue;
		private System.Windows.Forms.Label labelSwap;
		private System.Windows.Forms.Label labelComparisonValue;
		private System.Windows.Forms.Label labelComparison;
		private System.Windows.Forms.ComboBox comboBoxScheme;
		private System.Windows.Forms.GroupBox groupBoxVisualisationDepth;
		private System.Windows.Forms.RadioButton VisualisationDepthDetailed;
		private System.Windows.Forms.RadioButton VisualisationDepthSimple;
		private System.Windows.Forms.CheckBox checkBoxDataProcessingSpeed;
	}
}

