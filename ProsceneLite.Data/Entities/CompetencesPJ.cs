using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ProsceneLite.Data
{
    [Table("CompetencesPJ")]
    public class CompetencesPJ
    {
        #region Key(s)
        [Key]
        public Guid PJId { get; set; }
        [Key]
        public Guid CompetenceId { get; set; }
        #endregion

        #region Champs
        public string CompVal { get; set; }
        #endregion

        #region ForeignKeys
        [ForeignKey(nameof(CompetenceId))]
        public virtual Competences Competences
        { get; set; }
        [ForeignKey(nameof(PJId))]
        public virtual PJ PJ
        { get; set; }
        #endregion

    }
}