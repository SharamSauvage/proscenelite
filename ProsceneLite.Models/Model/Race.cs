using System;
using System.Collections.Generic;
using System.Text;

namespace ProsceneLite.Models
{
    
    public class Race
    {
        #region Champs

        public Guid Id { get; set; }

        public Guid? UniversId { get; set; }
        public string NomRace { get; set; }
        #endregion

        #region Constructeur
        public Race() { }
        #endregion

        #region Methodes
        #endregion


    }
}