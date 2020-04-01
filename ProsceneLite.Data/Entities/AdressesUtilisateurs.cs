using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ProsceneLite.Data
{
    [Table("AdressesUtilisateurs")]
    public class AdressesUtilisateurs
    {
        #region Key(s)
        [Key]
        public Guid UtilisateurId { get; set; }
        [Key]
        public Guid AdresseId { get; set; }
        #endregion

        #region ForeignKeys
        [ForeignKey(nameof(AdresseId))]
        public virtual Adresse Adresse
        {
            get;
            set;
        }
        [ForeignKey(nameof(UtilisateurId))]
        public virtual Utilisateurs Utilisateurs
        {
            get;
            set;
        }
        #endregion
    }
}