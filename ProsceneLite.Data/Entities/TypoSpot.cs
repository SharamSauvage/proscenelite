using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;


namespace ProsceneLite.Data
{
    [Table("TypoSpot")]
    public class TypoSpot
    {
        #region Key(s)
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        #endregion

        #region Champs
        public string TypeSpot { get; set; } //décor, zone instanciée, escape room
        #endregion

    }
}