using System;
using System.Windows;
using System.Windows.Threading;

namespace Exercise06
{
    public partial class MainWindow : Window
    {
        private DispatcherTimer _timer = new DispatcherTimer();
        public MainWindow()
        {
            InitializeComponent();
            _timer.Interval = TimeSpan.FromMilliseconds(100);
        }

        private void startButton_Click(object sender, RoutedEventArgs e)
        {
            _timer.Start();


        }
    }
}
