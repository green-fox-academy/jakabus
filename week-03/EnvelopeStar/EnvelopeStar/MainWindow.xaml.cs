using System.Windows;
using GreenFox;
using System.Windows.Media;
using System;

namespace EnvelopeStar
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);

            double x = 0;
            double y = 0;

            for (int i = 0; i < 11; i++)
            {
                foxDraw.StrokeColor(Colors.Blue);
                foxDraw.DrawLine(x, (canvas.Height / 2), (canvas.Width / 2), (canvas.Height / 2)+y, 2.0);
                x = x + 25;
                y = y + 25;
            }

            double x1 = 0;
            double y1 = 0;

            for (int i = 0; i < 11; i++)
            {
                foxDraw.StrokeColor(Colors.Yellow);
                foxDraw.DrawLine(x1, (canvas.Height / 2), (canvas.Width / 2), (canvas.Height / 2) - y1, 2.0);
                x1 = x1 + 25;
                y1 = y1 + 25;
            }

            double x2 = 0;
            double y2 = 0;

            for (int i = 0; i < 11; i++)
            {
                foxDraw.StrokeColor(Colors.Orange);
                foxDraw.DrawLine((canvas.Width/2), (canvas.Height / 2) - x2, (canvas.Width) - y2, (canvas.Height / 2), 2.0);
                x2 = x2 + 25;
                y2 = y2 + 25;
            }

            double x3 = 0;
            double y3 = 0;

            for (int i = 0; i < 11; i++)
            {
                foxDraw.StrokeColor(Colors.Green);
                foxDraw.DrawLine((canvas.Width / 2), (canvas.Height / 2) + x3, (canvas.Width) - y3, (canvas.Height / 2), 2.0);
                x3 = x3 + 25;
                y3 = y3 + 25;
            }

        }
    }
}
