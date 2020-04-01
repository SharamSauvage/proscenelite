using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;


namespace ProsceneLite.Data
{
    [Table("Voies")]
    public class Voies
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        [Required]
        public int NomVoie { get; set; }

        [InverseProperty(nameof(Adresse.Voies))]
        public ICollection<Voies> ListeVoies { get; set; }
    }
}