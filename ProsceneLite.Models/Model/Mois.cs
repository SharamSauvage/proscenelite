using System;
using System.Collections.Generic;
using System.Text;

namespace ProsceneLite.Models
{
    
    public class Mois
    {
        #region Champs

        public Guid Id { get; set; }
        public Guid? CalendrierId { get; set; }
        public string NomMois { get; set; }
        public int NbJours { get; set; }

        #endregion

        #region Constructeur
        public Mois() { }
        #endregion

        #region Methodes
        #endregion
    }
}