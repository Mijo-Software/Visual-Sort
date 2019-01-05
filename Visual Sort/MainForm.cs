using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;

using Visual_Sort.Properties;

namespace Visual_Sort
{
	public partial class MainForm : Form
	{
		private long
			comparison = 0,
			swap = 0;

		private byte[] array = new byte[byte.MaxValue];

		private Stopwatch watch = new Stopwatch();

		private Graphics graphics;

		private Pen
			penDraw = new Pen(SystemColors.ControlText,1 ),
			penMarker = new Pen(Color.OrangeRed, 1),
			penFinal = new Pen(Color.LimeGreen, 1),
			penControl = new Pen(Color.White, 1);

		private SolidBrush
			brushDraw = new SolidBrush(SystemColors.ControlText),
			brushMarker = new SolidBrush(Color.OrangeRed),
			brushFinal = new SolidBrush(Color.LimeGreen),
			brushControl = new SolidBrush(Color.White);

		private bool isShuffled = false;

		private Thread thread;

		private Bitmap bmpSave;

		private Dictionary<string, string> dicLogging = new Dictionary<string, string>();

		#region Assemblyattributaccessoren

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public string GetAssemblyTitle()
		{
			object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(attributeType: typeof(AssemblyTitleAttribute), inherit: false);
			if (attributes.Length > 0)
			{
				AssemblyTitleAttribute titleAttribute = (AssemblyTitleAttribute)attributes[0];
				if (titleAttribute.Title != "")
				{
					return titleAttribute.Title;
				}
			}
			return System.IO.Path.GetFileNameWithoutExtension(path: Assembly.GetExecutingAssembly().CodeBase);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public string GetAssemblyVersion() => Assembly.GetExecutingAssembly().GetName().Version.ToString();

		/// <summary>
		/// 
		/// </summary>
		public string GetAssemblyDescription()
		{
			object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(attributeType: typeof(AssemblyDescriptionAttribute), inherit: false);
			if (attributes.Length == 0)
			{
				return "";
			}
			return ((AssemblyDescriptionAttribute)attributes[0]).Description;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public string GetAssemblyProduct()
		{
			object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(attributeType: typeof(AssemblyProductAttribute), inherit: false);
			if (attributes.Length == 0)
			{
				return "";
			}
			return ((AssemblyProductAttribute)attributes[0]).Product;
		}

		/// <summary>
		/// 
		/// </summary>
		public string GetAssemblyCopyright()
		{
			object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(attributeType: typeof(AssemblyCopyrightAttribute), inherit: false);
			if (attributes.Length == 0)
			{
				return "";
			}
			return ((AssemblyCopyrightAttribute)attributes[0]).Copyright;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public string GetAssemblyCompany()
		{
			object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(attributeType: typeof(AssemblyCompanyAttribute), inherit: false);
			if (attributes.Length == 0)
			{
				return "";
			}
			return ((AssemblyCompanyAttribute)attributes[0]).Company;
		}
		#endregion

		public MainForm() => InitializeComponent();

		private void InitArray()
		{
			for (byte i = 0; i < array.Length; i++)
			{
				array[i] = i;
			}
		}

		private void InitArrayReverse()
		{
			for (byte i = 0; i < array.Length; i++)
			{
				array[array.Length - i] = i;
			}
		}

		private void MeasureTime() => labelRuntimeValue.Text = watch.Elapsed.ToString();

		private void ShowProcessingInformation()
		{
			if (checkBoxDataProcessingSpeed.Checked)
			{
				labelComparisonValue.Text = comparison.ToString() + (comparison / watch.Elapsed.TotalSeconds).ToString("' ('#.## 'per sec)'");
				labelSwapValue.Text = swap.ToString() + (swap / watch.Elapsed.TotalSeconds).ToString("' ('#.## 'per sec)'");
			}
			else
			{
				labelComparisonValue.Text = comparison.ToString();
				labelSwapValue.Text = swap.ToString();
			}
		}

		private void DoLogging()
		{
			if (checkBoxEnableLogging.Checked)
			{
				dicLogging.Add(watch.Elapsed.ToString(), String.Join(",", array.Select(p => p.ToString()).ToArray()));
			}
		}

		private void ApplyFinalEvent()
		{
			string strLines = Resources.strLines;
			for (byte i = 0; i < array.Length; i++)
			{
				switch (comboBoxVisualizationScheme.SelectedIndex)
				{
					case 0: //lines
						{
							graphics.DrawLine(penFinal, i + 1, panelDraw.Height - array[i], i + 1, panelDraw.Height);
							//graphics.DrawLine(penControl, i + 1, 0, i + 1, panelDraw.Height - array[i]);
							break;
						}
					case 1: //dotes
						{
							graphics.FillRectangle(brushFinal, i + 1, panelDraw.Height - array[i], 1, 1);
							break;
						}
				}
			}
		}

		private delegate void SetControlValueCallback(Control pnlSort);

		private void RefreshPanel(Control pnlSort)
		{
			if (pnlSort.InvokeRequired)
			{
				SetControlValueCallback d = new SetControlValueCallback(RefreshPanel);
				pnlSort.Invoke(d, new object[] { pnlSort });
			}
			else
			{
				pnlSort.Refresh();
			}
		}

		private void DrawArray()
		{
			/*bmpSave = new Bitmap(panelDraw.Width, panelDraw.Height);
			graphics = Graphics.FromImage(bmpSave);
			panelDraw.Image = bmpSave;*/
			if (comboBoxVisualizationScheme.SelectedItem.ToString() != Resources.strLines) graphics.Clear(panelDraw.BackColor);
			for (byte i = 0; i < array.Length; i++)
			{
				switch (comboBoxVisualizationScheme.SelectedIndex)
				{
					case 0: //lines
						if (comboBoxDrawMode.SelectedItem.ToString() == Resources.strDrawLines)
						{
							graphics.DrawLine(penDraw, i + 1, panelDraw.Height - array[i], i + 1, panelDraw.Height);
							graphics.DrawLine(penControl, i + 1, 0, i + 1, panelDraw.Height - array[i]);
						}
						else if (comboBoxDrawMode.SelectedItem.ToString() == Resources.strFillRectangles)
						{
							graphics.FillRectangle(brushDraw, i + 1, panelDraw.Height - array[i], i + 1, panelDraw.Height);
							graphics.FillRectangle(brushControl, i + 1, 0, i + 1, panelDraw.Height - array[i]);
						}
						break;
					case 1: //dotes
						graphics.FillRectangle(brushDraw, i + 1, panelDraw.Height - array[i], 1, 1);
						break;
				}
			}
			//RefreshPanel(panelDraw);
		}

		private void DrawArray(byte marker)
		{
			/*bmpSave = new Bitmap(panelDraw.Width, panelDraw.Height);
			graphics = Graphics.FromImage(bmpSave);
			panelDraw.Image = bmpSave;*/
			if (comboBoxVisualizationScheme.SelectedItem.ToString() != Resources.strLines) graphics.Clear(panelDraw.BackColor);
			for (byte i = 0; i < array.Length; i++)
			{
				switch (comboBoxVisualizationScheme.SelectedIndex)
				{
					case 0: //lines
						if (radioBoxVisualizationDepthDetailed.Checked && (marker == i))
						{
							if (comboBoxDrawMode.SelectedItem.ToString() == Resources.strDrawLines)
							{
								graphics.DrawLine(penMarker, i + 1, panelDraw.Height - array[i], i + 1, panelDraw.Height);
							}
							else if (comboBoxDrawMode.SelectedItem.ToString() == Resources.strFillRectangles)
							{
								graphics.FillRectangle(brushMarker, i + 1, panelDraw.Height - array[i], i + 1, panelDraw.Height);
							}
						}
						else
						{
							if (comboBoxDrawMode.SelectedItem.ToString() == Resources.strDrawLines)
							{
								graphics.DrawLine(penDraw, i + 1, panelDraw.Height - array[i], i + 1, panelDraw.Height);
							}
							else if (comboBoxDrawMode.SelectedItem.ToString() == Resources.strFillRectangles)
							{
								graphics.FillRectangle(brushDraw, i + 1, panelDraw.Height - array[i], i + 1, panelDraw.Height);
							}
						}
						if (comboBoxDrawMode.SelectedItem.ToString() == Resources.strDrawLines)
						{
							graphics.DrawLine(penControl, i + 1, 0, i + 1, panelDraw.Height - array[i]);
						}
						else if (comboBoxDrawMode.SelectedItem.ToString() == Resources.strFillRectangles)
						{
							graphics.FillRectangle(brushControl, i + 1, 0, i + 1, panelDraw.Height - array[i]);
						}
						break;
					case 1: //dotes
						if (radioBoxVisualizationDepthDetailed.Checked && (marker == i))
						{
							graphics.FillRectangle(brushMarker, i + 1, panelDraw.Height - array[i], 1, 1);
						}
						else
						{
							graphics.FillRectangle(brushDraw, i + 1, panelDraw.Height - array[i], 1, 1);
						}
						break;
				}
			}
			//RefreshPanel(panelDraw);
		}

		private void Shuffle<T>(T[] array)
		{
			Random rng = new Random();
			int n = array.Length;
			while (n > 1)
			{
				int k = rng.Next(n--);
				T temp = array[n];
				array[n] = array[k];
				array[k] = temp;
			}
		}

		private void Swap(ref byte x, ref byte y)
		{
			swap++;
			byte temp = x;
			x = y;
			y = temp;
		}

		#region TrippelSort

		private void TrippelSort1(byte l, byte r)
		{
			byte k;
			comparison++;
			if (array[l] > array[r])
			{
				Swap(ref array[l], ref array[r]);
				if (radioBoxVisualizationDepthDetailed.Checked)
				{
					DrawArray((byte)(r + 1));
					MeasureTime();
					ShowProcessingInformation();
				}
				DoLogging();
			}
			if (radioBoxVisualizationDepthSimple.Checked)
			{
				DrawArray();
				MeasureTime();
				ShowProcessingInformation();
			}
			if (l < r - 1)
			{
			  k = (byte)((r - l + 1) / 3);
				TrippelSort1(l, (byte)(r - k));
				TrippelSort1((byte)(l + k), r);
				TrippelSort1(l, (byte)(r - k));
			}
			if (radioBoxVisualizationDepthNone.Checked)
			{
				graphics.Clear(panelDraw.BackColor);
				//RefreshPanel(panelDraw);
				MeasureTime();
				ShowProcessingInformation();
			}
		}

		private void StoogeSort(byte i, byte j)
		{
			comparison++;
			if (array[j].CompareTo(array[i]) < 0)
			{
				Swap(ref array[i], ref array[j]);
				if (radioBoxVisualizationDepthDetailed.Checked)
				{
					DrawArray((byte)(j + 1));
					MeasureTime();
					ShowProcessingInformation();
				}
				DoLogging();
			}
			if (radioBoxVisualizationDepthSimple.Checked)
			{
				DrawArray();
				MeasureTime();
				ShowProcessingInformation();
			}
			if (j - i > 1)
			{
				byte t = (byte)((j - i + 1) / 3);
				StoogeSort(i, (byte)(j - t));
				StoogeSort((byte)(i + t), j);
				StoogeSort(i, (byte)(j - t));
			}
			if (radioBoxVisualizationDepthNone.Checked)
			{
				graphics.Clear(panelDraw.BackColor);
				//RefreshPanel(panelDraw);
				MeasureTime();
				ShowProcessingInformation();
			}
		}

		#endregion

		#region BubbleSort

		private void BubbleSort1()
		{
			for (byte i = 1; i <= array.Length - 1; i++)
			{
				for (byte j = 0; j < array.Length - i; j++)
				{
					comparison++;
					if (array[j] > array[j + 1])
					{
						Swap(ref array[j], ref array[j + 1]);
						if (radioBoxVisualizationDepthDetailed.Checked)
						{
							DrawArray((byte)(j + 1));
							MeasureTime();
							ShowProcessingInformation();
						}
						DoLogging();
					}
				}
				if (radioBoxVisualizationDepthSimple.Checked)
				{
					DrawArray();
					MeasureTime();
					ShowProcessingInformation();
				}
			}
			if (radioBoxVisualizationDepthNone.Checked)
			{
				graphics.Clear(panelDraw.BackColor);
				//RefreshPanel(panelDraw);
				MeasureTime();
				ShowProcessingInformation();
			}
		}

		private void BubbleSort2()
		{
			bool flipped = false;
			byte n = (byte)array.Length;
			do
			{
				flipped = false;
				for (byte i = 0; i < n - 1; i++)
				{
					comparison++;
					if (array[i] > array[i + 1])
					{
						Swap(ref array[i], ref array[i + 1]);
						flipped = true;
						if (radioBoxVisualizationDepthDetailed.Checked)
						{
							DrawArray((byte)(i + 1));
							MeasureTime();
							ShowProcessingInformation();
						}
						DoLogging();
					}
				}
				n--;
				if (radioBoxVisualizationDepthSimple.Checked)
				{
					DrawArray();
					MeasureTime();
					ShowProcessingInformation();
				}
			} while (flipped);
			if (radioBoxVisualizationDepthNone.Checked)
			{
				graphics.Clear(panelDraw.BackColor);
				//RefreshPanel(panelDraw);
				MeasureTime();
				ShowProcessingInformation();
			}
		}

		private void BubbleSort3()
		{
			byte n = (byte)array.Length;
			byte newn = 0;
			do
			{
				newn = 1;
				for (byte i = 0; i < n - 1; i++)
				{
					comparison++;
					if (array[i] > array[i + 1])
					{
						newn = (byte)(i + 1);
						Swap(ref array[i], ref array[i + 1]);
						if (radioBoxVisualizationDepthDetailed.Checked)
						{
							DrawArray((byte)(i + 1));
							MeasureTime();
							ShowProcessingInformation();
						}
						DoLogging();
					}
				}
				n = newn;
				if (radioBoxVisualizationDepthSimple.Checked)
				{
					DrawArray();
					MeasureTime();
					ShowProcessingInformation();
				}
			} while (n > 1);
			if (radioBoxVisualizationDepthNone.Checked)
			{
				graphics.Clear(panelDraw.BackColor);
				//RefreshPanel(panelDraw);
				MeasureTime();
				ShowProcessingInformation();
			}
		}

		#endregion

		#region Statusbar

		private void SetStatusbar(object sender, EventArgs e)
		{
			if (sender is Button button)
			{
				toolStripStatusLabel.Text = button.AccessibleDescription;
			}
			else if (sender is Label label)
			{
				toolStripStatusLabel.Text = label.AccessibleDescription;
			}
			else if (sender is ComboBox comboBox)
			{
				toolStripStatusLabel.Text = comboBox.AccessibleDescription;
			}
			else if (sender is RadioButton radioButton)
			{
				toolStripStatusLabel.Text = radioButton.AccessibleDescription;
			}
			else if (sender is CheckBox checkBox)
			{
				toolStripStatusLabel.Text = checkBox.AccessibleDescription;
			}
			else if (sender is PictureBox pictureBox)
			{
				toolStripStatusLabel.Text = pictureBox.AccessibleDescription;
			}
			else if (sender is StatusStrip statusStrip)
			{
				toolStripStatusLabel.Text = statusStrip.AccessibleDescription;
			}
			else if (sender is GroupBox groupBox)
			{
				toolStripStatusLabel.Text = groupBox.AccessibleDescription;
			}
			else if (sender is TableLayoutPanel tableLayoutPanel)
			{
				toolStripStatusLabel.Text = tableLayoutPanel.AccessibleDescription;
			}
			else if (sender is ToolStripStatusLabel toolStripStatusLabel)
			{
				toolStripStatusLabel.Text = toolStripStatusLabel.AccessibleDescription;
			}
		}

		private void ClearStatusbar(object sender, EventArgs e)
		{
			toolStripStatusLabel.Text = "";
		}

		#endregion

		#region Mainform-Events

		private void MainForm_Load(object sender, EventArgs e)
		{
			DoubleBuffered = true;
			SetStyle(ControlStyles.OptimizedDoubleBuffer |
				ControlStyles.UserPaint |
				ControlStyles.AllPaintingInWmPaint, true);
			UpdateStyles();
			typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty |
				BindingFlags.Instance |
				BindingFlags.NonPublic, null, panelDraw, new object[] { true });
			ClearStatusbar(null, null);
			graphics = panelDraw.CreateGraphics();
			comboBoxSortingAlgorithm.Items.AddRange(new object[] {
				Resources.strTrippelSort1,
				Resources.strBubbleSort1,
				Resources.strBubbleSort2,
				Resources.strBubbleSort3});
			comboBoxSortingAlgorithm.SelectedIndex = 0;
			comboBoxVisualizationScheme.Items.AddRange(new object[] {
				Resources.strLines,
				Resources.strDotes});
			comboBoxVisualizationScheme.SelectedIndex = 0;
			comboBoxShuffleMode.Items.AddRange(new object[] {
				Resources.strRandom,
				Resources.strSortedForward,
				Resources.strSortedReverse});
			comboBoxShuffleMode.SelectedIndex = 0;
			comboBoxDrawMode.Items.AddRange(new object[] {
				Resources.strDrawLines,
				Resources.strFillRectangles});
			comboBoxDrawMode.SelectedIndex = 0;
			InitArray();
		}

		private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (thread != null)
			{
				thread.Abort();
				thread.Join();
			}
		}

		#endregion

		#region Button-Events

		private void ButtonShuffle_Click(object sender, EventArgs e)
		{
			if (!isShuffled)
			{
				isShuffled = true;
			}
			labelComparisonValue.Text =
				labelSwapValue.Text =
				labelRuntimeValue.Text = Resources.strNumberZero;
			switch (comboBoxShuffleMode.SelectedIndex)
			{
				case 0: //random
					Shuffle(array);
					break;
				case 1: //sorted forward
					InitArray();
					break;
				case 2: //sorted reverse
					InitArrayReverse();
					break;
				default:
					Shuffle(array);
					break;
			}
			graphics.Clear(panelDraw.BackColor);
			DrawArray();
		}

		private void ButtonSort_Click(object sender, EventArgs e)
		{
			MeasureTime();
			if (!isShuffled)
			{
				labelComparisonValue.Text =
					labelSwapValue.Text =
					labelRuntimeValue.Text = Resources.strNumberZero;
				isShuffled = true;
				Shuffle(array);
				DrawArray();
			}
			if (thread != null)
			{
				thread.Abort();
				thread.Join();
			}
			ThreadStart threadStart = delegate()
			{
				watch.Reset();
				watch.Start();
				comboBoxSortingAlgorithm.Enabled = false;
				checkBoxEnableLogging.Enabled = false;
				buttonSaveLogging.Enabled = false;
				buttonShuffle.Enabled = false;
				buttonSort.Enabled = false;
				dicLogging.Clear();
				comparison = 0;
				swap = 0;
				switch (comboBoxSortingAlgorithm.SelectedIndex)
				{
					case 0: //Trippel Sort = Stooge Sort (original version)
						StoogeSort(0, (byte)(array.Length - 1));
						//TrippelSort1(0, (byte)(array.Length - 1));
						break;
					case 1: //Bubble Sort (original version)
						BubbleSort1();
						break;
					case 2: //Bubble Sort (premature termination)
						BubbleSort2();
						break;
					case 3: //Bubble Sort (comparative reduction)
						BubbleSort3();
						break;
				}
				if (checkBoxFinalEvent.Checked) ApplyFinalEvent();
				comboBoxSortingAlgorithm.Enabled = true;
				checkBoxEnableLogging.Enabled = true;
				buttonShuffle.Enabled = true;
				buttonSort.Enabled = true;
				if (checkBoxEnableLogging.Checked)
				{
					buttonSaveLogging.Enabled = true;
				}
				watch.Stop();
			};
			thread = new Thread(threadStart);
			thread.Start();
			MeasureTime();
		}

		private void ButtonSaveLogging_Click(object sender, EventArgs e)
		{
			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				StreamWriter stream = File.CreateText(saveFileDialog.FileName);
				for (int i = 0; i < dicLogging.Count; i++)
				//for (int i = dicLogging.Count - 1; i >= 0; i--)
				{
					/*var item = dicLogging.ElementAt(i);
					var itemKey = dicLogging.ElementAt(i).Key;
					var itemValue = dicLogging.ElementAt(i).Value;*/
					stream.WriteLine(i.ToString() + ";" + dicLogging.ElementAt(i).Key + ";" + dicLogging.ElementAt(i).Value + ";");
				}
				/*
				uint i = 0;
				foreach(var pair in dicLogging)
				{
					i++;
					stream.WriteLine(i.ToString() + ";" + pair.Key + ";" + pair.Value + ";");
				}
				*/
			}
		}

		#endregion
	}
}