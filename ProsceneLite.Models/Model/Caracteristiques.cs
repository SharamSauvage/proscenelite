using System;
using System.Collections.Generic;
using System.Text;

namespace ProsceneLite.Models
{
    public class Caracteristiques
    {
        #region Champs
        public Guid Id { get; set; }

        public Guid? UniversId { get; set; }
        public string NomCarac { get; set; }

        #endregion

        #region Constructeur
        public Caracteristiques() { }
        #endregion

        #region Methodes
        #endregion
    }
}