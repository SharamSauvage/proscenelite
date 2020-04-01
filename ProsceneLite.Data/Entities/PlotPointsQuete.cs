using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ProsceneLite.Data
{
    [Table("PlotPointsQuete")]
    public class PlotPointsQuete
    {
        #region Key(s)
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        #endregion

        #region Champs
        public string NomPlotPoint { get; set; }
        public string DescrptPP { get; set; }
        public bool EstBorneTemps { get; set; }
        public DateTime DateDebut { get; set; }
        public DateTime DateFin { get; set; }
        /// <summary>
        /// détermine si ce PP est l'enfant d'un autre (en OUI/NON)
        /// </summary>
        public bool EstLiéPP { get; set; }
        /// <summary>
        /// détermine si ce PP est l'enfant d'un autre PP d'une autre Quete (en OUI/NON)
        /// </summary>
        public bool EstLiéQuete { get; set; }
        /// <summary>
        /// ssi un PP est uniquement à destination d'1 parti.
        /// </summary>
        public bool EstLiéParti { get; set; }
        /// <summary>
        /// //indique à quelle quête CE PP appartient
        /// </summary>
        public Guid? QueteId { get; set; }
        /// <summary>
        /// indique l'Id du PP Parent (dans la Quete ou hors Quete)
        /// </summary>
        public Guid? ParentPPId { get; set; }
        /// <summary>
        ///indique la quête dans laquelle le PP Parent est référencé(ssi EstLiéQuete = True) 
        /// </summary>
        public Guid? ParentPPQueteId { get; set; }
        /// <summary>
        /// si le PP est lié à un seul parti (Pro ou Anti) de la quete permet d'indiquer lequel
        /// </summary>
        public Guid? PartiId { get; set; }

        [InverseProperty(nameof(PlotPointsQuete.PlotPointsQuete1))]
        public virtual ICollection<PlotPointsQuete> LPPEnfants { get; set; }
        [InverseProperty(nameof(ObjetsQuete.PlotPointsQuete))]
        public virtual ICollection<PlotPointsQuete> LObjets { get; set; }

        #endregion

        #region ForeignKeys
        [ForeignKey(nameof(PartiId))]
        public virtual PartisQuete PartisQuete
        { get; set; }
        [ForeignKey(nameof(QueteId))]
        public virtual Quete Quete
        { get; set; }
        [ForeignKey(nameof(ParentPPQueteId))]
        public virtual Quete Quete1
        { get; set; }
        [ForeignKey(nameof(ParentPPId))]
        public virtual PlotPointsQuete PlotPointsQuete1
        { get; set; }
        #endregion

        
    }
}