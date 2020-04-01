using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ProsceneLite.Data
{        
    [Table("Inscrits")]
    public class Inscrits
    {
        #region Key(s)
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        #endregion

        #region Champs
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string CptFacebook { get; set; }
        public string AdEmail { get; set; }
        public Guid AdresseId { get; set; }
        public DateTime DdN { get; set; }
        // relatif à l'inscription "Administrative"
        public bool ReglementOK { get; set; }
        //les 3 booléens qui suivent s'excluent l'un l'autre
        public bool EstPJ { get; set; } 
        public bool EstPNJ { get; set; }
        public bool EstOrga { get; set; }
        public Guid? ProjetId { get; set; }

        [InverseProperty(nameof(PJ.Inscrits))]
        public virtual ICollection<PJ> LInscrits { get; set; }

        #endregion

        #region ForeignKeys
        [ForeignKey(nameof(AdresseId))]
        public virtual Adresse Adresse
        { get; set; }
        [ForeignKey(nameof(ProjetId))]
        public virtual Projet Projet
        { get; set; }

        #endregion

    }
}