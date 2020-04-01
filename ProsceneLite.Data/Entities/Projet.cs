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

        [InverseProperty(nameof(Inscrits.Projet))]
        public virtual ICollection<Projet> LProjetsInscrits { get; set; }
        [InverseProperty(nameof(ProjetsUtilisateurs.Projet))]
        public virtual ICollection<Projet> LProjetUtilisateurs { get; set; }
        [InverseProperty(nameof(Quete.Projet))]
        public virtual ICollection<Projet> LProjetQuetes { get; set; }
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