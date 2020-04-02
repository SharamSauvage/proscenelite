using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ProsceneLite.Data
{
    [Table("Calendrier")]
    public class Calendrier
    {
        #region Key(s)
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        #endregion

        #region Champs
        public Guid? UniversId { get; set; }
        public int NbMois { get; set; }
        public int NbJoursAnnée { get; set; }

        [InverseProperty(nameof(Mois.Calendrier))]
        public virtual ICollection<Mois> LMois { get; set; }
        [InverseProperty(nameof(CalendriersMultiples.Calendrier))]
        public virtual ICollection<CalendriersMultiples> LCalendMult { get; set; }
        #endregion

        #region ForeignKeys
        [ForeignKey(nameof(UniversId))]
        public virtual Univers Univers
        { get; set; }
        #endregion

        
    }
}