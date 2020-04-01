using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ProsceneLite.Data
{
    [Table("Utilisateurs")]
    public class Utilisateurs
    {
        #region Key(s)
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        #endregion

        #region Champs
        [Required]
        public string Nom { get; set; }
        [Required]
        public string Prenom { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public DateTime Ddn { get; set; }
        public Byte[] Avatar { get; set; }

        [InverseProperty(nameof(AdressesUtilisateurs.Utilisateurs))]
        public virtual ICollection<AdressesUtilisateurs> LUtilisateursAdresses { get; set; }
        [InverseProperty(nameof(Social.Utilisateurs))]
        public virtual ICollection<Social> LUtilisateurUsersSoc { get; set; }
        [InverseProperty(nameof(Social.Contact))]
        public virtual ICollection<Social> LUtilisateursContactSoc { get; set; }
        [InverseProperty(nameof(ProjetsUtilisateurs.Utilisateurs))]
        public virtual ICollection<ProjetsUtilisateurs> LUtilisateursProjets { get; set; }
        [InverseProperty(nameof(Quete.Utilisateurs))]
        public virtual ICollection<Quete> LUtilisateursQuete { get; set; }
        #endregion
    }
}