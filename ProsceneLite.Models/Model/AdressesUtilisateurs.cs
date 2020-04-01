using System;
using System.Collections.Generic;
using System.Text;

namespace ProsceneLite.Models
{
    public class AdressesUtilisateurs
    {
        #region Champs
        public Guid UtilisateurId { get; set; }
        public Guid AdresseId { get; set; }

        public virtual Adresse Adresse
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
        public AdressesUtilisateurs()
        {

        }
        #endregion

        #region Methodes
        #endregion
    }
}