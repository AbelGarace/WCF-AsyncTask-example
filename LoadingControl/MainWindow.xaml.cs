using System.Windows;

namespace LoadingControl
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

        private void StopButton_Click(object sender, RoutedEventArgs e)
        {
            loading.Stop();
        }

        private void BeginButton_Click(object sender, RoutedEventArgs e)
        {
            loading.Start();
        }
    }
}
