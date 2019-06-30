using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Videotheque.DataAccess;
using Videotheque.enums;
using Videotheque.Model;

namespace Videotheque.ViewModel
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {


        #region ========================================= Attributs binding =========================================
        public string labelNbMediaDispo { get; set; }
        public string labelNbFilmsDispo { get; set; }
        public string labelNbSeriesDispo { get; set; }
        #endregion

        public int nbMedia { get; set; }

        public MainWindowViewModel()
        {
            this.Init();
            //onStartupAsync();
        }

        private async void Init()
        {
            try
            {
                this.labelNbMediaDispo = await Media.CountData();
                this.labelNbFilmsDispo = await Media.CountData(o => o.TypeMedia == TypeMedia.FILM);
                this.labelNbSeriesDispo = await Media.CountData(o => o.TypeMedia == TypeMedia.SERIE);
            }
            catch (Exception e)
            {
                Debug.WriteLine("Error > " + e.Message);
            }
        }

        /*private async void onStartupAsync()
        {
            DbService db = await DbService.getInstance();
            List<Media> lMedia = db.Medias.OrderBy(o => o.Titre).ToList();
            //Debug.WriteLine(db.Medias.Find());
            nbMedia = lMedia.Count();
        }*/

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
