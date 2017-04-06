using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections;
using System.Numerics;

namespace Lab2
{
    public partial class Form1 : Form
    {
        private const int N = 8;
        Complex[] X = new Complex[N];
        Complex[] Y = new Complex[N];
        PointF[] pointsCos, pointsSin;
        Complex[] Zcon;
        Complex[] Zconfft;
        Complex[] Zcor;
        Complex[] Zcorfft;

        public Form1()
        {
            InitializeComponent();
        }
        public void doit()
        {
            Func.getX(out pointsCos, N, Math.Cos, 3);
            draw(pointsCos, ref CosBox, Color.Red);
            Func.getX(out pointsSin, N, Math.Sin, 2);
            draw(pointsSin, ref SinBox, Color.Blue);
            Func.pointToComplex(ref pointsCos, ref X);
            Func.pointToComplex(ref pointsSin, ref Y);

            Func.cor(X, Y, out Zcor);
            Func.corFFT(X, Y, out Zcorfft);
            Func.con(X, Y, out Zcon);
            Func.conFFT(X, Y, out Zconfft);
            draw1(ref conBox, Color.Blue, Zcon);
            draw1(ref corBox, Color.Black, Zcor);
            draw1(ref confftBox, Color.Blue, Zconfft);
            draw1(ref corfftBox, Color.Black, Zcorfft);
            System.Console.Write(12);
        }
        void draw(PointF[] points, ref PictureBox box, Color c)
        {
            PointF[] p;
            p = new PointF[2*N + 3];
            points.CopyTo(p, 0);
            for(int i = N ; i < 2*N + 3; i++)
            {
                p[i].X = p[1].X + p[i - 1].X;
                p[i].Y = p[i % N].Y;
            }
            Graphics g = box.CreateGraphics();
            Pen pen1 = new Pen(Color.Black, 1.0F);
            float y = 75;
            float x = 20;
            g.DrawLine(pen1, 0, y, 200, y);
            g.DrawLine(pen1, x-20, 0, x-20, 150);

            Pen pen = new Pen(c, 2.0F);
            for (int i = 0; i < 2*N + 3; i++)
            {
                p[i].X = p[i].X * 15 + x-20;
                p[i].Y = -p[i].Y * 15 + y;
            }
            g.DrawCurve(pen, p);
        }

        void draw1(ref PictureBox box, Color c, Complex[] f)
        {
            PointF[] p = new PointF[2*N+3];
            pointsCos.CopyTo(p, 0);
            Func.complexToPoint(ref p, ref f);
            for (int i = N; i < 2 * N + 3; i++)
            {
                p[i].X = p[1].X + p[i - 1].X;
                p[i].Y = p[i % N].Y;
            }
            Graphics g = box.CreateGraphics();
            Pen pen1 = new Pen(Color.Black, 1.0F);
            float y = 75;
            float x = 20;
            g.DrawLine(pen1, 0, y, 200, y);
            g.DrawLine(pen1, 0, 0, 0, 150);

            Pen pen = new Pen(c, 2.0F);
            for (int i = 0; i < 2*N + 3; i++)
            {
                p[i].X = p[i].X * 15 + x-20;
                p[i].Y = -p[i].Y * 250000000 + y;
            }
            g.DrawCurve(pen, p);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            doit();
        }

    }
    
}
