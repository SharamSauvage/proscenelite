using System;
using System.Collections.Generic;
using System.Text;

namespace ProsceneLite.Models
{
    public class ObjetScene
    {
        #region Champs
        public Guid ObjetId { get; set; }
        
        public Guid SceneId { get; set; }
        
        public string RoleObjet { get; set; }

        /// <summary>
        /// Index non clé
        /// </summary>
        public Guid Id { get; set; }

        #endregion

        #region Constructeur
        public ObjetScene() { }
        #endregion

        #region Methodes
        #endregion



    }
}