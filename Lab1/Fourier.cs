using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathNet.Numerics;

namespace Lab1
{
    static class Fourier
    {    
        public static void dft(ref Complex32[] X, out Complex32[] Y, int sign, int N)
        {
            Y = new Complex32[N];
            for (int k = 0; k < N; k++)
            {
                for (int i = 0; i < N; i++)
                {
                    var phase = (sign * 2 * (Math.PI / N) * k * i);
                    var w = new Complex32((float)Math.Cos(phase), (float)Math.Sin(phase));
                    Y[k] += (X[i] * w);
                }
                if(sign == -1)
                {
                   Y[k] /= N;
                }
            }
        }

        public static Complex32[] fft(Complex32[] X, int sign)
        {
            if (X.Length == 1)
            {
                return X;
            }
            Complex32[] evens = new Complex32[X.Length / 2];
            Complex32[] odds = new Complex32[X.Length / 2];
            for (int k = 0, j = 0; k < X.Length; k += 2, j++)
            {
                evens[j] = X[k];
                odds[j] = X[k + 1];
            }
            evens = fft(evens, sign);
            odds = fft(odds, sign);
            Complex32 w1 = new Complex32((float)Math.Cos(2 * Math.PI / X.Length), (float)Math.Sin(sign * 2 * Math.PI / X.Length));
            Complex32 w = 1;
            Complex32[] newX = new Complex32[X.Length];
            for (int i = 0; i < X.Length/2; i++)
            {
                newX[i] = evens[i] + w * odds[i];
                newX[i + X.Length / 2] = evens[i] - w * odds[i];
                w *= w1;
            }
            return newX;
        }
    }
}
