using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ProsceneLite.Data
{
    [Table("PartisPJ")]
    public class PartisPJ
    {
        #region Key(s)
        [Key]
        public Guid PJId { get; set; }
        [Key]
        public Guid PartiId { get; set; }
        #endregion

        #region Indexes
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        #endregion

        #region Champs
        public string Description { get; set; }

        [InverseProperty(nameof(PartisPJ_BG.PartisPJ))]
        public virtual ICollection<PartisPJ_BG> LPartisPJ_BG { get; set; }

        #endregion

        #region ForeignKeys
        [ForeignKey(nameof(PartiId))]
        public virtual PartisQuete PartisQuete
        { get; set; }
        [ForeignKey(nameof(PJId))]
        public virtual PJ PJ
        { get; set; }
        #endregion

        
    }
}