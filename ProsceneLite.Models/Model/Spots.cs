using System;
using System.Collections.Generic;
using System.Text;

namespace ProsceneLite.Models
{
    public class Spots
    {

        #region Champs

        public Guid Id { get; set; }
        public string NomSpot { get; set; }
        public Guid? TypeSpot { get; set; } //zone instanciée, décor en jeu, escape room etc...
        public Guid? StatuValidId { get; set; }
        public Byte[] Img { get; set; }

        public virtual TypoSpot TypoSpot
        { get; set; }

        public virtual StatutValidation StatutValidation
        { get; set; }
        #endregion


        #region Constructeur
        public Spots() { }
        #endregion

        #region Methodes
        #endregion
    }
}