using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ProsceneLite.Data
{
    [Table("Projet")]
    public class Projet
    {
        #region Key(s)
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        #endregion

        #region Champs
        public string Nom { get; set; }
        public Guid? UniversId { get; set; }
        public int? TypoStockageId { get; set; } //Enum  : centralisé ou mixte il faut stocker l'adresse et user/mdp
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
        public int? TypoInscriptions { get; set; } //Enum
        public Guid? TerrainId { get; set; }

        [InverseProperty(nameof(Inscrits.Projet))]
        public virtual ICollection<Inscrits> LProjetsInscrits { get; set; }
        [InverseProperty(nameof(ProjetsUtilisateurs.Projet))]
        public virtual ICollection<ProjetsUtilisateurs> LProjetUtilisateurs { get; set; }
        [InverseProperty(nameof(Quete.Projet))]
        public virtual ICollection<Quete> LProjetQuetes { get; set; }
        #endregion

        #region ForeignKeys

        [ForeignKey(nameof(UniversId))]
        public virtual Univers Univers
        { get; set; }
        
        [ForeignKey(nameof(TerrainId))]
        public virtual Terrains Terrains
        { get; set; }
        #endregion


    }
}