using System;
using System.Drawing;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;

namespace Visual_Sort
{
	public partial class MainForm : Form
	{
		private byte[] array = new byte[byte.MaxValue];
		private Graphics graphics;
		private Pen penDraw = new Pen(SystemColors.ControlText, 1);
		private Pen penControl = new Pen(SystemColors.Control, 1);
		private bool isShuffled = false;
		Thread thread;
		Bitmap bmpsave;

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
			bmpsave = new Bitmap(panelDraw.Width, panelDraw.Height);
			graphics = Graphics.FromImage(bmpsave);
			panelDraw.Image = bmpsave;
			//graphics.Clear(SystemColors.Control);
			for (byte i = 0; i < array.Length - 1; i++)
			{
				graphics.DrawLine(penDraw, i, panelDraw.Height - array[i], i, panelDraw.Height);
				//graphics.DrawLine(penControl, i, 0, i, 0 + (panelDraw.Height - array[i]));
			}
			RefreshPanel(panelDraw);
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
			for (byte i = 1; i <= array.Length - 1; i++)
			{
				for (byte j = 0; j < array.Length - i; j++)
				{
					if (array[j] > array[j + 1])
					{
						Swap(ref array[j], ref array[j + 1]);
					}
				}
				DrawArray();
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
			InitArray();
		}

		private void ButtonShuffle_Click(object sender, EventArgs e)
		{
			if (!isShuffled)
			{
				isShuffled = true;
			}
			Shuffle(array);
			DrawArray();
		}

		private void ButtonSort_Click(object sender, EventArgs e)
		{
			if (!isShuffled)
			{
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
				buttonShuffle.Enabled = false;
				buttonSort.Enabled = false;
				BubbleSort();
				buttonShuffle.Enabled = true;
				buttonSort.Enabled = true;
			};
			thread = new Thread(threadStart);
			thread.Start();
		}
	}
}
