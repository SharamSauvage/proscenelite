using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ProsceneLite.Data
{
    [Table("ObjetsQuete")]
    public class ObjetsQuete
    {
        #region Key(s)
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        #endregion

        #region Champs
        public Guid QueteId { get; set; }
        public string NomObjet { get; set; }
        public string PrezObjet { get; set; }
        public string SituationDebJeu { get; set; }
        public string Effet { get; set; }
        public Byte[] Image { get; set; }
        public Guid PPLieId { get; set; }
        public Guid StatuValidId { get; set; }
        public Guid StockId { get; set; }
        public bool? ExisteDeja { get; set; }
        public bool? EstDisponible { get; set; }
        public bool? EstDemande { get; set; }
        public bool? DemandeResaOK { get; set; }
        #endregion

        #region ForeignKeys
        [ForeignKey(nameof(QueteId))]
        public virtual Quete Quete
        {get;set;}
        [ForeignKey(nameof(PPLieId))]
        public virtual PlotPointsQuete PlotPointsQuete
        { get; set; }
        [ForeignKey(nameof(StatuValidId))]
        public virtual StatutValidation StatutValidation
        { get; set; }
        [ForeignKey(nameof(StockId))]
        public virtual StockEntrepot StockEntrepot
        { get; set; }
        #endregion

        
    }
}