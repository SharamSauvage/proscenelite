using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ProsceneLite.Data
{
    [Table("CalendriersMultiples")]
    public class CalendriersMultiples
    {
        #region Key(s)
        [Key]
        public Guid CalendrierId { get; set; }
        [Key]
        public Guid PaysContreeId { get; set; }
        #endregion

        #region Indexes
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        #endregion

        #region Champs

        #endregion

        #region ForeignKeys
        [ForeignKey(nameof(CalendrierId))]
        public virtual Calendrier Calendrier
        { get; set; }
        [ForeignKey(nameof(PaysContreeId))]
        public virtual PaysContree PaysContree
        { get; set; }
        #endregion


    }
}