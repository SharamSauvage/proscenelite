using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ProsceneLite.Data
{
    [Table("ProjetsUtilisateurs")]
    public class ProjetsUtilisateurs
    {
        #region Key(s)
        [Key]
        public Guid ProjetId { get; set; }
        
        [Key]
        public Guid UtilisateurId { get; set; }
        #endregion

        #region ForeignKeys
        [ForeignKey(nameof(ProjetId))]
        public virtual Projet Projet
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