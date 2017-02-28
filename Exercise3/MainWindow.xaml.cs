using Exercise3.ViewModel;
using System.Windows;

namespace Exercise3
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

        private void BlueView_Clicked(object sender, RoutedEventArgs args)
        {
            DataContext = new BlueViewModel();
        }
        private void RedView_Clicked(object sender, RoutedEventArgs args)
        {
            DataContext = new RedViewModel();
        }

        private void OrangeView_Clicked(object sender, RoutedEventArgs args)
        {
            DataContext = new OrangeViewModel();
        }
    }
}
