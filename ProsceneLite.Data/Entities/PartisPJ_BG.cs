using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ProsceneLite.Data
{
    [Table("PartisPJ_BG")]
    public class PartisPJ_BG
    {
        #region Key(s)
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        #endregion

        #region Champs
        public Guid? PartisPJId { get; set; }
        public int Version { get; set; }
        public string TitreBg { get; set; }
        public string BG_Corps { get; set; }

        [InverseProperty(nameof(BgPJ.PartisPJ_BG))]
        public virtual ICollection<BgPJ> LBgPJ { get; set; }

        #endregion

        #region ForeignKeys
        [ForeignKey(nameof(PartisPJId))]
        public virtual PartisPJ PartisPJ
        { get; set; }
        #endregion


    }
}