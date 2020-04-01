using System;
using System.Collections.Generic;
using System.Text;

namespace ProsceneLite.Models
{
    public class Adresse
    {
        #region Champs

        public Guid Id { get; set; }

        public int Num { get; set; }
        
        public Guid? Voie { get; set; }
        
        public string NomVoie { get; set; }
        public string CodePostal { get; set; }
        public string Ville { get; set; }
        public string Region { get; set; }
        
        public Guid? Pays { get; set; }

        public virtual Pays Pays1
        {
            get;
            set;
        }

        public virtual Voies Voies
        {
            get;
            set;
        }
        #endregion

        #region Constructeur
        public Adresse() 
        {

        }
        #endregion
        #region Methodes
        #endregion
    }
}