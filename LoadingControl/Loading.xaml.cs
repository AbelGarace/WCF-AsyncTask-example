using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Animation;

namespace LoadingControl
{
    /// <summary>
    /// Interaction logic for Loading.xaml
    /// </summary>
    public partial class Loading : UserControl
    {
        public Loading()
        {
            InitializeComponent();
            this.Visibility = Visibility.Collapsed;
        }

        public void Start()
        {
            Storyboard loading = (Storyboard)this.FindResource("StoryboardAnimation");
            this.Visibility = Visibility.Visible;
            loading.Begin(this,true);
        }

        public void Stop()
        {
            Storyboard loading = (Storyboard)this.FindResource("StoryboardAnimation");
            this.Visibility = Visibility.Collapsed;
            loading.Stop(this);                       
        }
    }
}
