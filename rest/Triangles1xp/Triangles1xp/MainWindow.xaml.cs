using System.Windows;
using GreenFox;
using System.Windows.Media;
using System.Windows.Controls;
using System;

namespace Triangles1xp
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

            double side = 700;
            double height = (Math.Sqrt(3)/2) * side;
            double[] startPoint = { 425, 100 };
            

            Triangle(foxDraw, height, side, startPoint);

        }
        public static void Triangle(FoxDraw foxDraw, double height, double side, double[] startP)
        {
            foxDraw.DrawLine(startP[0], startP[1], startP[0] + side, startP[1], 2.5);
            foxDraw.DrawLine(startP[0] + side, startP[1], startP[0] + (side / 2), startP[1] + height, 2.5);
            foxDraw.DrawLine(startP[0] + (side / 2), startP[1] + height, startP[0], startP[1], 2.5);
        }
    }
}
