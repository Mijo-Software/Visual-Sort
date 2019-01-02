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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.buttonSort = new System.Windows.Forms.Button();
			this.buttonShuffle = new System.Windows.Forms.Button();
			this.comboBoxSortingAlgorithm = new System.Windows.Forms.ComboBox();
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
			this.radioBoxVisualizationDepthNone = new System.Windows.Forms.RadioButton();
			this.radioBoxVisualizationDepthDetailed = new System.Windows.Forms.RadioButton();
			this.radioBoxVisualizationDepthSimple = new System.Windows.Forms.RadioButton();
			this.checkBoxDataProcessingSpeed = new System.Windows.Forms.CheckBox();
			this.checkBoxFinalEvent = new System.Windows.Forms.CheckBox();
			this.labelSortingAlgorithm = new System.Windows.Forms.Label();
			this.labelVisualizationScheme = new System.Windows.Forms.Label();
			this.labelShuffleMode = new System.Windows.Forms.Label();
			this.comboBoxShuffleMode = new System.Windows.Forms.ComboBox();
			this.comboBoxDrawMode = new System.Windows.Forms.ComboBox();
			this.labelDrawMode = new System.Windows.Forms.Label();
			this.toolTip = new System.Windows.Forms.ToolTip(this.components);
			this.statusStrip = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
			((System.ComponentModel.ISupportInitialize)(this.panelDraw)).BeginInit();
			this.tableLayoutPanel.SuspendLayout();
			this.groupBoxVisualizationDepth.SuspendLayout();
			this.statusStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// buttonSort
			// 
			this.buttonSort.AccessibleDescription = "Start the sorting";
			this.buttonSort.AccessibleName = "Start";
			this.buttonSort.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.buttonSort.Location = new System.Drawing.Point(143, 240);
			this.buttonSort.Name = "buttonSort";
			this.buttonSort.Size = new System.Drawing.Size(125, 23);
			this.buttonSort.TabIndex = 12;
			this.buttonSort.Text = "S&tart";
			this.toolTip.SetToolTip(this.buttonSort, "Start");
			this.buttonSort.UseVisualStyleBackColor = true;
			this.buttonSort.Click += new System.EventHandler(this.ButtonSort_Click);
			this.buttonSort.Enter += new System.EventHandler(this.SetStatusbar);
			this.buttonSort.Leave += new System.EventHandler(this.ClearStatusbar);
			this.buttonSort.MouseEnter += new System.EventHandler(this.SetStatusbar);
			this.buttonSort.MouseLeave += new System.EventHandler(this.ClearStatusbar);
			// 
			// buttonShuffle
			// 
			this.buttonShuffle.AccessibleDescription = "Shuffle the field";
			this.buttonShuffle.AccessibleName = "Shuffle";
			this.buttonShuffle.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.buttonShuffle.Location = new System.Drawing.Point(12, 240);
			this.buttonShuffle.Name = "buttonShuffle";
			this.buttonShuffle.Size = new System.Drawing.Size(125, 23);
			this.buttonShuffle.TabIndex = 11;
			this.buttonShuffle.Text = "S&huffle";
			this.toolTip.SetToolTip(this.buttonShuffle, "Shuffle");
			this.buttonShuffle.UseVisualStyleBackColor = true;
			this.buttonShuffle.Click += new System.EventHandler(this.ButtonShuffle_Click);
			this.buttonShuffle.Enter += new System.EventHandler(this.SetStatusbar);
			this.buttonShuffle.Leave += new System.EventHandler(this.ClearStatusbar);
			this.buttonShuffle.MouseEnter += new System.EventHandler(this.SetStatusbar);
			this.buttonShuffle.MouseLeave += new System.EventHandler(this.ClearStatusbar);
			// 
			// comboBoxSortingAlgorithm
			// 
			this.comboBoxSortingAlgorithm.AccessibleDescription = "Click to show the sorting algorithms";
			this.comboBoxSortingAlgorithm.AccessibleName = "Sorting algorithm";
			this.comboBoxSortingAlgorithm.AccessibleRole = System.Windows.Forms.AccessibleRole.ComboBox;
			this.comboBoxSortingAlgorithm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxSortingAlgorithm.FormattingEnabled = true;
			this.comboBoxSortingAlgorithm.Location = new System.Drawing.Point(12, 31);
			this.comboBoxSortingAlgorithm.Name = "comboBoxSortingAlgorithm";
			this.comboBoxSortingAlgorithm.Size = new System.Drawing.Size(256, 21);
			this.comboBoxSortingAlgorithm.TabIndex = 1;
			this.toolTip.SetToolTip(this.comboBoxSortingAlgorithm, "Sorting algorithm");
			this.comboBoxSortingAlgorithm.Enter += new System.EventHandler(this.SetStatusbar);
			this.comboBoxSortingAlgorithm.Leave += new System.EventHandler(this.ClearStatusbar);
			this.comboBoxSortingAlgorithm.MouseEnter += new System.EventHandler(this.SetStatusbar);
			this.comboBoxSortingAlgorithm.MouseLeave += new System.EventHandler(this.ClearStatusbar);
			// 
			// panelDraw
			// 
			this.panelDraw.AccessibleDescription = "Show the canvas of the field";
			this.panelDraw.AccessibleName = "Canvas";
			this.panelDraw.AccessibleRole = System.Windows.Forms.AccessibleRole.Graphic;
			this.panelDraw.BackColor = System.Drawing.Color.White;
			this.panelDraw.Location = new System.Drawing.Point(274, 12);
			this.panelDraw.Name = "panelDraw";
			this.panelDraw.Size = new System.Drawing.Size(256, 256);
			this.panelDraw.TabIndex = 4;
			this.panelDraw.TabStop = false;
			this.toolTip.SetToolTip(this.panelDraw, "Canvas");
			this.panelDraw.MouseEnter += new System.EventHandler(this.SetStatusbar);
			this.panelDraw.MouseLeave += new System.EventHandler(this.ClearStatusbar);
			// 
			// tableLayoutPanel
			// 
			this.tableLayoutPanel.AccessibleDescription = "Group the statistics";
			this.tableLayoutPanel.AccessibleName = "Statistic group";
			this.tableLayoutPanel.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
			this.tableLayoutPanel.ColumnCount = 2;
			this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
			this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
			this.tableLayoutPanel.Controls.Add(this.labelRuntimeValue, 1, 2);
			this.tableLayoutPanel.Controls.Add(this.labelRuntime, 0, 2);
			this.tableLayoutPanel.Controls.Add(this.labelSwapValue, 1, 1);
			this.tableLayoutPanel.Controls.Add(this.labelSwap, 0, 1);
			this.tableLayoutPanel.Controls.Add(this.labelComparisonValue, 1, 0);
			this.tableLayoutPanel.Controls.Add(this.labelComparison, 0, 0);
			this.tableLayoutPanel.Location = new System.Drawing.Point(275, 275);
			this.tableLayoutPanel.Name = "tableLayoutPanel";
			this.tableLayoutPanel.RowCount = 3;
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel.Size = new System.Drawing.Size(255, 57);
			this.tableLayoutPanel.TabIndex = 13;
			// 
			// labelRuntimeValue
			// 
			this.labelRuntimeValue.AccessibleDescription = "Show the value of the time";
			this.labelRuntimeValue.AccessibleName = "Time";
			this.labelRuntimeValue.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelRuntimeValue.AutoSize = true;
			this.labelRuntimeValue.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelRuntimeValue.Location = new System.Drawing.Point(105, 38);
			this.labelRuntimeValue.Name = "labelRuntimeValue";
			this.labelRuntimeValue.Size = new System.Drawing.Size(147, 19);
			this.labelRuntimeValue.TabIndex = 5;
			this.labelRuntimeValue.Text = "0";
			this.labelRuntimeValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.toolTip.SetToolTip(this.labelRuntimeValue, "Time");
			this.labelRuntimeValue.Enter += new System.EventHandler(this.SetStatusbar);
			this.labelRuntimeValue.Leave += new System.EventHandler(this.ClearStatusbar);
			this.labelRuntimeValue.MouseEnter += new System.EventHandler(this.SetStatusbar);
			this.labelRuntimeValue.MouseLeave += new System.EventHandler(this.ClearStatusbar);
			// 
			// labelRuntime
			// 
			this.labelRuntime.AccessibleDescription = "Show the time";
			this.labelRuntime.AccessibleName = "Time";
			this.labelRuntime.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelRuntime.AutoSize = true;
			this.labelRuntime.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelRuntime.Location = new System.Drawing.Point(3, 38);
			this.labelRuntime.Name = "labelRuntime";
			this.labelRuntime.Size = new System.Drawing.Size(96, 19);
			this.labelRuntime.TabIndex = 4;
			this.labelRuntime.Text = "Time in hms:";
			this.labelRuntime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.labelRuntime.Enter += new System.EventHandler(this.SetStatusbar);
			this.labelRuntime.Leave += new System.EventHandler(this.ClearStatusbar);
			this.labelRuntime.MouseEnter += new System.EventHandler(this.SetStatusbar);
			this.labelRuntime.MouseLeave += new System.EventHandler(this.ClearStatusbar);
			// 
			// labelSwapValue
			// 
			this.labelSwapValue.AccessibleDescription = "Show the value of the swaps";
			this.labelSwapValue.AccessibleName = "Swaps";
			this.labelSwapValue.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelSwapValue.AutoSize = true;
			this.labelSwapValue.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelSwapValue.Location = new System.Drawing.Point(105, 19);
			this.labelSwapValue.Name = "labelSwapValue";
			this.labelSwapValue.Size = new System.Drawing.Size(147, 19);
			this.labelSwapValue.TabIndex = 3;
			this.labelSwapValue.Text = "0";
			this.labelSwapValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.toolTip.SetToolTip(this.labelSwapValue, "Swaps");
			this.labelSwapValue.Enter += new System.EventHandler(this.SetStatusbar);
			this.labelSwapValue.Leave += new System.EventHandler(this.ClearStatusbar);
			this.labelSwapValue.MouseEnter += new System.EventHandler(this.SetStatusbar);
			this.labelSwapValue.MouseLeave += new System.EventHandler(this.ClearStatusbar);
			// 
			// labelSwap
			// 
			this.labelSwap.AccessibleDescription = "Show the swaps";
			this.labelSwap.AccessibleName = "Swaps";
			this.labelSwap.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelSwap.AutoSize = true;
			this.labelSwap.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelSwap.Location = new System.Drawing.Point(3, 19);
			this.labelSwap.Name = "labelSwap";
			this.labelSwap.Size = new System.Drawing.Size(96, 19);
			this.labelSwap.TabIndex = 2;
			this.labelSwap.Text = "Swaps:";
			this.labelSwap.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.labelSwap.Enter += new System.EventHandler(this.SetStatusbar);
			this.labelSwap.Leave += new System.EventHandler(this.ClearStatusbar);
			this.labelSwap.MouseEnter += new System.EventHandler(this.SetStatusbar);
			this.labelSwap.MouseLeave += new System.EventHandler(this.ClearStatusbar);
			// 
			// labelComparisonValue
			// 
			this.labelComparisonValue.AccessibleDescription = "Show the value of the comparisons";
			this.labelComparisonValue.AccessibleName = "Comparisons";
			this.labelComparisonValue.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelComparisonValue.AutoSize = true;
			this.labelComparisonValue.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelComparisonValue.Location = new System.Drawing.Point(105, 0);
			this.labelComparisonValue.Name = "labelComparisonValue";
			this.labelComparisonValue.Size = new System.Drawing.Size(147, 19);
			this.labelComparisonValue.TabIndex = 1;
			this.labelComparisonValue.Text = "0";
			this.labelComparisonValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.toolTip.SetToolTip(this.labelComparisonValue, "Comparisons");
			this.labelComparisonValue.Enter += new System.EventHandler(this.SetStatusbar);
			this.labelComparisonValue.Leave += new System.EventHandler(this.ClearStatusbar);
			this.labelComparisonValue.MouseEnter += new System.EventHandler(this.SetStatusbar);
			this.labelComparisonValue.MouseLeave += new System.EventHandler(this.ClearStatusbar);
			// 
			// labelComparison
			// 
			this.labelComparison.AccessibleDescription = "Show the comparisons";
			this.labelComparison.AccessibleName = "Comparisons";
			this.labelComparison.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelComparison.AutoSize = true;
			this.labelComparison.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelComparison.Location = new System.Drawing.Point(3, 0);
			this.labelComparison.Name = "labelComparison";
			this.labelComparison.Size = new System.Drawing.Size(96, 19);
			this.labelComparison.TabIndex = 0;
			this.labelComparison.Text = "Comparisons:";
			this.labelComparison.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.labelComparison.Enter += new System.EventHandler(this.SetStatusbar);
			this.labelComparison.Leave += new System.EventHandler(this.ClearStatusbar);
			this.labelComparison.MouseEnter += new System.EventHandler(this.SetStatusbar);
			this.labelComparison.MouseLeave += new System.EventHandler(this.ClearStatusbar);
			// 
			// comboBoxVisualizationScheme
			// 
			this.comboBoxVisualizationScheme.AccessibleDescription = "Click to show the visualization scheme";
			this.comboBoxVisualizationScheme.AccessibleName = "Visualization scheme";
			this.comboBoxVisualizationScheme.AccessibleRole = System.Windows.Forms.AccessibleRole.ComboBox;
			this.comboBoxVisualizationScheme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxVisualizationScheme.FormattingEnabled = true;
			this.comboBoxVisualizationScheme.Location = new System.Drawing.Point(121, 58);
			this.comboBoxVisualizationScheme.Name = "comboBoxVisualizationScheme";
			this.comboBoxVisualizationScheme.Size = new System.Drawing.Size(147, 21);
			this.comboBoxVisualizationScheme.TabIndex = 3;
			this.toolTip.SetToolTip(this.comboBoxVisualizationScheme, "Visualization scheme");
			this.comboBoxVisualizationScheme.Enter += new System.EventHandler(this.SetStatusbar);
			this.comboBoxVisualizationScheme.Leave += new System.EventHandler(this.ClearStatusbar);
			this.comboBoxVisualizationScheme.MouseEnter += new System.EventHandler(this.SetStatusbar);
			this.comboBoxVisualizationScheme.MouseLeave += new System.EventHandler(this.ClearStatusbar);
			// 
			// groupBoxVisualizationDepth
			// 
			this.groupBoxVisualizationDepth.AccessibleDescription = "Group the visualization depth";
			this.groupBoxVisualizationDepth.AccessibleName = "Visualization depth";
			this.groupBoxVisualizationDepth.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
			this.groupBoxVisualizationDepth.Controls.Add(this.radioBoxVisualizationDepthNone);
			this.groupBoxVisualizationDepth.Controls.Add(this.radioBoxVisualizationDepthDetailed);
			this.groupBoxVisualizationDepth.Controls.Add(this.radioBoxVisualizationDepthSimple);
			this.groupBoxVisualizationDepth.Location = new System.Drawing.Point(12, 139);
			this.groupBoxVisualizationDepth.Name = "groupBoxVisualizationDepth";
			this.groupBoxVisualizationDepth.Size = new System.Drawing.Size(256, 48);
			this.groupBoxVisualizationDepth.TabIndex = 8;
			this.groupBoxVisualizationDepth.TabStop = false;
			this.groupBoxVisualizationDepth.Text = "Visualization depth";
			// 
			// radioBoxVisualizationDepthNone
			// 
			this.radioBoxVisualizationDepthNone.AccessibleDescription = "Click to apply no visualization depth";
			this.radioBoxVisualizationDepthNone.AccessibleName = "No visualization depth";
			this.radioBoxVisualizationDepthNone.AccessibleRole = System.Windows.Forms.AccessibleRole.RadioButton;
			this.radioBoxVisualizationDepthNone.AutoSize = true;
			this.radioBoxVisualizationDepthNone.Location = new System.Drawing.Point(7, 20);
			this.radioBoxVisualizationDepthNone.Name = "radioBoxVisualizationDepthNone";
			this.radioBoxVisualizationDepthNone.Size = new System.Drawing.Size(64, 17);
			this.radioBoxVisualizationDepthNone.TabIndex = 0;
			this.radioBoxVisualizationDepthNone.Text = "(&1) none";
			this.toolTip.SetToolTip(this.radioBoxVisualizationDepthNone, "none visualization depth");
			this.radioBoxVisualizationDepthNone.UseVisualStyleBackColor = true;
			this.radioBoxVisualizationDepthNone.Enter += new System.EventHandler(this.SetStatusbar);
			this.radioBoxVisualizationDepthNone.Leave += new System.EventHandler(this.ClearStatusbar);
			this.radioBoxVisualizationDepthNone.MouseEnter += new System.EventHandler(this.SetStatusbar);
			this.radioBoxVisualizationDepthNone.MouseLeave += new System.EventHandler(this.ClearStatusbar);
			// 
			// radioBoxVisualizationDepthDetailed
			// 
			this.radioBoxVisualizationDepthDetailed.AccessibleDescription = "Click to apply detailed visualization depth";
			this.radioBoxVisualizationDepthDetailed.AccessibleName = "Detailed visualization depth";
			this.radioBoxVisualizationDepthDetailed.AccessibleRole = System.Windows.Forms.AccessibleRole.RadioButton;
			this.radioBoxVisualizationDepthDetailed.AutoSize = true;
			this.radioBoxVisualizationDepthDetailed.Location = new System.Drawing.Point(146, 20);
			this.radioBoxVisualizationDepthDetailed.Name = "radioBoxVisualizationDepthDetailed";
			this.radioBoxVisualizationDepthDetailed.Size = new System.Drawing.Size(77, 17);
			this.radioBoxVisualizationDepthDetailed.TabIndex = 2;
			this.radioBoxVisualizationDepthDetailed.Text = "(&3) detailed";
			this.toolTip.SetToolTip(this.radioBoxVisualizationDepthDetailed, "detailed visualization depth");
			this.radioBoxVisualizationDepthDetailed.UseVisualStyleBackColor = true;
			this.radioBoxVisualizationDepthDetailed.Enter += new System.EventHandler(this.SetStatusbar);
			this.radioBoxVisualizationDepthDetailed.Leave += new System.EventHandler(this.ClearStatusbar);
			this.radioBoxVisualizationDepthDetailed.MouseEnter += new System.EventHandler(this.SetStatusbar);
			this.radioBoxVisualizationDepthDetailed.MouseLeave += new System.EventHandler(this.ClearStatusbar);
			// 
			// radioBoxVisualizationDepthSimple
			// 
			this.radioBoxVisualizationDepthSimple.AccessibleDescription = "Click to apply simple visualization depth";
			this.radioBoxVisualizationDepthSimple.AccessibleName = "Simple visualization depth";
			this.radioBoxVisualizationDepthSimple.AccessibleRole = System.Windows.Forms.AccessibleRole.RadioButton;
			this.radioBoxVisualizationDepthSimple.AutoSize = true;
			this.radioBoxVisualizationDepthSimple.Checked = true;
			this.radioBoxVisualizationDepthSimple.Location = new System.Drawing.Point(71, 20);
			this.radioBoxVisualizationDepthSimple.Name = "radioBoxVisualizationDepthSimple";
			this.radioBoxVisualizationDepthSimple.Size = new System.Drawing.Size(69, 17);
			this.radioBoxVisualizationDepthSimple.TabIndex = 1;
			this.radioBoxVisualizationDepthSimple.TabStop = true;
			this.radioBoxVisualizationDepthSimple.Text = "(&2) simple";
			this.toolTip.SetToolTip(this.radioBoxVisualizationDepthSimple, "simple visualization depth");
			this.radioBoxVisualizationDepthSimple.UseVisualStyleBackColor = true;
			this.radioBoxVisualizationDepthSimple.Enter += new System.EventHandler(this.SetStatusbar);
			this.radioBoxVisualizationDepthSimple.Leave += new System.EventHandler(this.ClearStatusbar);
			this.radioBoxVisualizationDepthSimple.MouseEnter += new System.EventHandler(this.SetStatusbar);
			this.radioBoxVisualizationDepthSimple.MouseLeave += new System.EventHandler(this.ClearStatusbar);
			// 
			// checkBoxDataProcessingSpeed
			// 
			this.checkBoxDataProcessingSpeed.AccessibleDescription = "Click to show data processing speed";
			this.checkBoxDataProcessingSpeed.AccessibleName = "Show data processing speed";
			this.checkBoxDataProcessingSpeed.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
			this.checkBoxDataProcessingSpeed.AutoSize = true;
			this.checkBoxDataProcessingSpeed.Checked = true;
			this.checkBoxDataProcessingSpeed.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBoxDataProcessingSpeed.Location = new System.Drawing.Point(12, 194);
			this.checkBoxDataProcessingSpeed.Name = "checkBoxDataProcessingSpeed";
			this.checkBoxDataProcessingSpeed.Size = new System.Drawing.Size(163, 17);
			this.checkBoxDataProcessingSpeed.TabIndex = 9;
			this.checkBoxDataProcessingSpeed.Text = "Show data &processing speed";
			this.toolTip.SetToolTip(this.checkBoxDataProcessingSpeed, "Show data processing speed");
			this.checkBoxDataProcessingSpeed.UseVisualStyleBackColor = true;
			this.checkBoxDataProcessingSpeed.Enter += new System.EventHandler(this.SetStatusbar);
			this.checkBoxDataProcessingSpeed.Leave += new System.EventHandler(this.ClearStatusbar);
			this.checkBoxDataProcessingSpeed.MouseEnter += new System.EventHandler(this.SetStatusbar);
			this.checkBoxDataProcessingSpeed.MouseLeave += new System.EventHandler(this.ClearStatusbar);
			// 
			// checkBoxFinalEvent
			// 
			this.checkBoxFinalEvent.AccessibleDescription = "Click to apply final event";
			this.checkBoxFinalEvent.AccessibleName = "Apply final event";
			this.checkBoxFinalEvent.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
			this.checkBoxFinalEvent.AutoSize = true;
			this.checkBoxFinalEvent.Checked = true;
			this.checkBoxFinalEvent.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBoxFinalEvent.Location = new System.Drawing.Point(12, 217);
			this.checkBoxFinalEvent.Name = "checkBoxFinalEvent";
			this.checkBoxFinalEvent.Size = new System.Drawing.Size(104, 17);
			this.checkBoxFinalEvent.TabIndex = 10;
			this.checkBoxFinalEvent.Text = "Appl&y final event";
			this.toolTip.SetToolTip(this.checkBoxFinalEvent, "Apply final event");
			this.checkBoxFinalEvent.UseVisualStyleBackColor = true;
			this.checkBoxFinalEvent.Enter += new System.EventHandler(this.SetStatusbar);
			this.checkBoxFinalEvent.Leave += new System.EventHandler(this.ClearStatusbar);
			this.checkBoxFinalEvent.MouseEnter += new System.EventHandler(this.SetStatusbar);
			this.checkBoxFinalEvent.MouseLeave += new System.EventHandler(this.ClearStatusbar);
			// 
			// labelSortingAlgorithm
			// 
			this.labelSortingAlgorithm.AccessibleDescription = "Show the sorting algorithms";
			this.labelSortingAlgorithm.AccessibleName = "Sorting algorithm";
			this.labelSortingAlgorithm.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelSortingAlgorithm.AutoSize = true;
			this.labelSortingAlgorithm.Location = new System.Drawing.Point(9, 15);
			this.labelSortingAlgorithm.Name = "labelSortingAlgorithm";
			this.labelSortingAlgorithm.Size = new System.Drawing.Size(88, 13);
			this.labelSortingAlgorithm.TabIndex = 0;
			this.labelSortingAlgorithm.Text = "Sorting &algorithm:";
			this.labelSortingAlgorithm.Enter += new System.EventHandler(this.SetStatusbar);
			this.labelSortingAlgorithm.Leave += new System.EventHandler(this.ClearStatusbar);
			this.labelSortingAlgorithm.MouseEnter += new System.EventHandler(this.SetStatusbar);
			this.labelSortingAlgorithm.MouseLeave += new System.EventHandler(this.ClearStatusbar);
			// 
			// labelVisualizationScheme
			// 
			this.labelVisualizationScheme.AccessibleDescription = "Show the visualization scheme";
			this.labelVisualizationScheme.AccessibleName = "Visualization scheme";
			this.labelVisualizationScheme.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelVisualizationScheme.AutoSize = true;
			this.labelVisualizationScheme.Location = new System.Drawing.Point(9, 61);
			this.labelVisualizationScheme.Name = "labelVisualizationScheme";
			this.labelVisualizationScheme.Size = new System.Drawing.Size(108, 13);
			this.labelVisualizationScheme.TabIndex = 2;
			this.labelVisualizationScheme.Text = "&Visualization scheme:";
			this.labelVisualizationScheme.Enter += new System.EventHandler(this.SetStatusbar);
			this.labelVisualizationScheme.Leave += new System.EventHandler(this.ClearStatusbar);
			this.labelVisualizationScheme.MouseEnter += new System.EventHandler(this.SetStatusbar);
			this.labelVisualizationScheme.MouseLeave += new System.EventHandler(this.ClearStatusbar);
			// 
			// labelShuffleMode
			// 
			this.labelShuffleMode.AccessibleDescription = "Show the shuffle mode";
			this.labelShuffleMode.AccessibleName = "Shuffle mode";
			this.labelShuffleMode.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelShuffleMode.AutoSize = true;
			this.labelShuffleMode.Location = new System.Drawing.Point(9, 88);
			this.labelShuffleMode.Name = "labelShuffleMode";
			this.labelShuffleMode.Size = new System.Drawing.Size(72, 13);
			this.labelShuffleMode.TabIndex = 4;
			this.labelShuffleMode.Text = "Shuffle &mode:";
			this.labelShuffleMode.Enter += new System.EventHandler(this.SetStatusbar);
			this.labelShuffleMode.Leave += new System.EventHandler(this.ClearStatusbar);
			this.labelShuffleMode.MouseEnter += new System.EventHandler(this.SetStatusbar);
			this.labelShuffleMode.MouseLeave += new System.EventHandler(this.ClearStatusbar);
			// 
			// comboBoxShuffleMode
			// 
			this.comboBoxShuffleMode.AccessibleDescription = "Click to show the shuffle scheme";
			this.comboBoxShuffleMode.AccessibleName = "Shuffle mode";
			this.comboBoxShuffleMode.AccessibleRole = System.Windows.Forms.AccessibleRole.ComboBox;
			this.comboBoxShuffleMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxShuffleMode.FormattingEnabled = true;
			this.comboBoxShuffleMode.Location = new System.Drawing.Point(121, 85);
			this.comboBoxShuffleMode.Name = "comboBoxShuffleMode";
			this.comboBoxShuffleMode.Size = new System.Drawing.Size(147, 21);
			this.comboBoxShuffleMode.TabIndex = 5;
			this.toolTip.SetToolTip(this.comboBoxShuffleMode, "Shuffle mode");
			this.comboBoxShuffleMode.Enter += new System.EventHandler(this.SetStatusbar);
			this.comboBoxShuffleMode.Leave += new System.EventHandler(this.ClearStatusbar);
			this.comboBoxShuffleMode.MouseEnter += new System.EventHandler(this.SetStatusbar);
			this.comboBoxShuffleMode.MouseLeave += new System.EventHandler(this.ClearStatusbar);
			// 
			// comboBoxDrawMode
			// 
			this.comboBoxDrawMode.AccessibleDescription = "Click to show the draw scheme";
			this.comboBoxDrawMode.AccessibleName = "Draw mode";
			this.comboBoxDrawMode.AccessibleRole = System.Windows.Forms.AccessibleRole.ComboBox;
			this.comboBoxDrawMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxDrawMode.FormattingEnabled = true;
			this.comboBoxDrawMode.Location = new System.Drawing.Point(121, 112);
			this.comboBoxDrawMode.Name = "comboBoxDrawMode";
			this.comboBoxDrawMode.Size = new System.Drawing.Size(147, 21);
			this.comboBoxDrawMode.TabIndex = 7;
			this.toolTip.SetToolTip(this.comboBoxDrawMode, "Draw mode");
			this.comboBoxDrawMode.Enter += new System.EventHandler(this.SetStatusbar);
			this.comboBoxDrawMode.Leave += new System.EventHandler(this.ClearStatusbar);
			this.comboBoxDrawMode.MouseEnter += new System.EventHandler(this.SetStatusbar);
			this.comboBoxDrawMode.MouseLeave += new System.EventHandler(this.ClearStatusbar);
			// 
			// labelDrawMode
			// 
			this.labelDrawMode.AccessibleDescription = "Show the draw mode";
			this.labelDrawMode.AccessibleName = "Draw mode";
			this.labelDrawMode.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelDrawMode.AutoSize = true;
			this.labelDrawMode.Location = new System.Drawing.Point(9, 115);
			this.labelDrawMode.Name = "labelDrawMode";
			this.labelDrawMode.Size = new System.Drawing.Size(64, 13);
			this.labelDrawMode.TabIndex = 6;
			this.labelDrawMode.Text = "&Draw mode:";
			this.labelDrawMode.Enter += new System.EventHandler(this.SetStatusbar);
			this.labelDrawMode.Leave += new System.EventHandler(this.ClearStatusbar);
			this.labelDrawMode.MouseEnter += new System.EventHandler(this.SetStatusbar);
			this.labelDrawMode.MouseLeave += new System.EventHandler(this.ClearStatusbar);
			// 
			// toolTip
			// 
			this.toolTip.IsBalloon = true;
			// 
			// statusStrip
			// 
			this.statusStrip.AccessibleDescription = "Show the Statusbar";
			this.statusStrip.AccessibleName = "Statusbar";
			this.statusStrip.AccessibleRole = System.Windows.Forms.AccessibleRole.StatusBar;
			this.statusStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
			this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
			this.statusStrip.Location = new System.Drawing.Point(0, 336);
			this.statusStrip.Name = "statusStrip";
			this.statusStrip.ShowItemToolTips = true;
			this.statusStrip.Size = new System.Drawing.Size(541, 22);
			this.statusStrip.SizingGrip = false;
			this.statusStrip.TabIndex = 14;
			this.statusStrip.Text = "statusStrip";
			// 
			// toolStripStatusLabel
			// 
			this.toolStripStatusLabel.AccessibleDescription = "Shw some information";
			this.toolStripStatusLabel.AccessibleName = "Information";
			this.toolStripStatusLabel.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.toolStripStatusLabel.AutoToolTip = true;
			this.toolStripStatusLabel.DoubleClickEnabled = true;
			this.toolStripStatusLabel.Name = "toolStripStatusLabel";
			this.toolStripStatusLabel.Size = new System.Drawing.Size(70, 17);
			this.toolStripStatusLabel.Text = "Information";
			this.toolStripStatusLabel.ToolTipText = "Information";
			// 
			// MainForm
			// 
			this.AccessibleDescription = "Application";
			this.AccessibleName = "Application";
			this.AccessibleRole = System.Windows.Forms.AccessibleRole.Application;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(541, 358);
			this.Controls.Add(this.statusStrip);
			this.Controls.Add(this.labelDrawMode);
			this.Controls.Add(this.comboBoxDrawMode);
			this.Controls.Add(this.labelShuffleMode);
			this.Controls.Add(this.comboBoxShuffleMode);
			this.Controls.Add(this.labelVisualizationScheme);
			this.Controls.Add(this.labelSortingAlgorithm);
			this.Controls.Add(this.checkBoxFinalEvent);
			this.Controls.Add(this.checkBoxDataProcessingSpeed);
			this.Controls.Add(this.groupBoxVisualizationDepth);
			this.Controls.Add(this.comboBoxVisualizationScheme);
			this.Controls.Add(this.tableLayoutPanel);
			this.Controls.Add(this.panelDraw);
			this.Controls.Add(this.comboBoxSortingAlgorithm);
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
			this.statusStrip.ResumeLayout(false);
			this.statusStrip.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button buttonSort;
		private System.Windows.Forms.Button buttonShuffle;
		private System.Windows.Forms.ComboBox comboBoxSortingAlgorithm;
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
		private System.Windows.Forms.Label labelSortingAlgorithm;
		private System.Windows.Forms.Label labelVisualizationScheme;
		private System.Windows.Forms.Label labelShuffleMode;
		private System.Windows.Forms.ComboBox comboBoxShuffleMode;
		private System.Windows.Forms.ComboBox comboBoxDrawMode;
		private System.Windows.Forms.Label labelDrawMode;
		private System.Windows.Forms.RadioButton radioBoxVisualizationDepthNone;
		private System.Windows.Forms.ToolTip toolTip;
		private System.Windows.Forms.StatusStrip statusStrip;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
	}
}

