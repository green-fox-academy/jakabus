using System.Windows;
using GreenFox;
using System.Windows.Media;
namespace Diagonals
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
            // Draw the canvas' diagonals.
            // If it starts from the upper-left corner it should be green, otherwise it should be red.

            foxDraw.StrokeColor(Colors.Green);
            foxDraw.DrawLine(0, 0, 500, 500, 5.5);

            foxDraw.StrokeColor(Colors.Red);
            foxDraw.DrawLine(500, 0, 0, 500, 5.5);
        }
    }
}
