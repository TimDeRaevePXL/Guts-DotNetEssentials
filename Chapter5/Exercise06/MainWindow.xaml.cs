using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _5_6
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void DrawStreet()
        {
            DrawHouse(100, 0);
            DrawHouse(100, 120);
            DrawHouse(100, 240);
            DrawHouse(100, 360);
        }

        private void DrawHouse(int a, int b)
        {
            SolidColorBrush blackBrush = new SolidColorBrush(Colors.Black);
            // Draw wall
            Rectangle wall = new Rectangle();
            wall.Width = a;
            wall.Height = a;
            wall.Margin = new Thickness(b, 70, 0, 0);
            wall.Stroke = blackBrush;
            paperCanvas.Children.Add(wall);

            // Draw roof

            DrawTriangle(paperCanvas, blackBrush, b, 10, 100, 60);
        }
        private void DrawTriangle(Canvas drawingArea,
                                  SolidColorBrush brushToUse,
                                  double topX,
                                  double topY,
                                  double width,
                                  double height)
        {
            DrawLine(drawingArea, brushToUse, topX + width / 2, topY,
                     topX, topY + height);
            DrawLine(drawingArea, brushToUse, topX + width / 2, topY,
                     topX + width, topY + height);
        }

        private void DrawLine(Canvas drawingArea,
                              SolidColorBrush brushToUse,
                              double startX, double startY,
                              double endX, double endY)
        {
            Line theLine = new Line();
            theLine.X1 = startX; theLine.X2 = endX;
            theLine.Y1 = startY; theLine.Y2 = endY;
            theLine.Stroke = brushToUse;
            theLine.StrokeThickness = 1;
            drawingArea.Children.Add(theLine);
        }


        private void buildButton_Click(object sender, RoutedEventArgs e)
        {
            DrawStreet();
        }
    }
}
