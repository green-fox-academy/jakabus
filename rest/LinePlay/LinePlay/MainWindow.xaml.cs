using System.Windows;
using GreenFox;
using System.Windows.Media;

namespace LinePlay
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

            for (int i = 0; i < (canvas.Width/25)+1; i++)
            {
                foxDraw.StrokeColor(Colors.Purple);
                foxDraw.DrawLine(x, 0, canvas.Width, y, 2.5);
                x = x + 25;
                y = y + 25;
            }

            double x1 = 0;
            double y1 = 0;

            for (int i = 0; i < (canvas.Width/25)+1; i++)
            {
                foxDraw.StrokeColor(Colors.Green);
                foxDraw.DrawLine(0, x1, y1, canvas.Width, 2.5);
                x1 = x1 + 25;
                y1 = y1 + 25;
            }
            
        }
    }
}
