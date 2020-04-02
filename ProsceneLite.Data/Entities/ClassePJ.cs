using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;


namespace ProsceneLite.Data
{
    [Table("ClassePJ")]
    public class ClassePJ
    {
        #region Key(s)
        [Key]
        public Guid PJId { get; set; }
        [Key]
        public Guid ClasseId { get; set; }
        #endregion

        #region Champs
        #endregion

        #region ForeignKeys
        [ForeignKey(nameof(ClasseId))]
        public virtual ClasseMetier ClasseMetier
        { get; set; }
        [ForeignKey(nameof(PJId))]
        public virtual PJ PJ
        { get; set; }
        #endregion


    }
}