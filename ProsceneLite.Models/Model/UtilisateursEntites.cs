using System;
using System.Collections.Generic;
using System.Text;

namespace ProsceneLite.Models
{
    
    public class UtilisateursEntites
    {
        #region Champs
        
        public Guid UtilisateurId { get; set; }
        
        public Guid EntiteId { get; set; }
        
        public bool EstPermanent { get; set; }
        
        public virtual Entite Entite
        {
            get;
            set;
        }
        
        public virtual Utilisateurs Utilisateurs
        {
            get;
            set;
        }
        #endregion

        #region Constructeur
        public UtilisateursEntites() { }
        #endregion

        #region Methodes
        #endregion

    }
}