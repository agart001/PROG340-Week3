namespace PROG340_Week3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Width = 800;
            this.Height = 800;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Pen pen = new Pen(Color.Black);

            graphics.FillRectangle(new SolidBrush(Color.Azure), new Rectangle(0, 0, 800, 800));

            graphics.FillPie(new SolidBrush(Color.Orange), new Rectangle(600, -200, 400, 400), 90, 90);

            graphics.DrawArc(new Pen(Color.Yellow, 20f), new Rectangle(600, -200, 400, 400), 90, 90);

            graphics.FillPolygon(new SolidBrush(Color.DarkGray), new Point[] { new Point(-100, 800), new Point(200, 200), new Point(500, 800)});
            graphics.FillPolygon(new SolidBrush(Color.Gray), new Point[] { new Point(100, 800), new Point(400, 300), new Point(700, 800) });

            graphics.FillEllipse(new SolidBrush(Color.DarkGreen), new Rectangle(-100, 580, 1000, 400));

            graphics.FillRectangle(new SolidBrush(Color.BlanchedAlmond), new Rectangle(370, 540, 50, 50));
            graphics.DrawRectangle(new Pen(Color.Black, 5f), new Rectangle(370, 540, 50, 50));

            graphics.FillPolygon(new SolidBrush(Color.BurlyWood), new Point[] { new Point(400, 550), new Point(410, 560), new Point(400, 580), new Point(390, 580), new Point(380, 560), new Point(390, 550) });
            graphics.DrawPolygon(new Pen(Color.Black, 5f), new Point[] { new Point(400, 550), new Point(410, 560), new Point(400, 580), new Point(390, 580), new Point(380, 560), new Point(390, 550)});

            graphics.DrawEllipse(pen, new Rectangle(400, 510, 100, 100));
        }
    }
}