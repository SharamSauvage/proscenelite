using System;
using System.Collections.Generic;
using System.Text;

namespace ProsceneLite.Models
{
    public class ClasseMetier
    {
        #region Champs

        public Guid Id { get; set; }

        public Guid? UniversId { get; set; }
        public string NomClasse { get; set; }
        
        #endregion

        #region Constructeur
        public ClasseMetier() { }
        #endregion

        #region Methodes
        #endregion
    }
}