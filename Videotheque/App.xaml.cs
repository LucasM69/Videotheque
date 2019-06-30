﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows;
using Videotheque.DataAccess;
using Videotheque.enums;
using Videotheque.Model;

namespace Videotheque
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        protected override async void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            DbService db = await DbService.getInstance();
            /*Media media = new Media
            { 
                AgeMin = 25,
                Commentaire = "Jak sie masz",
                DateSortie = DateTime.Now,
                Duree = TimeSpan.FromHours(1.26),
                Image = "test",
                LangueMedia = Langue.FRANCAIS,
                LangueVO = Langue.ANGLAIS,
                Note = 5,
                SousTitres = Langue.FRANCAIS,
                SupportNumerique = true,
                SupportPhysique = true,
                Synopsis = "Pour le compte du ministère de l'Information du Kazakhstan, Borat Sagdiyev, reporter, et Azamat Bagatov, producteur, débarquent aux États-Unis - pays qu'ils vénèrent - pour mener une enquête sur le mode de vie des Américains.",
                Titre = "Borat",
                TypeMedia = TypeMedia.SERIE,
                Vu = true
            };
            db.Medias.Add(media);
            await db.SaveChangesAsync(); 
            //var tmp = db.Medias.Find();
            List<Media> nbMedia = db.Medias.OrderBy(o => o.Titre).ToList();
            //Debug.WriteLine(db.Medias.Find());
            var tmp = nbMedia.Count();
            Debug.WriteLine(tmp);*/
  
        }
    }
}