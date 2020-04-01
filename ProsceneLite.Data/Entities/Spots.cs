using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
namespace ProsceneLite.Data
{
    [Table("Spot")]
    public class Spots
    {

        #region Key(s)
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        #endregion

        #region Champs
        public string NomSpot { get; set; }
        public Guid? TypeSpotId { get; set; } //zone instanciée, décor en jeu, escape room etc...
        public int? StatuValidId { get; set; }
        public Byte[] Img { get; set; }

        #endregion

        #region ForeignKeys
        [ForeignKey(nameof(TypeSpotId))]
        public virtual TypoSpot TypoSpot
        { get; set; }
        
        #endregion

        
    }
}