using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ProsceneLite.Models
{
    public class Projet
    {
        #region Champs
        public Guid Id { get; set; }
        public string Nom { get; set; }
        public Guid? UniversId { get; set; }
        public TypoStockage? TypoStockageId { get; set; }
        public DateTime DateDébutJeu { get; set; }
        public DateTime DateFinJeu { get; set; }
        public DateTime DateDebutInstal { get; set; }
        public DateTime DateFinRangement { get; set; }
        public int NbPJ { get; set; }
        public int NbPNJ { get; set; }
        public int NbOrgas { get; set; }
        public double PrxPJ { get; set; }
        public double PrxPNJ { get; set; }
        public double PrxOrga { get; set; }
        public bool RepasInclus { get; set; }
        public bool CouchagesInclus { get; set; }
        public int NbCouchages { get; set; }
        public TypoInscription? TypoInscriptions { get; set; }
        public Guid? TerrainId { get; set; }


        #endregion

        #region Constructeur
        public Projet() { }
        public Projet(Guid pId, string pNom, Guid? pUniv, int? pTypoStck, DateTime pDebJeu, DateTime pFinJeu, DateTime pDebInst, DateTime pFinRang,
            int pNbPJ, int pNbPNJ, int pNbOrg, double pPxPJ, double pPxPNJ, double pPxOrg, bool pRepas, bool pCouch, int pNbCouch, int?pTypoInscptn, Guid? pTerrainId)
        {
            Id = pId;
            Nom = pNom;
            UniversId = pUniv;
            DateDébutJeu = pDebJeu;
            DateFinJeu = pFinJeu;
            DateDebutInstal = pDebInst;
            DateFinRangement = pFinRang;
            NbPJ = pNbPJ;
            NbPNJ = pNbPNJ;
            NbOrgas = pNbOrg;
            PrxPJ = pPxPJ;
            PrxPNJ = pPxPNJ;
            PrxOrga = pPxOrg;
            RepasInclus = pRepas;
            CouchagesInclus = pCouch;
            NbCouchages = pNbCouch;
            TerrainId = pTerrainId;
            TypoStockageId = pTypoStck switch
            {
                0 => TypoStockage.Distribue,
                1 => TypoStockage.Centralise,
                2 => TypoStockage.Mixte,
                _ => TypoStockage.Distribue,
            };
            TypoInscriptions = pTypoInscptn switch
            {
                0 => TypoInscription.Invitation,
                1 => TypoInscription.Publique,
                2 => TypoInscription.Mixte,
                _ => TypoInscription.Publique,
            };
        }
        #endregion

        #region Methodes
        #endregion



    }
}