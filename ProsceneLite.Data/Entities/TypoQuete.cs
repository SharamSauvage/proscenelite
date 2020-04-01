using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ProsceneLite.Data
{
    [Table("TypoQuete")]
    public class TypoQuete
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)] 
        public Guid Id { get; set; }
        /// <summary>
        /// Quête Principale (devrait concerner tous les PJ, ou au moins justifier leur présence
        /// Quête Secondaire (devrait concerner entre 2/3 et 1/2 des PJ)
        /// Quête Terciaire (devrait concerner entre 1/3 et 1/2 des PJ)
        /// Quête Interpersonnelle (quelques PJ)
        /// Quête Personnelle (attribuée à 1 ou 2 PJ max)
        /// Quéquête (attribuée à personne mais disponible pour tous (ou seulement une ou plusieurs classe(s) de pj) )
        /// </summary>
        [Required]
        public string TypeQuete { get; set; } 

        [InverseProperty(nameof(Quete.TypoQuete))]
        public virtual ICollection<TypoQuete> LQuete { get; set; }

    }
}