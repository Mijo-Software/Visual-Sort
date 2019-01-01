﻿using System;
using System.Drawing;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;

namespace Visual_Sort
{
	public partial class MainForm : Form
	{
		private long
			comparison = 0,
			swap = 0;

		private byte[] array = new byte[byte.MaxValue];

		private DateTime dtMeasurementsStart, dtMeasurementsEnd;

		private TimeSpan timeDiff;

		private Graphics graphics;

		private Pen
			penDraw = new Pen(SystemColors.ControlText,1 ),
			penMarker = new Pen(Color.OrangeRed, 1),
			penFinal = new Pen(Color.LimeGreen, 1),
			penControl = new Pen(SystemColors.Control, 1),
			penTemp;

		private SolidBrush
			brushDraw = new SolidBrush(SystemColors.ControlText),
			brushMarker = new SolidBrush(Color.OrangeRed),
			brushFinal = new SolidBrush(Color.LimeGreen),
			brushControl = new SolidBrush(SystemColors.Control),
			brushTemp;

		private bool isShuffled = false;

		private Thread thread;

		private Bitmap bmpSave;

		public MainForm()
		{
			InitializeComponent();
		}

		private void InitArray()
		{
			for (byte i = 0; i < array.Length; i++)
			{
				array[i] = i;
			}
		}

		private void MeasureTimeDiff()
		{
			dtMeasurementsEnd = DateTime.Now;
			timeDiff = dtMeasurementsEnd - dtMeasurementsStart;
			labelRuntimeValue.Text = timeDiff.TotalSeconds.ToString("#.## 'sec'");
		}

		private void ShowProcessingInformation()
		{
			if (checkBoxDataProcessingSpeed.Checked)
			{
				labelComparisonValue.Text = comparison.ToString() + (comparison / timeDiff.TotalSeconds).ToString("' ('#.## 'per sec)'");
				labelSwapValue.Text = swap.ToString() + (swap / timeDiff.TotalSeconds).ToString("' ('#.## 'per sec)'");
			}
			else
			{
				labelComparisonValue.Text = comparison.ToString();
				labelSwapValue.Text = swap.ToString();
			}
		}

		private void ApplyFinalEvent()
		{
			for (byte i = 0; i < array.Length - 1; i++)
			{
				switch (comboBoxVisualizationScheme.SelectedItem.ToString())
				{
					case "lines":
						{
							graphics.DrawLine(penFinal, i, panelDraw.Height - array[i], i, panelDraw.Height);
							//graphics.DrawLine(penControl, i, 0, i, 0 + (panelDraw.Height - array[i]));
							break;
						}
					case "dotes":
						{
							graphics.FillRectangle(brushFinal, i, panelDraw.Height - array[i], 1, 1);
							break;
						}
				}
			}
		}

		delegate void SetControlValueCallback(Control pnlSort);

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
			if (comboBoxVisualizationScheme.SelectedItem.ToString() != "lines") graphics.Clear(SystemColors.Control);
			for (byte i = 0; i < array.Length - 1; i++)
			{
				switch (comboBoxVisualizationScheme.SelectedItem.ToString())
				{
					case "lines":
						if (comboBoxDrawMode.SelectedItem.ToString() == "draw lines")
						{
							graphics.DrawLine(penDraw, i, panelDraw.Height - array[i], i, panelDraw.Height);
							graphics.DrawLine(penControl, i, 0, i, 0 + (panelDraw.Height - array[i]));
						}
						else if (comboBoxDrawMode.SelectedItem.ToString() == "fill rectangles")
						{
							graphics.FillRectangle(brushDraw, i, panelDraw.Height - array[i], i, panelDraw.Height);
							graphics.FillRectangle(brushControl, i, 0, i, 0 + (panelDraw.Height - array[i]));
						}
						break;
					case "dotes":
						graphics.FillRectangle(brushDraw, i, panelDraw.Height - array[i], 1, 1);
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
			if (comboBoxVisualizationScheme.SelectedItem.ToString() != "lines") graphics.Clear(SystemColors.Control);
			for (byte i = 0; i < array.Length - 1; i++)
			{
				switch (comboBoxVisualizationScheme.SelectedItem.ToString())
				{
					case "lines":
						if (radioBoxVisualizationDepthDetailed.Checked && (marker == i))
						{
							if (comboBoxDrawMode.SelectedItem.ToString() == "draw lines")
							{
								graphics.DrawLine(penMarker, i, panelDraw.Height - array[i], i, panelDraw.Height);
							}
							else if (comboBoxDrawMode.SelectedItem.ToString() == "fill rectangles")
							{
								graphics.FillRectangle(brushMarker, i, panelDraw.Height - array[i], i, panelDraw.Height);
							}
						}
						else
						{
							if (comboBoxDrawMode.SelectedItem.ToString() == "draw lines")
							{
								graphics.DrawLine(penDraw, i, panelDraw.Height - array[i], i, panelDraw.Height);
							}
							else if (comboBoxDrawMode.SelectedItem.ToString() == "fill rectangles")
							{
								graphics.FillRectangle(brushDraw, i, panelDraw.Height - array[i], i, panelDraw.Height);
							}
						}
						if (comboBoxDrawMode.SelectedItem.ToString() == "draw lines")
						{
							graphics.DrawLine(penControl, i, 0, i, 0 + (panelDraw.Height - array[i]));
						}
						else if (comboBoxDrawMode.SelectedItem.ToString() == "fill rectangles")
						{
							graphics.FillRectangle(brushControl, i, 0, i, 0 + (panelDraw.Height - array[i]));
						}
						break;
					case "dotes":
					{
						if (radioBoxVisualizationDepthDetailed.Checked && (marker == i))
						{
							graphics.FillRectangle(brushMarker, i, panelDraw.Height - array[i], 1, 1);
						}
						else
						{
							graphics.FillRectangle(brushDraw, i, panelDraw.Height - array[i], 1, 1);
						}
						break;
					}
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

		private static void Swap(ref byte x, ref byte y)
		{
			byte temp = x;
			x = y;
			y = temp;
		}

		private void BubbleSort1()
		{
			comparison = 0;
			swap = 0;
			for (byte i = 1; i <= array.Length - 1; i++)
			{
				for (byte j = 0; j < array.Length - i; j++)
				{
					comparison++;
					if (array[j] > array[j + 1])
					{
						swap++;
						Swap(ref array[j], ref array[j + 1]);
						if (radioBoxVisualizationDepthDetailed.Checked)
						{
							DrawArray((byte)(j + 1));
							MeasureTimeDiff();
							ShowProcessingInformation();
						}
					}
				}
				if (radioBoxVisualizationDepthSimple.Checked)
				{
					DrawArray();
					MeasureTimeDiff();
					ShowProcessingInformation();
				}
			}
		}

		private void BubbleSort2()
		{
			bool flipped = false;
			comparison = 0;
			swap = 0;
			byte n = (byte)array.Length;
			do
			{
				flipped = false;
				for (byte i = 0; i < n - 1; i++)
				{
					comparison++;
					if (array[i] > array[i + 1])
					{
						swap++;
						Swap(ref array[i], ref array[i + 1]);
						flipped = true;
						if (radioBoxVisualizationDepthDetailed.Checked)
						{
							DrawArray((byte)(i + 1));
							MeasureTimeDiff();
							ShowProcessingInformation();
						}
					}
				}
				n--;
				if (radioBoxVisualizationDepthSimple.Checked)
				{
					DrawArray();
					MeasureTimeDiff();
					ShowProcessingInformation();
				}
			} while (flipped);
		}

		private void BubbleSort3()
		{
			comparison = 0;
			swap = 0;
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
						swap++;
						newn = (byte)(i + 1);
						Swap(ref array[i], ref array[i + 1]);
						if (radioBoxVisualizationDepthDetailed.Checked)
						{
							DrawArray((byte)(i + 1));
							MeasureTimeDiff();
							ShowProcessingInformation();
						}
					}
				}
				n = newn;
				if (radioBoxVisualizationDepthSimple.Checked)
				{
					DrawArray();
					MeasureTimeDiff();
					ShowProcessingInformation();
				}
			} while (n > 1);
		}

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
			graphics = panelDraw.CreateGraphics();
			comboBoxSortAlgorithm.SelectedIndex = 0;
			comboBoxVisualizationScheme.SelectedIndex = 0;
			comboBoxShuffleMode.SelectedIndex = 0;
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

		private void ButtonShuffle_Click(object sender, EventArgs e)
		{
			if (!isShuffled)
			{
				isShuffled = true;
			}
			labelComparisonValue.Text =
				labelSwapValue.Text =
				labelRuntimeValue.Text = "0";
			switch (comboBoxShuffleMode.SelectedItem.ToString())
			{
				case "random":
					Shuffle(array);
					break;
				case "sorted forward":
					for (byte i = 0; i < array.Length; i++)
					{
						array[i] = i;
					}
					break;
				case "sorted reverse":
					for (byte i = 0; i < array.Length; i++)
					{
						array[array.Length - 1 - i] = i;
					}
					break;
				default:
					Shuffle(array);
					break;
			}
			DrawArray();
		}

		private void ButtonSort_Click(object sender, EventArgs e)
		{
			dtMeasurementsStart = DateTime.Now;
			MeasureTimeDiff();
			if (!isShuffled)
			{
				labelComparisonValue.Text =
					labelSwapValue.Text =
					labelRuntimeValue.Text = "0";
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
				comboBoxSortAlgorithm.Enabled = false;
				buttonShuffle.Enabled = false;
				buttonSort.Enabled = false;
				switch (comboBoxSortAlgorithm.SelectedItem.ToString())
				{
					case "Bubble Sort (original version)":
						BubbleSort1();
						break;
					case "Bubble Sort (premature termination)":
						BubbleSort2();
						break;
					case "Bubble Sort (comparative reduction)":
						BubbleSort3();
						break;
				}
				if (checkBoxFinalEvent.Checked) ApplyFinalEvent();
				comboBoxSortAlgorithm.Enabled = true;
				buttonShuffle.Enabled = true;
				buttonSort.Enabled = true;
			};
			thread = new Thread(threadStart);
			thread.Start();
			MeasureTimeDiff();
		}
	}
}
