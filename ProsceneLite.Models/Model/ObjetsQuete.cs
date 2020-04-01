using System;
using System.Collections.Generic;
using System.Text;

namespace ProsceneLite.Models
{
    public class ObjetsQuete
    {
        #region Key(s)
        public Guid Id { get; set; }
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
        public virtual Quete Quete
        {get;set;}
        public virtual PlotPointsQuete PlotPointsQuete
        { get; set; }
        public virtual StatutValidation StatutValidation
        { get; set; }
        public virtual StockEntrepot StockEntrepot
        { get; set; }
        #endregion

        #region Constructeur
        public ObjetsQuete() { }
        #endregion

        #region Methodes
        #endregion


    }
}