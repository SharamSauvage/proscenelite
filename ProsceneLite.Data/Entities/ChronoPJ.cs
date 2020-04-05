using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ProsceneLite.Data
{
    [Table("ChronoPJ")]
    public class ChronoPJ
    {
        #region Key(s)
        [Key]
        public Guid PJId { get; set; }
        [Key]
        public Guid MoisId { get; set; }
        [Key]
        public int Annee { get; set; }

        #endregion

        #region Indexes
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        #endregion


        #region Champs
        public string DescrpFaits { get; set; }

        [InverseProperty(nameof(BgPJ.ChronoPJ))]
        public virtual ICollection<BgPJ> LBgPJ { get; set; }

        #endregion

        #region ForeignKeys
        [ForeignKey(nameof(PJId))]
        public virtual PJ PJ
        { get; set; }
        [ForeignKey(nameof(MoisId))]
        public virtual Mois Mois
        { get; set; }
        #endregion


    }
}