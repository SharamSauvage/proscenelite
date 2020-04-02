using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ProsceneLite.Data
{
    [Table("Alignement")]
    public class Alignement
    {
        #region Key(s)
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        #endregion

        #region Champs
        public Guid? UniversId { get; set; }
        public string NomAlignement { get; set; }

        [InverseProperty(nameof(PJ.Alignement))]
        public virtual ICollection<PJ> LPJ { get; set; }

        #endregion

        #region ForeignKeys
        [ForeignKey(nameof(UniversId))]
        public virtual Univers Univers
        { get; set; }
        #endregion


    }
}