using System.Windows.Forms.VisualStyles;

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
            SolidBrush brush = new SolidBrush(Color.Black);
            Font titlefont = new Font("Arial", 20f);
            StringFormat sformat = new StringFormat();

            brush.Color = Color.Azure;
            graphics.FillRectangle(brush, new Rectangle(0, 0, 800, 800));

            brush.Color = Color.Orange;
            graphics.FillPie(brush, new Rectangle(600, -200, 400, 400), 90, 90);

            pen.Color = Color.Yellow;
            pen.Width = 20f;
            graphics.DrawArc(pen, new Rectangle(600, -200, 400, 400), 90, 90);

            brush.Color = Color.DarkGray;
            graphics.FillPolygon(brush, new Point[] { new Point(-100, 800), new Point(200, 200), new Point(500, 800)});

            brush.Color = Color.Gray;
            graphics.FillPolygon(brush, new Point[] { new Point(100, 800), new Point(400, 300), new Point(700, 800) });

            brush.Color = Color.DarkGreen;
            graphics.FillEllipse(brush, new Rectangle(-100, 580, 1000, 400));

            brush.Color = Color.BlanchedAlmond;
            graphics.FillRectangle(brush, new Rectangle(370, 540, 50, 50));

            pen.Color = Color.Black;
            pen.Width = 5f;
            graphics.DrawRectangle(pen, new Rectangle(370, 540, 50, 50));

            brush.Color = Color.BurlyWood;
            graphics.FillPolygon(brush, new Point[] { new Point(400, 550), new Point(410, 560), new Point(400, 580), new Point(390, 580), new Point(380, 560), new Point(390, 550) });

            graphics.DrawPolygon(pen, new Point[] { new Point(400, 550), new Point(410, 560), new Point(400, 580), new Point(390, 580), new Point(380, 560), new Point(390, 550)});

            brush.Color = Color.BlueViolet;
            sformat.Alignment = StringAlignment.Center;
            graphics.DrawString("Gaming Game for Gamers", titlefont, brush, new RectangleF(200, 200, 400, 400), sformat);

            pen.Color = Color.BlueViolet;
            pen.Width = titlefont.Size / 2;
            graphics.DrawLine(pen, new Point(225, 250), new Point(575, 250));

        }
    }
}