using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ProsceneLite.Data
{
    [Table("ObjetScene")]
    public class ObjetScene
    {
        #region Key(s)
        [Key]
        public Guid ObjetId { get; set; }
        [Key]
        public Guid SceneId { get; set; }
        #endregion

        #region Indexes
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        #endregion

        #region Champs
        public string RoleObjet { get; set; }

        #endregion

        #region ForeignKeys
        [ForeignKey(nameof(SceneId))]
        public virtual Scene Scene
        { get; set; }
        [ForeignKey(nameof(ObjetId))]
        public virtual ObjetsQuete ObjetsQuete
        { get; set; }
        #endregion

        
    }
}