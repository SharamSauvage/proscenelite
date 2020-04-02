using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ProsceneLite.Data
{
    [Table("RelationPJ")]
    public class RelationsPJ
    {
        #region Key(s)
        
        [Key]
        public Guid PJ1Id { get; set; }
        [Key]
        public Guid PJ2Id { get; set; }

        #endregion

        #region Indexes
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        #endregion

        #region Champs
        public int? NivRelation { get; set; }
        #endregion

        #region ForeignKeys
        [ForeignKey(nameof(PJ1Id))]
        public PJ PJ1
        { get; set; }
        [ForeignKey(nameof(PJ2Id))]
        public virtual PJ PJ2
        { get; set; }
        #endregion

        
    }
}