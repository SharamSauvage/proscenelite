using System;
using System.Collections.Generic;
using System.Text;

namespace ProsceneLite.Models
{
    public class ObjetsQuete
    {
        #region Champs
        public Guid Id { get; set; }
        public Guid? QueteId { get; set; }
        public string NomObjet { get; set; }
        public string PrezObjet { get; set; }
        public string SituationDebJeu { get; set; }
        public string Effet { get; set; }
        public Byte[] Image { get; set; }
        public Guid? PPLieId { get; set; }
        public StatuValid? StatuValidId { get; set; }
        public Guid? StockId { get; set; }
        public bool? ExisteDeja { get; set; }
        public bool? EstDisponible { get; set; }
        public bool? EstDemande { get; set; }
        public bool? DemandeResaOK { get; set; }

        #endregion

        #region Constructeur
        public ObjetsQuete() { }
        public ObjetsQuete(Guid pId, Guid? pQueteId, string pNomObj, string pPrez, string pSituDebJeu, string pEffet,
            Byte[] pImg, Guid? pPPLieId, int? pStatValid, Guid? pStockId, bool pExiste, bool pEstDispo, bool pEstDem, bool pDemRezOk) 
        {
            Id = pId;
            QueteId = pQueteId;
            NomObjet = pNomObj;
            PrezObjet = pPrez;
            SituationDebJeu = pSituDebJeu;
            Effet = pEffet;
            Image = pImg;
            PPLieId = pPPLieId;
            StockId = pStockId;
            ExisteDeja = pExiste;
            EstDisponible = pEstDispo;
            EstDemande= pEstDem;
            DemandeResaOK = pDemRezOk;
            StatuValidId = pStatValid switch
            {
                0 => StatuValid.redact,
                1 => StatuValid.relecture,
                2 => StatuValid.validation,
                3 => StatuValid.validé,
                _ => StatuValid.redact,
            };
        }
        #endregion

        #region Methodes
        #endregion


    }
}