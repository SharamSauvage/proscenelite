using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ProsceneLite.Data
{
    [Table("BgPJ")]
    public class BgPJ
    {
        #region Key(s)
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        #endregion

        #region Indexes
        public Guid PJId { get; set; }
        public int Ordre { get; set; }
        #endregion

        #region Champs
        
        public Guid? PersoBgId { get; set; }
        public Guid? RelationBgId { get; set; }
        public Guid? PartisBgId { get; set; }
        public Guid? ChronoPJId { get; set; }
        
        #endregion

        #region ForeignKeys
        [ForeignKey(nameof(PartisBgId))]
        public virtual PartisPJ_BG PartisPJ_BG
        { get; set; }
        [ForeignKey(nameof(PersoBgId))]
        public virtual PersoPJ_BG PersoPJ_BG
        { get; set; }
        [ForeignKey(nameof(RelationBgId))]
        public virtual RelationsPJ_BG RelationsPJ_BG
        { get; set; }
        [ForeignKey(nameof(PJId))]
        public virtual PJ PJ
        { get; set; }
        [ForeignKey(nameof(ChronoPJId))]
        public virtual ChronoPJ ChronoPJ
        { get; set; }
        #endregion

        
    }
}