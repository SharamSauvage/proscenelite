using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ProsceneLite.Data
{
    [Table("Quete")]
    public class Quete
    {
        #region Key(s)
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        #endregion

        #region Champs
        [Required]
        public string TitreQuete { get; set; }
        public Guid? ReferentId { get; set; }
        public int? StatuValidId { get; set; }
        public Guid? TypoQueteId { get; set; }
        public Guid? ProjetId { get; set; }

        [InverseProperty(nameof(PlotPointsQuete.Quete))]
        public virtual ICollection<Quete> LPlotPoint { get; set; }
        [InverseProperty(nameof(PlotPointsQuete.Quete1))]
        public virtual ICollection<Quete> LPPParent { get; set; }
        [InverseProperty(nameof(Scene.Quete))]
        public virtual ICollection<Quete> LScene { get; set; }
        [InverseProperty(nameof(PartisQuete.Quete))]
        public virtual ICollection<Quete> LPartis { get; set; }
        [InverseProperty(nameof(ObjetsQuete.Quete))]
        public virtual ICollection<Quete> LObjets { get; set; }
        #endregion

        #region ForeignKeys
        [ForeignKey(nameof(ReferentId))]
        public Utilisateurs Utilisateurs
        {
            get;
            set;
        }
        [ForeignKey(nameof(TypoQueteId))]
        public TypoQuete TypoQuete
        {
            get;
            set;
        }
        
        [ForeignKey(nameof(ProjetId))]
        public virtual Projet Projet
        { get; set; }
        #endregion

    }
}