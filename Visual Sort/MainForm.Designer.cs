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
			this.comboBoxSortAlgorithm = new System.Windows.Forms.ComboBox();
			this.panelDraw = new System.Windows.Forms.PictureBox();
			this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
			this.labelRuntimeValue = new System.Windows.Forms.Label();
			this.labelRuntime = new System.Windows.Forms.Label();
			this.labelSwapValue = new System.Windows.Forms.Label();
			this.labelSwap = new System.Windows.Forms.Label();
			this.labelComparisonValue = new System.Windows.Forms.Label();
			this.labelComparison = new System.Windows.Forms.Label();
			this.comboBoxVisualizationScheme = new System.Windows.Forms.ComboBox();
			this.groupBoxVisualizationDepth = new System.Windows.Forms.GroupBox();
			this.radioBoxVisualizationDepthDetailed = new System.Windows.Forms.RadioButton();
			this.radioBoxVisualizationDepthSimple = new System.Windows.Forms.RadioButton();
			this.checkBoxDataProcessingSpeed = new System.Windows.Forms.CheckBox();
			this.checkBoxFinalEvent = new System.Windows.Forms.CheckBox();
			this.labelSortAlgorithm = new System.Windows.Forms.Label();
			this.labelVisualizationScheme = new System.Windows.Forms.Label();
			this.labelShuffleMode = new System.Windows.Forms.Label();
			this.comboBoxShuffleMode = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.panelDraw)).BeginInit();
			this.tableLayoutPanel.SuspendLayout();
			this.groupBoxVisualizationDepth.SuspendLayout();
			this.SuspendLayout();
			// 
			// buttonSort
			// 
			this.buttonSort.Location = new System.Drawing.Point(143, 195);
			this.buttonSort.Name = "buttonSort";
			this.buttonSort.Size = new System.Drawing.Size(125, 23);
			this.buttonSort.TabIndex = 10;
			this.buttonSort.Text = "Start";
			this.buttonSort.UseVisualStyleBackColor = true;
			this.buttonSort.Click += new System.EventHandler(this.ButtonSort_Click);
			// 
			// buttonShuffle
			// 
			this.buttonShuffle.Location = new System.Drawing.Point(12, 195);
			this.buttonShuffle.Name = "buttonShuffle";
			this.buttonShuffle.Size = new System.Drawing.Size(125, 23);
			this.buttonShuffle.TabIndex = 9;
			this.buttonShuffle.Text = "Shuffle";
			this.buttonShuffle.UseVisualStyleBackColor = true;
			this.buttonShuffle.Click += new System.EventHandler(this.ButtonShuffle_Click);
			// 
			// comboBoxSortAlgorithm
			// 
			this.comboBoxSortAlgorithm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxSortAlgorithm.FormattingEnabled = true;
			this.comboBoxSortAlgorithm.Items.AddRange(new object[] {
            "Bubble Sort"});
			this.comboBoxSortAlgorithm.Location = new System.Drawing.Point(121, 12);
			this.comboBoxSortAlgorithm.Name = "comboBoxSortAlgorithm";
			this.comboBoxSortAlgorithm.Size = new System.Drawing.Size(147, 21);
			this.comboBoxSortAlgorithm.TabIndex = 1;
			// 
			// panelDraw
			// 
			this.panelDraw.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panelDraw.Location = new System.Drawing.Point(12, 224);
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
			this.tableLayoutPanel.Location = new System.Drawing.Point(13, 487);
			this.tableLayoutPanel.Name = "tableLayoutPanel";
			this.tableLayoutPanel.RowCount = 3;
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel.Size = new System.Drawing.Size(255, 57);
			this.tableLayoutPanel.TabIndex = 11;
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
			// comboBoxVisualizationScheme
			// 
			this.comboBoxVisualizationScheme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxVisualizationScheme.FormattingEnabled = true;
			this.comboBoxVisualizationScheme.Items.AddRange(new object[] {
            "lines",
            "dotes"});
			this.comboBoxVisualizationScheme.Location = new System.Drawing.Point(121, 40);
			this.comboBoxVisualizationScheme.Name = "comboBoxVisualizationScheme";
			this.comboBoxVisualizationScheme.Size = new System.Drawing.Size(147, 21);
			this.comboBoxVisualizationScheme.TabIndex = 3;
			// 
			// groupBoxVisualizationDepth
			// 
			this.groupBoxVisualizationDepth.Controls.Add(this.radioBoxVisualizationDepthDetailed);
			this.groupBoxVisualizationDepth.Controls.Add(this.radioBoxVisualizationDepthSimple);
			this.groupBoxVisualizationDepth.Location = new System.Drawing.Point(12, 94);
			this.groupBoxVisualizationDepth.Name = "groupBoxVisualizationDepth";
			this.groupBoxVisualizationDepth.Size = new System.Drawing.Size(256, 48);
			this.groupBoxVisualizationDepth.TabIndex = 6;
			this.groupBoxVisualizationDepth.TabStop = false;
			this.groupBoxVisualizationDepth.Text = "Visualization depth";
			// 
			// radioBoxVisualizationDepthDetailed
			// 
			this.radioBoxVisualizationDepthDetailed.AutoSize = true;
			this.radioBoxVisualizationDepthDetailed.Location = new System.Drawing.Point(67, 20);
			this.radioBoxVisualizationDepthDetailed.Name = "radioBoxVisualizationDepthDetailed";
			this.radioBoxVisualizationDepthDetailed.Size = new System.Drawing.Size(101, 17);
			this.radioBoxVisualizationDepthDetailed.TabIndex = 1;
			this.radioBoxVisualizationDepthDetailed.Text = "detailed (slower)";
			this.radioBoxVisualizationDepthDetailed.UseVisualStyleBackColor = true;
			// 
			// radioBoxVisualizationDepthSimple
			// 
			this.radioBoxVisualizationDepthSimple.AutoSize = true;
			this.radioBoxVisualizationDepthSimple.Checked = true;
			this.radioBoxVisualizationDepthSimple.Location = new System.Drawing.Point(7, 20);
			this.radioBoxVisualizationDepthSimple.Name = "radioBoxVisualizationDepthSimple";
			this.radioBoxVisualizationDepthSimple.Size = new System.Drawing.Size(54, 17);
			this.radioBoxVisualizationDepthSimple.TabIndex = 0;
			this.radioBoxVisualizationDepthSimple.TabStop = true;
			this.radioBoxVisualizationDepthSimple.Text = "simple";
			this.radioBoxVisualizationDepthSimple.UseVisualStyleBackColor = true;
			// 
			// checkBoxDataProcessingSpeed
			// 
			this.checkBoxDataProcessingSpeed.AutoSize = true;
			this.checkBoxDataProcessingSpeed.Checked = true;
			this.checkBoxDataProcessingSpeed.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBoxDataProcessingSpeed.Location = new System.Drawing.Point(12, 149);
			this.checkBoxDataProcessingSpeed.Name = "checkBoxDataProcessingSpeed";
			this.checkBoxDataProcessingSpeed.Size = new System.Drawing.Size(163, 17);
			this.checkBoxDataProcessingSpeed.TabIndex = 7;
			this.checkBoxDataProcessingSpeed.Text = "Show data processing speed";
			this.checkBoxDataProcessingSpeed.UseVisualStyleBackColor = true;
			// 
			// checkBoxFinalEvent
			// 
			this.checkBoxFinalEvent.AutoSize = true;
			this.checkBoxFinalEvent.Checked = true;
			this.checkBoxFinalEvent.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBoxFinalEvent.Location = new System.Drawing.Point(12, 172);
			this.checkBoxFinalEvent.Name = "checkBoxFinalEvent";
			this.checkBoxFinalEvent.Size = new System.Drawing.Size(104, 17);
			this.checkBoxFinalEvent.TabIndex = 8;
			this.checkBoxFinalEvent.Text = "Apply final event";
			this.checkBoxFinalEvent.UseVisualStyleBackColor = true;
			// 
			// labelSortAlgorithm
			// 
			this.labelSortAlgorithm.AutoSize = true;
			this.labelSortAlgorithm.Location = new System.Drawing.Point(9, 15);
			this.labelSortAlgorithm.Name = "labelSortAlgorithm";
			this.labelSortAlgorithm.Size = new System.Drawing.Size(74, 13);
			this.labelSortAlgorithm.TabIndex = 0;
			this.labelSortAlgorithm.Text = "Sort algorithm:";
			// 
			// labelVisualizationScheme
			// 
			this.labelVisualizationScheme.AutoSize = true;
			this.labelVisualizationScheme.Location = new System.Drawing.Point(9, 43);
			this.labelVisualizationScheme.Name = "labelVisualizationScheme";
			this.labelVisualizationScheme.Size = new System.Drawing.Size(108, 13);
			this.labelVisualizationScheme.TabIndex = 2;
			this.labelVisualizationScheme.Text = "Visualization scheme:";
			// 
			// labelShuffleMode
			// 
			this.labelShuffleMode.AutoSize = true;
			this.labelShuffleMode.Location = new System.Drawing.Point(9, 70);
			this.labelShuffleMode.Name = "labelShuffleMode";
			this.labelShuffleMode.Size = new System.Drawing.Size(72, 13);
			this.labelShuffleMode.TabIndex = 4;
			this.labelShuffleMode.Text = "Shuffle mode:";
			// 
			// comboBoxShuffleMode
			// 
			this.comboBoxShuffleMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxShuffleMode.FormattingEnabled = true;
			this.comboBoxShuffleMode.Items.AddRange(new object[] {
            "random",
            "sorted forward",
            "sorted reverse"});
			this.comboBoxShuffleMode.Location = new System.Drawing.Point(121, 67);
			this.comboBoxShuffleMode.Name = "comboBoxShuffleMode";
			this.comboBoxShuffleMode.Size = new System.Drawing.Size(147, 21);
			this.comboBoxShuffleMode.TabIndex = 5;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(283, 551);
			this.Controls.Add(this.labelShuffleMode);
			this.Controls.Add(this.comboBoxShuffleMode);
			this.Controls.Add(this.labelVisualizationScheme);
			this.Controls.Add(this.labelSortAlgorithm);
			this.Controls.Add(this.checkBoxFinalEvent);
			this.Controls.Add(this.checkBoxDataProcessingSpeed);
			this.Controls.Add(this.groupBoxVisualizationDepth);
			this.Controls.Add(this.comboBoxVisualizationScheme);
			this.Controls.Add(this.tableLayoutPanel);
			this.Controls.Add(this.panelDraw);
			this.Controls.Add(this.comboBoxSortAlgorithm);
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
			this.groupBoxVisualizationDepth.ResumeLayout(false);
			this.groupBoxVisualizationDepth.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button buttonSort;
		private System.Windows.Forms.Button buttonShuffle;
		private System.Windows.Forms.ComboBox comboBoxSortAlgorithm;
		private System.Windows.Forms.PictureBox panelDraw;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
		private System.Windows.Forms.Label labelRuntimeValue;
		private System.Windows.Forms.Label labelRuntime;
		private System.Windows.Forms.Label labelSwapValue;
		private System.Windows.Forms.Label labelSwap;
		private System.Windows.Forms.Label labelComparisonValue;
		private System.Windows.Forms.Label labelComparison;
		private System.Windows.Forms.ComboBox comboBoxVisualizationScheme;
		private System.Windows.Forms.GroupBox groupBoxVisualizationDepth;
		private System.Windows.Forms.RadioButton radioBoxVisualizationDepthDetailed;
		private System.Windows.Forms.RadioButton radioBoxVisualizationDepthSimple;
		private System.Windows.Forms.CheckBox checkBoxDataProcessingSpeed;
		private System.Windows.Forms.CheckBox checkBoxFinalEvent;
		private System.Windows.Forms.Label labelSortAlgorithm;
		private System.Windows.Forms.Label labelVisualizationScheme;
		private System.Windows.Forms.Label labelShuffleMode;
		private System.Windows.Forms.ComboBox comboBoxShuffleMode;
	}
}

