using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ithomework
{
    public partial class 小畫家 : Form
    {
        private bool isDrawing = false;
        private Point previousPoint;
        private Color currentColor = Color.Black;
        private int currentThickness = 1;
        private List<Stroke> strokes = new List<Stroke>();
        public 小畫家()
        {
            InitializeComponent();
            trackBarThickness.Minimum = 1;
            trackBarThickness.Maximum = 20;
            trackBarThickness.TickFrequency = 1;
            trackBarThickness.LargeChange = 5;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            isDrawing = true;
            previousPoint = e.Location;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                Point currentPoint = e.Location;
                Stroke stroke = new Stroke(previousPoint, currentPoint, currentColor, currentThickness);
                strokes.Add(stroke);

                previousPoint = currentPoint;
                pictureBox1.Invalidate(); // 重绘PictureBox
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            isDrawing = false;
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            foreach (Stroke stroke in strokes)
            {
                Pen pen = new Pen(stroke.Color, stroke.Thickness);
                e.Graphics.DrawLine(pen, stroke.StartPoint, stroke.EndPoint);
                pen.Dispose();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            strokes.Clear();
            pictureBox1.Invalidate(); // 清除绘制内容，重绘PictureBox
        }

        private void trackBarThickness_Scroll(object sender, EventArgs e)
        {
            currentThickness = trackBarThickness.Value;

        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                currentColor = colorDialog.Color;
            }
        }
        public class Stroke
        {
            public Point StartPoint { get; }
            public Point EndPoint { get; }
            public Color Color { get; }
            public int Thickness { get; }

            public Stroke(Point startPoint, Point endPoint, Color color, int thickness)
            {
                StartPoint = startPoint;
                EndPoint = endPoint;
                Color = color;
                Thickness = thickness;
            }
        }
    }
}
