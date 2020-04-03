using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ProsceneLite.Data
{
    [Table("PersoPJ_BG")]
    public class PersoPJ_BG
    {
        #region Key(s)
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        #endregion

        #region Champs
        public Guid? PJId { get; set; }
        public int Version { get; set; }
        public string TitreBg { get; set; }
        public string BG_Corps { get; set; }

        [InverseProperty(nameof(BgPJ.PersoPJ_BG))]
        public virtual ICollection<BgPJ> LBgPJ { get; set; }

        #endregion

        #region ForeignKeys
        [ForeignKey(nameof(PJId))]
        public virtual PJ PJ
        { get; set; }
        #endregion


    }
}