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
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        #endregion

        #region Champs
        public Guid PJId { get; set; }
        public Guid MoisId { get; set; }
        public int Annee { get; set; }

        public string DescrpFaits { get; set; }

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