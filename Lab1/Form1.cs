using System;
using System.Drawing;
using System.Windows.Forms;
using MathNet.Numerics;


namespace Lab1
{
    public partial class Form1 : Form
    {
        private const int N = 8;
        Complex32[] C;
        Complex32[] X = new Complex32[N];
        Complex32[] newX;
        PointF[] points;

        public Form1()
        {
            InitializeComponent();

        }
        public void doit()
        {
            Func.getX(out points, N);
            draw(ref pictureBox1, Color.Black);
            Func.pointToComplex(ref points, ref X);
            

            Fourier.dft(ref X, out C, -1, N);
            drawSpectrPhase(ref PhaseBox1, Color.Red);
            drawSpectrMag(ref MarBox1, Color.Red);
            Fourier.dft(ref C, out newX, 1, N);
            Func.complexToPoint(ref points, ref newX);
            draw(ref FuncBox1, Color.Red);


            C = Fourier.fft(X, -1);
            for (int i = 0; i < N; i++) { C[i] /= 8; }
            drawSpectrPhase(ref PhaseBox2, Color.Blue);
            drawSpectrMag(ref MarBox2, Color.Blue);
            newX = Fourier.fft(C, 1);
            Func.complexToPoint(ref points, ref newX);
            draw(ref FuncBox2, Color.Blue);

        }
        void draw(ref PictureBox box, Color c)
        {
            PointF[] p;
            p = new PointF[N];
            points.CopyTo(p, 0);

            Graphics g = box.CreateGraphics();
            Pen pen1 = new Pen(Color.Black, 1.0F);

            float y = 75;
            float x = 20;
            g.DrawLine(pen1, 0, y, 200, y);


            Pen pen = new Pen(c, 3.0F);
            for (int i = 0; i < N; i++)
            {
                p[i].X = p[i].X * 30 + x;
                p[i].Y = p[i].Y * 30 + y;
            }
            g.DrawCurve(pen, p);


        }

        void drawSpectrPhase(ref PictureBox box, Color c)
        {
            Graphics g = box.CreateGraphics();
            Pen pen1 = new Pen(Color.Black, 1.0F);
            
            float y = 75;
            float x = 20;
            g.DrawLine(pen1, 0, y, 200, y);


            Pen pen = new Pen(c, 3.0F);
            for (int i = 0; i < N; i++)
            {
                g.DrawLine(pen, x, y, x, y - 1 - C[i].Phase*20);
                x += 20;
            }
            
        }

        void drawSpectrMag(ref PictureBox box, Color c)
        {
            Graphics g = box.CreateGraphics();
            Pen pen1 = new Pen(Color.Black, 1.0F);

            float y = 75;
            float x = 20;
            g.DrawLine(pen1, 0, y, 200, y);

            Pen pen = new Pen(c, 3.0F);
            for (int i = 0; i < N; i++)
            {
                g.DrawLine(pen, x, y, x, y - 1 - C[i].Magnitude * 20);
                x += 20;
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            doit();
        }

    }
    
}
