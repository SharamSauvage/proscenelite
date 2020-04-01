using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ProsceneLite.Data
{
    [Table("Quete")]
    public class Quete
    {
        #region Key(s)
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        #endregion

        #region Champs
        [Required]
        public string TitreQuete { get; set; }
        public Guid? ReferentId { get; set; }
        public Guid? StatuValidId { get; set; }
        public Guid? TypoQueteId { get; set; }
        public Guid? ProjetId { get; set; }
        #endregion

        #region ForeignKeys
        [ForeignKey(nameof(ReferentId))]
        public Utilisateurs Utilisateurs
        {
            get;
            set;
        }
        [ForeignKey(nameof(TypoQueteId))]
        public TypoQuete TypoQuete
        {
            get;
            set;
        }
        [ForeignKey(nameof(StatuValidId))]
        public StatutValidation StatutValidation
        {
            get;
            set;
        }
        [ForeignKey(nameof(ProjetId))]
        public virtual Projet Projet
        { get; set; }
        #endregion

    }
}