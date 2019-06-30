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
using System.Windows.Shapes;
using Videotheque.Model;
using Videotheque.ViewModel;

namespace Videotheque.Views
{
    /// <summary>
    /// Logique d'interaction pour ConsultationMedia.xaml
    /// </summary>
    public partial class ConsultationMedia : Window
    {
        public ConsultationMedia(Media selectedMedia)
        {
            ConsultationMediaViewModel viewModel = new ConsultationMediaViewModel();
            InitializeComponent();
            viewModel.SelectedMedia = selectedMedia;
            base.DataContext = viewModel;
        }
    }
}
