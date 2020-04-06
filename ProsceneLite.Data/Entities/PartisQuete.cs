using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ProsceneLite.Data
{
    [Table("PartisQuete")]
    public class PartisQuete
    {
        #region Key(s)
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        #endregion

        #region Champs
        public Guid? QueteId { get; set; }
        public string NomParti { get; set; }
        public string Synopsis { get; set; }
        public string But { get; set; }
        public DateTime DebutEnJeu { get; set; }
        public DateTime FinEnJeu { get; set; }

        [InverseProperty(nameof(PlotPointsQuete.PartisQuete))]
        public virtual ICollection<PlotPointsQuete> LPlotPointPartis { get; set; }
        [InverseProperty(nameof(PartisPJ.PartisQuete))]
        public virtual ICollection<PartisPJ> LPartisPJ { get; set; }

        #endregion

        #region ForeignKeys
        [ForeignKey(nameof(QueteId))]
        public virtual Quete Quete
        { get; set; }
        #endregion

        
    }
}