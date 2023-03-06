namespace zad4
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
            this.Width = 200;
            this.Height = 200;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Brush brush = Brushes.White;
            Pen pen = Pens.Black;

            g.Clear(Color.Red);

            int x = (this.Width - 100) / 2;
            int y = (this.Height - 200) / 2;

            g.FillEllipse(brush, x, y, 100, 80); 
            g.FillEllipse(brush, x - 10, y + 80, 120, 100); 

            brush = Brushes.Black;
            g.FillEllipse(brush, x + 20, y + 30, 10, 10);
            g.FillEllipse(brush, x + 60, y + 30, 10, 10);

            brush = Brushes.Orange;
            Point[] points = {
        new Point(x + 50, y + 40),
        new Point(x + 40, y + 60),
        new Point(x + 60, y + 60)
    };
            g.FillPolygon(brush, points);

            pen = new Pen(Color.Black, 2);
            g.DrawArc(pen, x +37,y + 45, 30,30, 0, 180); 
        }
        }
    }
