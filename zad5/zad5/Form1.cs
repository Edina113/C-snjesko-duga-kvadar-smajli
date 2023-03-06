using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace zad5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load; ;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Width = 300;
            this.Height = 300;
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            g.Clear(Color.Green);

            GraphicsPath roundedRect = GetRoundedRect(new Rectangle(50, 50, 200, 200), 20);
            g.FillPath(Brushes.White, roundedRect);

            GraphicsPath smileyPath = GetSmileyPath(g, new Rectangle(80, 80, 140, 140));
            g.FillPath(Brushes.Green, smileyPath);
        }

        private GraphicsPath GetRoundedRect(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();

            path.AddArc(rect.X, rect.Y, radius * 2, radius * 2, 180, 90);
            path.AddLine(rect.X + radius, rect.Y, rect.Right - radius * 2, rect.Y);
            path.AddArc(rect.X + rect.Width - radius * 2, rect.Y, radius * 2, radius * 2, 270, 90);
            path.AddLine(rect.Right, rect.Y + radius * 2, rect.Right, rect.Bottom - radius * 2);
            path.AddArc(rect.X + rect.Width - radius * 2, rect.Y + rect.Height - radius * 2, radius * 2, radius * 2, 0, 90);
            path.AddLine(rect.Right - radius * 2, rect.Bottom, rect.X + radius * 2, rect.Bottom);
            path.AddArc(rect.X, rect.Y + rect.Height - radius * 2, radius * 2, radius * 2, 90, 90);
            path.AddLine(rect.X, rect.Bottom - radius * 2, rect.X, rect.Y + radius * 2);

            path.CloseFigure();

            return path;
        }

        private GraphicsPath GetSmileyPath(Graphics g, Rectangle rect)
        {
            GraphicsPath path = new GraphicsPath();

            path.AddEllipse(rect.X + rect.Width / 5, rect.Y + rect.Height / 4, rect.Width / 6, rect.Height / 6);
            path.AddEllipse(rect.X + rect.Width * 3 / 5, rect.Y + rect.Height / 4, rect.Width / 6, rect.Height / 6);

            Rectangle mouthRect = new Rectangle(rect.X + rect.Width / 4, rect.Y + rect.Height / 2 + rect.Height / 10, rect.Width / 2, rect.Height / 4);
            path.AddArc(mouthRect, 0, 180);

            path.CloseFigure();

            return path;
        }
    }
}
