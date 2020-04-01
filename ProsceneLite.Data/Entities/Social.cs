using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ProsceneLite.Data
{
    [Table("Social")]
    public class Social
    {
        #region Key(s)
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        #endregion

        #region Champs
        public Guid UserId { get; set; }
        public Guid ContactId { get; set; }
        public int StatutDemContact { get; set; }
        public int StatutContact { get; set; }
        #endregion

        #region ForeignKeys
        [ForeignKey(nameof(UserId))]
        public virtual Utilisateurs Utilisateurs
        { get; set; }
        [ForeignKey(nameof(ContactId))]
        public virtual Utilisateurs Contact
        { get; set; }
        #endregion
        
    }
}