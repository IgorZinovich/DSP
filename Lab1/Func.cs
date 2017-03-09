using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using MathNet.Numerics;

namespace Lab1
{
    class Func
    {
        public static void getX(out PointF[] points, int N)
        {
            points = new PointF[N];
            var step = (float)Math.PI * 2 / N;
            float x = 0;

            var y = new float[N];
            for (int i = 0; i < N; i++)
            {
                points[i].Y = (float)Math.Cos(3 * x) + (float)Math.Sin(2 * x);
                points[i].X = x;
                x += step;
            }
        }

        public static void pointToComplex(ref PointF[] p, ref Complex32[] c)
        {
            int i = 0;
            foreach(var item in p)
            {
                c[i++] = new Complex32(item.Y, 0);
            }
        }

        public static void complexToPoint(ref PointF[] p, ref Complex32[] c)
        {
            for(int i = 0; i < p.Length; i++)
            {
                p[i].Y = c[i].Real;
            }
        }

    }
}
