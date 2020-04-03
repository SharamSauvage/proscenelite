using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ProsceneLite.Data
{
    [Table("RelationsPJ_BG")]
    public class RelationsPJ_BG
    {
        #region Key(s)
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        #endregion

        #region Champs
        public Guid? RelationId { get; set; }
        public int Version { get; set; }
        public string TitreBg { get; set; }
        public string BG_Corps { get; set; }

        [InverseProperty(nameof(BgPJ.RelationsPJ_BG))]
        public virtual ICollection<BgPJ> LBgPJ { get; set; }
        #endregion

        #region ForeignKeys
        [ForeignKey(nameof(RelationId))]
        public virtual RelationsPJ RelationsPJ
        { get; set; }
        #endregion


    }
}