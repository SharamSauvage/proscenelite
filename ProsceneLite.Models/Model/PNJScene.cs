using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ProsceneLite.Models
{
    public class PNJScene
    {
        #region Champs
        public Guid PNJId { get; set; }

        public Guid SceneId { get; set; }
        
        public string DescriptionRoleScene { get; set; }
        public string Remarques { get; set; }

        
        #endregion

        #region Constructeur
        public PNJScene() { }
        #endregion

        #region Methodes
        #endregion



    }
}