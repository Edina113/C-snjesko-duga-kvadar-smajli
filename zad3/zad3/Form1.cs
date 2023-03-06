namespace zad3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen pen = Pens.Black;

            int x1 = 50, y1 = 50, z1 = 50; 
            int x2 = 150, y2 = 150, z2 = 150; 

     
            int persp = 50;
            int dx = persp * (x1 + x2) / (2 * persp + z2 - z1);
            int dy = persp * (y1 + y2) / (2 * persp + z2 - z1);

         
            Point[] top = {
        new Point(x1 + dx, y1 + dy),
        new Point(x2 + dx, y1 + dy),
        new Point(x2, y1),
        new Point(x1, y1)
    };
            g.DrawPolygon(pen, top);

          
            Point[] bottom = {
        new Point(x1 + dx, y2 + dy),
        new Point(x2 + dx, y2 + dy),
        new Point(x2, y2),
        new Point(x1, y2)
    };
            g.DrawPolygon(pen, bottom);


            Point[] left = {
        new Point(x1 + dx, y1 + dy),
        new Point(x1 + dx, y2 + dy),
        new Point(x1, y2),
        new Point(x1, y1)
    };
            g.DrawPolygon(pen, left);

     
            Point[] right = {
        new Point(x2 + dx, y1 + dy),
        new Point(x2 + dx, y2 + dy),
        new Point(x2, y2),
        new Point(x2, y1)
    };
            g.DrawPolygon(pen, right);

        
            Point[] front = {
        new Point(x1 + dx, y1 + dy),
        new Point(x2 + dx, y1 + dy),
        new Point(x2 + dx, y2 + dy),
        new Point(x1 + dx, y2 + dy)
    };
            g.DrawPolygon(pen, front);
        }
    }
}