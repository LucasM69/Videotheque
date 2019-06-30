using System.Windows;
using System.Windows.Navigation;
using Videotheque.ViewModel;
using Videotheque.Views;

namespace Videotheque
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            MainWindowViewModel viewModel = new MainWindowViewModel();
            InitializeComponent();
            base.DataContext = viewModel;
        }

        private void BtnListeMedias_Click(object sender, RoutedEventArgs e)
        {
            ListeMedia host = new ListeMedia();
            host.ShowDialog();
        }
    }
}