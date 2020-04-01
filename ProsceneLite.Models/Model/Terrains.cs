using System;
using System.Collections.Generic;
using System.Text;

namespace ProsceneLite.Models
{
    
    public class Terrains
    {
        #region Champs

        public Guid Id { get; set; }
        public string NomTerrain { get; set; }
        public double Surface { get; set; }
        public bool Herbergement { get; set; }
        public bool NbCouchages { get; set; }
        public bool Sanitaires { get; set; }
        public bool ZoneCuisine { get; set; }
        public float Longitude { get; set; }
        public float Latitude { get; set; }
        public string NomContact { get; set; }
        public string TelContact { get; set; }
        public string EmailContact { get; set; }
        public bool PartageFicheTerrain { get; set; }
        public bool PartageContactTerrain { get; set; }
        public string LienSiteWebTerrain { get; set; }

        public Guid? UtilisateurId { get; set; }
        public Guid? Terrain_AdresseId { get; set; }
        public Guid? Contact_AdresseId { get; set; }

        public virtual Utilisateurs Utilisateurs
        { get; set; }

        public virtual Adresse Adresse1
        { get; set; }

        public virtual Adresse Adresse
        { get; set; }
        #endregion

        #region Constructeur
        public Terrains() { }
        #endregion

        #region Methodes
        #endregion

    }
}