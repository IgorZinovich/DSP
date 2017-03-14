using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Numerics;

namespace Lab2
{
    class Func
    {
        
        public static void getX(out PointF[] points, int N, Func<double, double> func, int n)
        {
            points = new PointF[N];
            var step = (float)Math.PI * 2 / N;
            float x = 0;
            var y = new float[N];
            for (int i = 0; i < N; i++)
            {
                points[i].Y = (float)func(n*x);
                points[i].X = x;
                x += step;
            }
        }

        public static void pointToComplex(ref PointF[] p, ref Complex[] c)
        {
            int i = 0;
            foreach(var item in p)
            {
                c[i++] = new Complex(item.Y, 0);
            }
        }

        public static void complexToPoint(ref PointF[] p, ref Complex[] c)
        {
            for(int i = 0; i < c.Length; i++)
            {
                p[i].Y = (float)c[i].Real;
            }
        }

        public static void cor(Complex[] X, Complex[] Y, out Complex[] Z)
        {
            int N = X.Length;
            Z = new Complex[N];
            for(int m = 0; m < N; m++)
            {
                for(int h = 0; h<N;h++)
                {
                    Z[m] += X[h] * Y[(m + h) % N];
                }
                Z[m] /= N;
            }
        }
        public static void corFFT(Complex[] X, Complex[] Y, out Complex[] Z)
        {
            int N = X.Length;
            Z = new Complex[N];

            Complex[] Cx = new Complex[N];
            Cx = Fourier.fft(X, -1);
            for(int i = 0; i < N; i++) Cx[i] /= N;
            getConjugate(ref Cx);


            Complex[] Cy = new Complex[N];
            Cy = Fourier.fft(Y, -1);
            for (int i = 0; i < N; i++) Cy[i] /= N;

            Complex[] Cz = new Complex[N];
            for(int i = 0; i < N; i++)
            {
                Cz[i] = Cx[i] * Cy[i];
            }

            Z = Fourier.fft(Cz, 1);
        }

        public static void conFFT(Complex[] X, Complex[] Y, out Complex[] Z)// свёртка
        {
            int N = X.Length;
            Z = new Complex[N];


            Complex[] Cx = new Complex[N];
            Cx = Fourier.fft(X, -1);
            for (int i = 0; i < N; i++) Cx[i] /= N;


            Complex[] Cy = new Complex[N];
            Cy = Fourier.fft(Y, -1);
            for (int i = 0; i < N; i++) Cy[i] /= N;


            Complex[] Cz = new Complex[N];
            for (int i = 0; i < N; i++)
            {
                Cz[i] = Cx[i] * Cy[i];
            }
            Z = Fourier.fft(Cz, 1);
        }

        private static void getConjugate(ref Complex[] X)
        {
            Complex[] Y = new Complex[X.Length];
            for(int i = 0; i < X.Length; i++)
            {
                Y[i] = new Complex(X[i].Real, -X[i].Imaginary);
            }
            X = Y;
        }

        public static void con(Complex[] X, Complex[] Y, out Complex[] Z) // перевести свёртку
        {
            int N = X.Length;
            Z = new Complex[N];
            for (int m = 0; m < N; m++)
            {
                for (int h = 0; h < N; h++)
                {
                    Z[m] += X[h] * Y[(N + m - h)%N]; // N = 4, h = 3, m = 0 // m-h = -3  
                }
                Z[m] /= N;
            }
        }
    }
}