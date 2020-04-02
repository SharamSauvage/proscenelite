using System;
using System.Collections.Generic;
using System.Text;

namespace ProsceneLite.Models
{
    public class Calendrier
    {
        #region Champs
        public Guid Id { get; set; }

        public Guid? UniversId { get; set; }
        public int NbMois { get; set; }
        public int NbJoursAnnée { get; set; }

        #endregion

        #region Constructeur
        public Calendrier() { }
        #endregion

        #region Methodes
        #endregion
    }
}