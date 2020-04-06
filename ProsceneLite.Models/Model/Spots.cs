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
        public Guid? TypeSpotId { get; set; }
        public StatuValid? StatuValidId { get; set; }
        public Byte[] Img { get; set; }

        
        #endregion


        #region Constructeur
        public Spots() { }
        public Spots(Guid pId, string pNom, Guid? pTypeSpot, int? pStatValid, Byte[] pImg)
        {
            Id = pId;
            NomSpot = pNom;
            TypeSpotId = pTypeSpot;
            Img = pImg;
            StatuValidId=pStatValid switch
            {
                0 => StatuValid.redact,
                1 => StatuValid.relecture,
                2 => StatuValid.validation,
                3 => StatuValid.validé,
                _ => StatuValid.redact,
            };

        }
        #endregion

        #region Methodes
        #endregion
    }
}