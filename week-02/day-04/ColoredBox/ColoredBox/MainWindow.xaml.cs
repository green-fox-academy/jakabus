using GreenFox;

using System.Windows;
using System.Windows.Media;

namespace ColoredBox
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

            // Draw a box that has different colored lines on each edge.

            foxDraw.StrokeColor(Colors.Red);
            foxDraw.DrawLine(100,200, 100, 300,5.5);

            foxDraw.StrokeColor(Colors.Green);
            foxDraw.DrawLine(100, 200, 200, 200, 5.5);

            foxDraw.StrokeColor(Colors.Blue);
            foxDraw.DrawLine(200, 200, 200, 300, 5.5);

            foxDraw.StrokeColor(Colors.Chocolate);
            foxDraw.DrawLine(100, 300, 200, 300, 5.5);
        }
    }
}
