using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;


namespace ProsceneLite.Data
{
    [Table("Univers")]
    public class Univers
    {
        
        #region Key(s)
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        #endregion
        #region Champs
        public string NomUnivers { get; set; }
        public Guid? TypoUniversId { get; set; }

        public Guid? ReferentId { get; set; }
        public bool partageprojet { get; set; } // uniquement accessible aux collaborateurs du projet (sinon ils ne vont rien pouvoir faire
        public bool partagesocial { get; set; } // accessible uniquement aux contacts du référent
        public bool partagepublic { get; set; } // accessible à tous les utilisateurs de Proscene
        
        [InverseProperty(nameof(Projet.Univers))]
        public virtual ICollection<Projet> LProjets { get; set; }
        [InverseProperty(nameof(Archetype.Univers))]
        public virtual ICollection<Archetype> LArchetypes { get; set; }

        [InverseProperty(nameof(Caracteristiques.Univers))]
        public virtual ICollection<Caracteristiques> LCarac { get; set; }
        [InverseProperty(nameof(Religion.Univers))] 
        public virtual ICollection<Religion> LRelig { get; set; }
        [InverseProperty(nameof(Organisations.Univers))]
        public virtual ICollection<Organisations> LOrganisa { get; set; }
        [InverseProperty(nameof(ClasseMetier.Univers))]
        public virtual ICollection<ClasseMetier> LClasseMet { get; set; }
        [InverseProperty(nameof(Alignement.Univers))]
        public virtual ICollection<Alignement> LAlign { get; set; }
        [InverseProperty(nameof(Race.Univers))]
        public virtual ICollection<Race> LRace { get; set; }
        [InverseProperty(nameof(Calendrier.Univers))]
        public virtual ICollection<Calendrier> LCalendr { get; set; }
        [InverseProperty(nameof(PaysContree.Univers))]
        public virtual ICollection<PaysContree> LPays { get; set; }
        [InverseProperty(nameof(Competences.Univers))]
        public virtual ICollection<Competences> LComp { get; set; }


        #endregion

        #region ForeignKeys
        [ForeignKey(nameof(TypoUniversId))]
        public virtual TyposUnivers TyposUnivers
        { get; set; }
        #endregion
        
    }
}