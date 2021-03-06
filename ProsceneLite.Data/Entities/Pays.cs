﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ProsceneLite.Data
{
    [Table("Pays")]
    public class Pays
    {
        
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        [Required]
        public string NomPays {get; set;}


        [InverseProperty(nameof(Adresse.Pays1))]
        public ICollection<Adresse> LPays { get; set; }
    }
}