using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ProsceneLite.Data
{
    [Table("TypoUnivers")]
    public class TyposUnivers
    {
        #region Key(s)
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        #endregion

        #region Champs
        public string TypeUnivers { get; set; }//médiéval-fantastique ; féérique; low-fantasy; steampunk; cyberpunk; postapo
        
        [InverseProperty(nameof(Univers.TyposUnivers))]
        public virtual ICollection<Univers> UniversLiés { get; set; }
        #endregion


    }
}