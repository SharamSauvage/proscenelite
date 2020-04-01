using System;
using System.Collections.Generic;
using System.Text;

namespace ProsceneLite.Models
{
    public class AdressesEntites
    {
        #region Champs

        public Guid EntiteId { get; set; }

        public Guid AdresseId { get; set; }

        public virtual Adresse Adresse
        {
            get;
            set;
        }

        public virtual Entite Entite
        {
            get;
            set;
        }
        #endregion

        #region Constructeur
        public AdressesEntites()
        {

        }
        #endregion

        #region Methodes
        #endregion
    }
}