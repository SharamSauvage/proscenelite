using System;
using System.Collections.Generic;
using System.Text;

namespace ProsceneLite.Models
{
    public class Social
    {
        #region Champs
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public Guid ContactId { get; set; }
        public StatuDemContact StatutDemContact { get; set; }
        public StatuContact StatutContact { get; set; }
        public virtual Utilisateurs Utilisateurs
        { get; set; }
        public virtual Utilisateurs Contact
        { get; set; }
        #endregion

        #region Constructeur
        public Social() { }
        #endregion

        #region Methodes
        #endregion
    }
}
