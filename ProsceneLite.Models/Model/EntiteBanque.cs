using System;
using System.Collections.Generic;
using System.Text;

namespace ProsceneLite.Models
{
    
    public class EntiteBanque
    {
        #region Champs

        public Guid EntiteId { get; set; }

        public TypoBanque TypoBk { get; set; }

        public string Compte { get; set; }
        public virtual Entite Entite
        { get; set; }
        #endregion
        #region Constructeur
        public EntiteBanque()
        {

        }
        #endregion
        #region Méthodes
        #endregion
    }
}