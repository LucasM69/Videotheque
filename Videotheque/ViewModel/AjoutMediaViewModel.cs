using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Videotheque.DataAccess;
using Videotheque.enums;
using Videotheque.Model;
using Videotheque.Tools;

namespace Videotheque.ViewModel
{
    class AjoutMediaViewModel : INotifyPropertyChanged
    {
        public Media NewMedia { get; set; }

        private string sTypeMedia;
        public string TypeMedia
        {
            get
            {
                return sTypeMedia;
            }
            set
            {
                sTypeMedia = value;
                OnPropertyChanged(nameof(TypeMedia));
            }
        }

        private string sTitre;
        public string Titre { get => sTitre; set
            {
                sTitre = value;
                OnPropertyChanged(nameof(Titre));
            } }
        
        private string sSynopsis;
        public string Synopsis { get => sSynopsis; set
            {
                sSynopsis = value;
                OnPropertyChanged(nameof(Synopsis));
            } }

        private DateTime oDateMedia = DateTime.Now;
        public DateTime DateMedia { get => oDateMedia; set
            {
                oDateMedia = value;
                OnPropertyChanged(nameof(DateMedia));
            } }

        private string sHeure ="";
        public string Heure { get => sHeure; set
            {
                sHeure = value;
                OnPropertyChanged(nameof(Heure));
            } }

        private string sMinute="" ;
        public string Minute { get => sMinute; set
            {
                sMinute = value;
                OnPropertyChanged(nameof(Minute));
            } }

        private string sSeconde ="";
        public string Seconde { get => sSeconde; set
            {
                sSeconde = value;
                OnPropertyChanged(nameof(Seconde));
            }
        }

        private string sAgeMin;
        public string AgeMin { get => sAgeMin; set
            {
                sAgeMin = value;
                OnPropertyChanged(nameof(AgeMin));
            } }

        private bool bSupportPhysique = false;
        public bool SupportPhysique { get => bSupportPhysique; set
            {
                bSupportPhysique = value;
                OnPropertyChanged(nameof(SupportPhysique));
            } }
        
        private bool bSupportNumerique = false;
        public bool SupportNumerique { get => bSupportNumerique; set
            {
                bSupportNumerique = value;
                OnPropertyChanged(nameof(SupportNumerique));
            } }

        private string sLangueVO;
        public string LangueVO { get => sLangueVO;set
            {
                sLangueVO = value;
                OnPropertyChanged(nameof(LangueVO));
            } }

        private string sLangueMedia;
        public string LangueMedia { get => sLangueMedia; set
            {
                sLangueMedia = value;
                OnPropertyChanged(nameof(LangueMedia));
            } }

        private string sSousTitre;
        public string SousTitre { get => sSousTitre; set
            {
                sSousTitre = value;
                OnPropertyChanged(nameof(SousTitre));
            } }




        public ButtonCommandBinding SaveButton { get; set; }

        public AjoutMediaViewModel()
        {
            //this.Init();
            SaveButton = new ButtonCommandBinding(saveMediaAsync);
            SaveButton.IsEnabled = true;
        }

        private async void saveMediaAsync()
        {

            if (sTypeMedia == null)
            {
                MessageBox.Show("Le type de média doit être renseigné", "Erreur");
                return;
            }

            TypeMedia typMedia = String.Equals(sTypeMedia, "Film") == true ? enums.TypeMedia.FILM : enums.TypeMedia.SERIE;
            if (String.IsNullOrEmpty(sTitre) == true ||String.IsNullOrWhiteSpace(sTitre) ==true)
            {
                MessageBox.Show("Le Nom du média dit être renseigné", "Erreur");
                return;
            }
            sSynopsis = sSynopsis == null ? "" : sSynopsis;
            if (oDateMedia == null)
            {
                MessageBox.Show("La date de sortie du média doit être renseignée", "Erreur");
                return;
            }

            int heure = 0 ,
                minute = 0 , seconde = 0;
            try
            {
                heure = Int32.Parse(sHeure);
                minute = Int32.Parse(sMinute);
                seconde = Int32.Parse(sSeconde);
            }
            catch (FormatException)
            {
                MessageBox.Show("Les champs heures, minutes et secondes doivent être au format number", "Error");
                return;
            }
            TimeSpan dureeMedia = new TimeSpan(heure, minute, seconde);
            if (sAgeMin == null )
            {
                MessageBox.Show("L'age minimum du média doit être définie", "Error");
                return;
            }

            int age = 0;
            try
            {
                age = Int32.Parse(sAgeMin);
            }
            catch (FormatException)
            {
                MessageBox.Show("Le champ âge minimum doit être au format number", "Error");
                return;
            }
            if (sLangueVO == null)
            {
                MessageBox.Show("La langue originale du média doit être définie", "Error");
                return;
            }
            if (sLangueMedia == null)
            {
                MessageBox.Show("La langue du média doit être définie", "Error");
                return;
            }

            sSousTitre = sSousTitre == null ? "" : sSousTitre;

            Langue langVO = Langue.ANGLAIS ;
            Langue langMedia = Langue.ANGLAIS;
            Langue langssTitre = Langue.ANGLAIS;
            switch (sLangueVO)
            {
                case "Anglais":
                    langVO = Langue.ANGLAIS;
                    break;
                case "Français":
                    langVO = Langue.FRANCAIS;
                    break;
                case "Japonais":
                    langVO = Langue.JAPONAIS;
                    break;
                case "Coréen":
                    langVO = Langue.COREEN;
                    break;
            }
            switch (sLangueMedia)
            {
                case "Anglais":
                    langMedia = Langue.ANGLAIS;
                    break;
                case "Français":
                    langMedia = Langue.FRANCAIS;
                    break;
                case "Japonais":
                    langMedia = Langue.JAPONAIS;
                    break;
                case "Coréen":
                    langMedia = Langue.COREEN;
                    break;
            }
            switch (sSousTitre)
            {
                case "Anglais":
                    langssTitre = Langue.ANGLAIS;
                    break;
                case "Français":
                    langssTitre = Langue.FRANCAIS;
                    break;
                case "Japonais":
                    langssTitre = Langue.JAPONAIS;
                    break;
                case "Coréen":
                    langssTitre = Langue.COREEN;
                    break;
            }

            Media newMedia = new Media()
            {
                TypeMedia = typMedia,
                Titre = sTitre,
                Synopsis = sSynopsis,
                DateSortie = DateMedia,
                Duree = dureeMedia,
                AgeMin = age,
                SupportNumerique = bSupportNumerique,
                SupportPhysique = bSupportPhysique,
                LangueVO = langVO,
                LangueMedia = langMedia,
                SousTitres = langssTitre,
                Vu = true,
                Note = 5,
                
            };
            DbService db = await DbService.getInstance();
            db.Medias.Add(newMedia);
            await db.SaveChangesAsync();
            MessageBox.Show("Le média de type " + typMedia + " a bien été enregisté" , "Success");
            return;

        }

        private void Init()
        {
            throw new NotImplementedException();
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
