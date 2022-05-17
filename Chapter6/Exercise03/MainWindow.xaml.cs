using System;
using System.Windows;
using System.Threading.Tasks;
using System.Threading;

namespace Exercise03
{
    public partial class MainWindow : Window
    {
        private Random random = new Random();

        int sum = 0;
        int teller = 0;
        int average = 0;
        public MainWindow()
        {
            InitializeComponent();
        }
        private async void generateButton_Click(object sender, RoutedEventArgs e)
        {
                int number = random.Next(200, 400);
                sum += number;
                teller++;
                average = sum / teller;
                randomTextBox.Text = Convert.ToString(number);
                averageTextBox.Text = Convert.ToString(average);
                sumTextBox.Text = Convert.ToString(sum);
        }
    }
}
