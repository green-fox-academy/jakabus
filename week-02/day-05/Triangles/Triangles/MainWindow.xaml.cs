using System.Windows;
using GreenFox;
using System.Windows.Media;
using System.Windows.Controls;
using System;

namespace Triangles
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);

            double[] kezdopont = {100,700};
            double oldalhossz = 50;
            double[] kpont = { 100, 700};
            double m = (Math.Sqrt(3) / 2) * oldalhossz;
            
            int b = 1;
            int a = 15;

            for (int i = 0; i < 15; i++)
            {
                
                for (int j = 0; j < a; j++)
                {
                    Haromszog(oldalhossz, kezdopont, foxDraw);
                    kezdopont[0] = kezdopont[0] + (oldalhossz / 2);
                    kezdopont[1] = kezdopont[1] - m;
                }
                a--;
                kezdopont[0] = kpont[0];
                kezdopont[1] = kpont[1];

                kezdopont[0] = kezdopont[0] + (oldalhossz) * b;
                b++;
            }
        }
        public static void Haromszog(double oldalhossz, double[] kezdopont, FoxDraw foxDraw)
        {
            double m = (Math.Sqrt(3) / 2) * oldalhossz;
            
            foxDraw.DrawLine(kezdopont[0], kezdopont[1], kezdopont[0] + oldalhossz, kezdopont[1], 2.5);
            foxDraw.DrawLine(kezdopont[0] + oldalhossz, kezdopont[1], kezdopont[0] + (oldalhossz / 2), kezdopont[1] - m, 2.5);
            foxDraw.DrawLine(kezdopont[0] + (oldalhossz / 2), kezdopont[1] - m, kezdopont[0], kezdopont[1], 2.5);
        }
    }
}
