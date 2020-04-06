using System;
using System.Collections.Generic;
using System.Text;

namespace ProsceneLite.Models
{
    
    public class Religion
    {
        #region Champs
        
        public Guid Id { get; set; }
        public Guid? UniversId { get; set; }
        public string NomReligion { get; set; }

        #endregion

        #region Constructeur
        public Religion() { }
        #endregion

        #region Methodes
        #endregion


    }
}