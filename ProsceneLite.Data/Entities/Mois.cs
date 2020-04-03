using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ProsceneLite.Data
{
    [Table("Mois")]
    public class Mois
    {
        #region Key(s)
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        #endregion

        #region Champs
        public Guid? CalendrierId { get; set; }
        public string NomMois { get; set; }
        public int NbJours { get; set; }

        [InverseProperty(nameof(ChronoPJ.Mois))]
        public virtual ICollection<ChronoPJ> LChronoPJ { get; set; }
        #endregion

        #region ForeignKeys
        [ForeignKey(nameof(CalendrierId))]
        public virtual Calendrier Calendrier
        { get; set; }
        #endregion

        
    }
}