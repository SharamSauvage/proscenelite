using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ProsceneLite.Data
{
    [Table("Scene")]
    public class Scene
    {
        #region Key(s)
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        #endregion

        #region Champs
        public DateTime DateDebut { get; set; }
        public DateTime DateFin { get; set; }
        public Guid QueteId { get; set; }
        public Guid SpotId { get; set; }

        public string DescriptionScene { get; set; }

        [InverseProperty(nameof(ObjetScene.Scene))]
        public virtual ICollection<ObjetScene> LObjetsScn { get; set; }
        [InverseProperty(nameof(PNJScene.Scene))]
        public virtual ICollection<PNJScene> LPNJScn { get; set; }

        #endregion

        #region ForeignKeys
        [ForeignKey(nameof(QueteId))]
        public virtual Quete Quete
        { get; set; }
        [ForeignKey(nameof(SpotId))]
        public virtual Spots Spots
        { get; set; }
        #endregion

        
    }
}