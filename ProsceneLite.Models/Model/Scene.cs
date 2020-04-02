using System;
using System.Collections.Generic;
using System.Text;

namespace ProsceneLite.Models
{
    
    public class Scene
    {
        #region Champs

        public Guid Id { get; set; }
        public DateTime DateDebut { get; set; }
        public DateTime DateFin { get; set; }
        public Guid QueteId { get; set; }
        public Guid SpotId { get; set; }

        public string DescriptionScene { get; set; }

        #endregion


        #region Constructeur
        public Scene() { }
        public Scene(Guid pId, DateTime pDeb, DateTime pFin, Guid pQuete, Guid pSpot, string pDescpt)
        {
            Id = pId;
            DateDebut = pDeb;
            DateFin = pFin;
            QueteId = pQuete;
            SpotId = pSpot;
            DescriptionScene = pDescpt;
        }
        #endregion

        #region Methodes
        #endregion


    }
}