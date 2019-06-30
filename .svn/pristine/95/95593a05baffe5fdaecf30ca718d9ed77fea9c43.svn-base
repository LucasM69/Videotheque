using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Xml.Serialization;
using Videotheque.Model;
using Videotheque.Tools;
using Videotheque.Views;

namespace Videotheque.ViewModel
{
    class ListeMediaViewModel : INotifyPropertyChanged
    {
        #region ========================================= Attributs binding =========================================
        public ButtonCommandBinding ButtonRecherche { get; set; }
        public ButtonCommandBinding ButtonAddMedia { get; set; }

        public string ImageLogoFilm { get; set; }

        ObservableCollection<Media> listeMedia = new ObservableCollection<Media>();
        public ObservableCollection<Media> ListeMedia {
            get => listeMedia;
            set
            {
                listeMedia = value;
            }
        }

        Media selectedMedia;
        public Media SelectedMedia { get => selectedMedia;
            set
            {
                selectedMedia = value;
                this.consultMedia(selectedMedia);
            }
        }

        private string sNameMedia = null;
        public string NameMedia
        {
            get
            {
                return sNameMedia;
            }
            set
            {
                this.sNameMedia = value;
                OnPropertyChanged(nameof(NameMedia));
            }
        }

        private string sTypMedia = null ;
        public string TypeMedia {
            get
            {
                return sTypMedia;
            }
            set
            {
                this.sTypMedia = value;
               OnPropertyChanged(nameof(TypeMedia));
            }
        }

        private string sFilterCase = null;
        public string FilterCase
        {
            get
            {
                return this.sFilterCase;
            }
            set
            {
                this.sFilterCase = value;
                OnPropertyChanged(nameof(FilterCase));
            }
        }
        #endregion

        public ListeMediaViewModel()
        {
            this.Init();
            ImageLogoFilm = Path.GetDirectoryName(Path.GetDirectoryName(Directory.GetCurrentDirectory())) + "\\Assets\\Images\\logo.jpg";
            //Call the button command binding class to
            //register the button click event with the handler
            ButtonRecherche = new ButtonCommandBinding(rechercherMedia);
            ButtonAddMedia = new ButtonCommandBinding(ajoutMedia);

            //Enable the button click event
            ButtonRecherche.IsEnabled = true;
            ButtonAddMedia.IsEnabled = true;
        }

        private void ajoutMedia()
        {
            //Ouvrir fenêtre ajout média
            AjoutMedia ajoutMedia = new AjoutMedia();
            ajoutMedia.ShowDialog();


        }

        private async void Init()
        {
            try
            {
                await afficherListeMedias();
            }
            catch (Exception e)
            {
                Debug.WriteLine("Erreur > " + e.Message);
            }
        }

        private void consultMedia(Media selectedMedia)
        {
            ConsultationMedia consultMedia = new ConsultationMedia(selectedMedia);
            consultMedia.ShowDialog();

        }

        private async Task afficherListeMedias()
        {
            ListeMedia.Clear();

            List<Media> listMedia = await Media.GetData();
            // Récupération de tous les médias


            foreach (Media e in listMedia)
            {
                ListeMedia.Add(e);
            }

        }

        private void rechercherMedia()
        {


            //Filtrer les médias


            // var predicat;
            // Vérification du titre
            if (NameMedia != null)
            {
                // Vérification si le type de média est renseigné
                if (TypeMedia != null || String.Equals(TypeMedia, "Aucun") == false )
                {
                    //Vérification si le tri est renseigné
                    if (FilterCase != null || String.Equals(FilterCase, "Aucun") == false)
                    {
                        // Si on arrive ici, les 3 champs sont renseignés, le prédicat va donc avoir une clause where et un orderBy
                    }
                }
                else
                // Ici, le Type de média n'est pas renseigné mais le tri peut l'être
                {
                    if (FilterCase != null || String.Equals(FilterCase, "Aucun") == false)
                    {
                        // Si on arrive ici, les 3 champs sont renseignés, le prédicat va donc avoir une clause where et un orderBy
                    }
                    else
                    {
                        // Le nom du média uniquement est renseigné
                        Debug.WriteLine("Le nom média uniquement est renseigné");
                    }
                }
            }
            // Ici, le nom du média n'est pas renseigné
            else
            {
                // Ici, le nom est pas renseigné, mais le type de média ou le filtre peut être renseigné
                // Vérification si le type de média est renseigné
                if (TypeMedia != null || String.Equals(TypeMedia, "Aucun") == false)
                {
                    //Vérification si le tri est renseigné
                    if (FilterCase != null || String.Equals(FilterCase, "Aucun") == false)
                    {
                        // Si on arrive ici, les 2 champs filtre et typesont renseignés, le prédicat va donc avoir une clause where et un orderBy
                    }
                    else
                    {
                        // Ici, le type media uniquement est renseigné
                        Debug.WriteLine("Le Filtre media uniquement est renseigné");
                    }
                }
                else
                // Ici, le Type de média n'est pas renseigné mais le tri peut l'être
                {
                    if (FilterCase != null || String.Equals(FilterCase, "Aucun") == false)
                    {
                        // Si on arrive ici, le tri uniquement est renseigné
                        Debug.WriteLine("Le tri uniquement est renseigné");
                    }else
                    //Ici, ni le tri ni le 
                    {
                        //Ici, le nom du média uniqument est renseigné
                        
                    }
                }

            }
            Debug.WriteLine("======= " + NameMedia + " =======");
            Debug.WriteLine("======= " + TypeMedia + " =======");
            Debug.WriteLine("======= " + FilterCase + " =======");
        }

        [field: NonSerialized]
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged( string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
