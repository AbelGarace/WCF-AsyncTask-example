using AsyncTaskExample.ServiceReference1;
using AsyncTaskExample.ViewModel;
using System.Threading.Tasks;
using System.Windows;

namespace AsyncTaskExample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Service1Client servicio;
        UserViewModel userViewModel;
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = new UserViewModel();
            userViewModel = (UserViewModel)this.DataContext;
            servicio = new Service1Client();
        }

        private void RefreshButton_Click(object sender, RoutedEventArgs e)
        {
            User user= new User() { Age = "25", Name = "Usuario", LastName = "Local" };            
            userViewModel.Age = user.Age;
            userViewModel.Name = user.Name;
            userViewModel.LastName = user.LastName;            
        }

        private async void AsyncRefresh_Click(object sender, RoutedEventArgs e)
        {
            loadingControl.Start();
            User result = await Task.Run(() => { return servicio.GetUser(); });
            userViewModel.Age = result.Age;
            userViewModel.Name = result.Name;
            userViewModel.LastName = result.LastName;
            loadingControl.Stop();
        }
    }
}
