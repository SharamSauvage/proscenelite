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

        public virtual Scene Scene
        { get; set; }
        
        public virtual ObjetsQuete ObjetsQuete
        { get; set; }
        #endregion

        #region Constructeur
        public ObjetScene() { }
        #endregion

        #region Methodes
        #endregion



    }
}