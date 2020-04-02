using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ProsceneLite.Data
{
    [Table("Archetype")]
    public class Archetype
    {
        #region Key(s)
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        #endregion

        #region Champs
        public string NomArchetype { get; set; }
        public string Description { get; set; }
        public Guid? UniversId { get; set; }

        [InverseProperty(nameof(PJ.Archetype))]
        public virtual ICollection<PJ> LPJ { get; set; }

        #endregion

        #region ForeignKeys
        [ForeignKey(nameof(UniversId))]
        public virtual Univers Univers
        { get; set; }
        #endregion

        
    }
}