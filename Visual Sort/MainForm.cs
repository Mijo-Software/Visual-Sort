using System;
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
			penDrawMarker = new Pen(Color.OrangeRed, 1),
			penControl = new Pen(SystemColors.Control, 1);

		private SolidBrush
			brushDraw = new SolidBrush(SystemColors.ControlText),
			brushDrawMarker = new SolidBrush(Color.OrangeRed),
			brushDrawControl = new SolidBrush(SystemColors.Control);

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
			/*bmpsave = new Bitmap(panelDraw.Width, panelDraw.Height);
			graphics = Graphics.FromImage(bmpsave);
			panelDraw.Image = bmpsave;*/
			if (comboBoxScheme.SelectedItem.ToString() != "lines") graphics.Clear(SystemColors.Control);
			for (byte i = 0; i < array.Length - 1; i++)
			{
				switch (comboBoxScheme.SelectedItem.ToString())
				{
					case "lines":
					{
						graphics.DrawLine(penDraw, i, panelDraw.Height - array[i], i, panelDraw.Height);
						graphics.DrawLine(penControl, i, 0, i, 0 + (panelDraw.Height - array[i]));
						break;
					}
					case "dotes":
					{
						graphics.FillRectangle(brushDraw, i, panelDraw.Height - array[i], 1, 1);
						break;
					}
				}
			}
			//RefreshPanel(panelDraw);
		}

		private void DrawArray(byte marker)
		{
			/*bmpsave = new Bitmap(panelDraw.Width, panelDraw.Height);
			graphics = Graphics.FromImage(bmpsave);
			panelDraw.Image = bmpsave;*/
			if (comboBoxScheme.SelectedItem.ToString() != "lines") graphics.Clear(SystemColors.Control);
			for (byte i = 0; i < array.Length - 1; i++)
			{
				switch (comboBoxScheme.SelectedItem.ToString())
				{
					case "lines":
					{
						if (VisualisationDepthDetailed.Checked && (marker == i))
						{
							graphics.DrawLine(penDrawMarker, i, panelDraw.Height - array[i], i, panelDraw.Height);
						}
						else
						{
							graphics.DrawLine(penDraw, i, panelDraw.Height - array[i], i, panelDraw.Height);
						}
						graphics.DrawLine(penControl, i, 0, i, 0 + (panelDraw.Height - array[i]));
						break;
					}
					case "dotes":
					{
						if (VisualisationDepthDetailed.Checked && (marker == i))
						{
							graphics.FillRectangle(brushDrawMarker, i, panelDraw.Height - array[i], 1, 1);
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

		private void BubbleSort()
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
						if (VisualisationDepthDetailed.Checked)
						{
							DrawArray(j);
							MeasureTimeDiff();
							ShowProcessingInformation();
						}
					}
				}
				if (VisualisationDepthSimple.Checked)
				{
					DrawArray();
					MeasureTimeDiff();
					ShowProcessingInformation();
				}
			}
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
			comboBoxSortAlgorithms.SelectedIndex = 0;
			comboBoxScheme.SelectedIndex = 0;
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
			labelComparisonValue.Text = "0";
			labelSwapValue.Text = "0";
			labelRuntimeValue.Text = "0";
			Shuffle(array);
			DrawArray();
		}

		private void ButtonSort_Click(object sender, EventArgs e)
		{
			dtMeasurementsStart = DateTime.Now;
			MeasureTimeDiff();
			if (!isShuffled)
			{
				labelComparisonValue.Text = "0";
				labelSwapValue.Text = "0";
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
				comboBoxSortAlgorithms.Enabled = false;
				buttonShuffle.Enabled = false;
				buttonSort.Enabled = false;
				BubbleSort();
				comboBoxSortAlgorithms.Enabled = true;
				buttonShuffle.Enabled = true;
				buttonSort.Enabled = true;
			};
			thread = new Thread(threadStart);
			thread.Start();
			MeasureTimeDiff();
		}
	}
}
