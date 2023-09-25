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

namespace WPF_CombineGeometry
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
	// constructor
        public MainWindow()
        {
            InitializeComponent();
        }

        int count = 0;

        public int Count { get; set; }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            EllipseGeometry eg = new EllipseGeometry(new Rect(10, 10, 100, 100));
            RectangleGeometry rg = new RectangleGeometry(new Rect(30, 30, 200, 100));
            CombinedGeometry cg = new CombinedGeometry(GeometryCombineMode.Xor, eg, rg, new RotateTransform(30, 10, 10));

            Path mainPath = new Path();

            // Задание цветов
            mainPath.Stroke = Brushes.Black;
            mainPath.Fill = Brushes.Beige;

            // Толщина контура
            mainPath.StrokeThickness = 1;

            mainPath.Data = cg;
            mainPath.Opacity = 1;

            mainCanvas.Children.Add(mainPath);
        }
    }
}
