using System;
using System.Collections.Generic;
using System.Text;

namespace ProsceneLite.Models
{
    
    public class Competences
    {
        #region Champs
        public Guid Id { get; set; }

        public Guid? UniversId { get; set; }
        public string NomCompetence { get; set; }
        public bool EstNumerique { get; set; }

        #endregion

        #region Constructeur
        public Competences() { }
        #endregion

        #region Methodes
        #endregion
    }
}