using System;
using System.Collections.Generic;
using System.Text;

namespace ProsceneLite.Models
{
    
    public class Organisations
    {
        #region Champs
        
        public Guid Id { get; set; }
        
        public Guid? UniversId { get; set; }
        public string NomOrganisation { get; set; }
        
        #endregion

        #region Constructeur
        public Organisations() { }
        #endregion

        #region Methodes
        #endregion
    }
}