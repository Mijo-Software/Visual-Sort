using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
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

		private void DrawArray()
		{
			for (byte i = 0; i < array.Length - 1; i++)
			{
				graphics.DrawLine(penDraw, i, panelDraw.Height - array[i], i, panelDraw.Height);
				graphics.DrawLine(penControl, i, 0, i, 0 + (panelDraw.Height - array[i]));
			}
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

		private void MainForm_Load(object sender, EventArgs e)
		{
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
		}
	}
}
