using System;
using System.Collections.Generic;
using System.Text;

namespace ProsceneLite.Models
{
    public class PJ
    {
        #region Champs
        
        public Guid Id { get; set; }
        public string NomPJ { get; set; }
        public string DdNPJ { get; set; }
        public Guid? ArchetypeId { get; set; } 
        public string Synopsis { get; set; }
        public Guid? JoueurID { get; set; }

        #endregion

        #region Constructeur
        public PJ() { }
        #endregion

        #region Methodes
        #endregion

    }
}