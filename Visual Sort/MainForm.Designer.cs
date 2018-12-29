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
			((System.ComponentModel.ISupportInitialize)(this.panelDraw)).BeginInit();
			this.SuspendLayout();
			// 
			// buttonSort
			// 
			this.buttonSort.Location = new System.Drawing.Point(12, 68);
			this.buttonSort.Name = "buttonSort";
			this.buttonSort.Size = new System.Drawing.Size(256, 23);
			this.buttonSort.TabIndex = 1;
			this.buttonSort.Text = "Start";
			this.buttonSort.UseVisualStyleBackColor = true;
			this.buttonSort.Click += new System.EventHandler(this.ButtonSort_Click);
			// 
			// buttonShuffle
			// 
			this.buttonShuffle.Location = new System.Drawing.Point(12, 39);
			this.buttonShuffle.Name = "buttonShuffle";
			this.buttonShuffle.Size = new System.Drawing.Size(256, 23);
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
			this.panelDraw.Location = new System.Drawing.Point(12, 97);
			this.panelDraw.Name = "panelDraw";
			this.panelDraw.Size = new System.Drawing.Size(256, 256);
			this.panelDraw.TabIndex = 4;
			this.panelDraw.TabStop = false;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(283, 369);
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
			this.Load += new System.EventHandler(this.MainForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.panelDraw)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Button buttonSort;
		private System.Windows.Forms.Button buttonShuffle;
		private System.Windows.Forms.ComboBox comboBoxSortAlgorithms;
		private System.Windows.Forms.PictureBox panelDraw;
	}
}

