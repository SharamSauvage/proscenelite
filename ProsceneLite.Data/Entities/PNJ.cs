using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ProsceneLite.Data
{
    [Table ("PNJ")]
    public class PNJ
    {
        #region Key(s)
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        #endregion

        #region Champs
        public string NomPNJ { get; set; }
        public string DescrptPNJ { get; set; }
        public string DescrptCostume { get; set; }
        public string DescrptAttitude { get; set; }

        [InverseProperty(nameof(PNJScene.PNJ))]
        public virtual ICollection<PNJ> LScene { get; set; }
        #endregion

        #region ForeignKeys
        //[ForeignKey(nameof(nomDuChampDansCetteClasse))]
        #endregion
    }
}