using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ProsceneLite.Models
{
    public class Projet
    {
        #region Key(s)
        public Guid Id { get; set; }

        public string Nom { get; set; }
        public Guid? UniversId { get; set; }
        public int? TypoStockageId { get; set; }
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
        public bool NbCouchages { get; set; }
        public int? TypoInscriptions { get; set; } //Enum
        public Guid? TerrainId { get; set; }

        public virtual Univers Univers
        { get; set; }
        
        public virtual Terrains Terrains
        { get; set; }
        #endregion

        #region Constructeur
        public Projet() { }
        #endregion

        #region Methodes
        #endregion



    }
}