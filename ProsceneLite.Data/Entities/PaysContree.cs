using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ProsceneLite.Data
{
    [Table("PaysContree")]
    public class PaysContree
    {
        #region Key(s)
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        #endregion

        #region Champs
        public Guid? UniversId { get; set; }
        public string Nom { get; set; }

        [InverseProperty(nameof(CalendriersMultiples.PaysContree))]
        public virtual ICollection<CalendriersMultiples> LCalend { get; set; }

        [InverseProperty(nameof(PJ.PaysContree))]
        public virtual ICollection<PJ> LPJ { get; set; }

        #endregion

        #region ForeignKeys
        [ForeignKey(nameof(UniversId))]
        public virtual Univers Univers
        { get; set; }
        #endregion


    }
}