using System.Windows;

namespace Exercise01
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new Page1();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Main.Content = new Page2();
        }
    }
}
