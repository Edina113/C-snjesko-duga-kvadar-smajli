using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace zad2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            int centerX = this.Width / 2;
            int centerY = this.Height / 2;
            int radius = Math.Min(centerX, centerY);
            int circleCount = 7;

            int[] circleRadii = new int[circleCount];
            for (int i = 0; i < circleCount; i++)
            {
                circleRadii[i] = (int)(radius * (circleCount - i) / (double)circleCount);
            }

            Brush[] circleBrushes = new Brush[]
            {
                Brushes.Red,
                Brushes.Orange,
                Brushes.Yellow,
                Brushes.Green,
                Brushes.Blue,
                Brushes.Indigo,
                Brushes.Violet
            };

            for (int i = 0; i < circleCount; i++)
            {
                int currentRadius = circleRadii[i];
                Brush currentBrush = circleBrushes[i % circleBrushes.Length];

                int x = centerX - currentRadius;
                int y = centerY - currentRadius;

                e.Graphics.FillEllipse(currentBrush, x, y, currentRadius * 2, currentRadius * 2);
            }
        }

    }
}
