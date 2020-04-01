using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ProsceneLite.Data
{
    [Table("Adresse")]
    public class Adresse
    {
        #region Key(s)
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        #endregion
        #region Champs
        public int Num { get; set; }
        
        public Guid? Voie { get; set; }
        
        public string NomVoie { get; set; }
        public string CodePostal { get; set; }
        public string Ville { get; set; }
        public string Region { get; set; }
        
        public Guid? Pays { get; set; }
        #endregion

        #region ForeignKeys
        [ForeignKey(nameof(Pays))]
        public virtual Pays Pays1
        {
            get;
            set;
        }
        [ForeignKey(nameof(Voie))]
        public virtual Voies Voies
        {
            get;
            set;
        }
        #endregion
    }
}