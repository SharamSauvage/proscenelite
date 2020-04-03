using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ProsceneLite.Data
{
    [Table("PJ")]
    public class PJ
    {
        #region Key(s)
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        #endregion

        #region Champs
        public string NomPJ { get; set; }
        public string DdNPJ { get; set; } //dans l'univers d'où le stockage en string
        
        public string Synopsis { get; set; }

        //il faut une table pour les Objets de jeu, et une pour les Docs de Jeu ET une dernière pour le BG
        public Guid? ArchetypeId { get; set; } 
        public Guid? JoueurID { get; set; }
        public Guid? ReligId { get; set; }
        public Guid? OrgaId { get; set;}
        public Guid? RaceId { get; set; }
        public Guid? AlignId { get; set; }
        public Guid? PaysId { get; set; }
        

        [InverseProperty(nameof(PartisPJ.PJ))]
        public virtual ICollection<PartisPJ> LPJPartis { get; set; }
        [InverseProperty(nameof(CompetencesPJ.PJ))]
        public virtual ICollection<CompetencesPJ> LComp { get; set; }
        [InverseProperty(nameof(CaracteristiquesPJ.PJ))]
        public virtual ICollection<CaracteristiquesPJ> LCarac { get; set; }
        [InverseProperty(nameof(ClassePJ.PJ))]
        public virtual ICollection<ClassePJ> LClasses { get; set; }
        [InverseProperty(nameof(PersoPJ_BG.PJ))]
        public virtual ICollection<PersoPJ_BG> LPerso_BG { get; set; }
        [InverseProperty(nameof(BgPJ.PJ))]
        public virtual ICollection<BgPJ> LBgPJ { get; set; }
        [InverseProperty(nameof(ChronoPJ.PJ))]
        public virtual ICollection<ChronoPJ> LChronoPJ { get; set; }
        #endregion

        #region ForeignKeys
        [ForeignKey(nameof(JoueurID))]
        public virtual Inscrits Inscrits
        { get; set; }
        [ForeignKey(nameof(ArchetypeId))]
        public virtual Archetype Archetype
        { get; set; }
        [ForeignKey(nameof(AlignId))]
        public virtual Alignement Alignement
        { get; set; }
        [ForeignKey(nameof(ReligId))]
        public virtual Religion Religion
        { get; set; }
        [ForeignKey(nameof(OrgaId))]
        public virtual Organisations Organisations
        { get; set; }
        [ForeignKey(nameof(PaysId))]
        public virtual PaysContree PaysContree
        { get; set; }
        [ForeignKey(nameof(RaceId))]
        public virtual Race Race
        { get; set; }
        #endregion
        
    }
}