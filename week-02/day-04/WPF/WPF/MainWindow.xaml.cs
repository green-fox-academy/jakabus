using System.Windows;
using GreenFox;
using System.Windows.Media;

namespace WPF
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

            // draw a red horizontal line to the canvas' middle.
            // draw a green vertical line to the canvas' middle.

            foxDraw.StrokeColor(Colors.Red);
            foxDraw.DrawLine(50, 100, 50, 200, 10.0);

            foxDraw.StrokeColor(Colors.Green);
            foxDraw.DrawLine(100, 150, 200, 150, 10.0);

        }
    }
}
