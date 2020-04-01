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

        public virtual Quete Quete
        { get; set; }

        public virtual Spots Spots
        { get; set; }
        #endregion


        #region Constructeur
        public Scene() { }
        #endregion

        #region Methodes
        #endregion


    }
}