using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ProsceneLite.Models
{
    public class ProjetsUtilisateurs
    {
        #region Champs
        
        public Guid ProjetId { get; set; }
        
        public Guid UtilisateurId { get; set; }
        public virtual Projet Projet
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
        public ProjetsUtilisateurs() { }
        #endregion

        #region Methodes
        #endregion

    }
}