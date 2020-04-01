using System;
using System.Collections.Generic;
using System.Text;

namespace ProsceneLite.Models
{
    
    public class Entrepot
    {
        #region Champs

        public Guid Id { get; set; }
        public string NomEntrepot { get; set; }
        public Guid AdresseId { get; set; }
        public bool Partage { get; set; }
        public Guid UtilisateurPropId { get; set; }
        public virtual Utilisateurs Utilisateurs
        { get; set; }
        public virtual Adresse Adresse
        { get; set; }
        #endregion

        #region Constructeur
        public Entrepot() { }
        #endregion

        #region Méthodes
        #endregion

    }
}