using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ProsceneLite.Data
{
    [Table("PNJScene")]
    public class PNJScene
    {
        #region Key(s)
        [Key]
        public Guid PNJId { get; set; }
        [Key]
        public Guid SceneId { get; set; }
        #endregion

        #region Champs
        
        public string DescriptionRoleScene { get; set; }
        public string Remarques { get; set; }

        #endregion

        #region ForeignKeys
        [ForeignKey(nameof(PNJId))]
        public virtual PNJ PNJ
        { get; set; }
        [ForeignKey(nameof(SceneId))]
        public virtual Scene Scene
        { get; set; }
        #endregion

        
    }
}