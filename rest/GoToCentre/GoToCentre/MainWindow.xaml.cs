using System.Windows;
using GreenFox;
using System.Windows.Media;
using System;

namespace GoToCentre
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private static object foxDraw;
        private object y;
        private object x;

        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            // Create a line drawing function that takes 2 parameters:
            // The x and y coordinates of the line's starting point
            // and draws a line from that point to the center of the canvas.
            // Draw 3 lines with that function. Use loop for that.
            
            double x1 = 0;
            double y2 = 0;
            for (int i = 0; i < 40; i++)
            {
                FuncThatDraws(x1, y2, foxDraw);
                x1 = x1 + 20;                
            }

        }

        private void FuncThatDraws(double x1, double y2, FoxDraw foxDraw)
        {
            foxDraw.DrawLine(x1, y2, (canvas.Width/2.0), (canvas.Height/2.0), 2.5);
        }
    }
}
