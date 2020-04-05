using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ProsceneLite.Data
{
    [Table("Caracteristiques")]
    public class CaracteristiquesPJ
    {
        #region Key(s)
        [Key]
        public Guid PJId { get; set; }
        [Key]
        public Guid CaracId { get; set; }
        #endregion

        #region Indexes
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        #endregion


        #region Champs
        public string CaracVal { get; set; }
        #endregion

        #region ForeignKeys
        [ForeignKey(nameof(CaracId))]
        public virtual Caracteristiques Caracteristiques
        { get; set; }
        [ForeignKey(nameof(PJId))]
        public virtual PJ PJ
        { get; set; }
        #endregion


    }
}