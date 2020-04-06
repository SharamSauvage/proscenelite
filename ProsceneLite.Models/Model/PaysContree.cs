using System;
using System.Collections.Generic;
using System.Text;

namespace ProsceneLite.Models
{
    
    public class PaysContree
    {
        #region Champs
        
        public Guid Id { get; set; }
        public Guid? UniversId { get; set; }
        public string Nom { get; set; }

        #endregion

        #region Constructeur
        public PaysContree() { }
        #endregion

        #region Methodes
        #endregion

    }
}