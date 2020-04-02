﻿using System;
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

        
        [InverseProperty(nameof(Projet.Univers))]
        public virtual ICollection<Projet> LProjets { get; set; }
        [InverseProperty(nameof(Archetype.Univers))]
        public virtual ICollection<Archetype> LArchetypes { get; set; }

        #endregion

        #region ForeignKeys
        [ForeignKey(nameof(TypoUniversId))]
        public virtual TyposUnivers TyposUnivers
        {
            get;
            set;
        }
        #endregion
        
    }
}