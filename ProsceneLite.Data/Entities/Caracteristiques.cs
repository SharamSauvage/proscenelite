using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
namespace ProsceneLite.Data
{
    [Table("Caracteristiques")]
    public class Caracteristiques
    {
        #region Key(s)
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        #endregion

        #region Champs
        public Guid? UniversId { get; set; }
        public string NomCarac { get; set; }

        [InverseProperty(nameof(CaracteristiquesPJ.Caracteristiques))]
        public virtual ICollection<CaracteristiquesPJ> LCarac { get; set; }

        #endregion

        #region ForeignKeys
        [ForeignKey(nameof(UniversId))]
        public virtual Univers Univers
        { get; set; }
        #endregion

        
    }
}