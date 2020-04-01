using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ProsceneLite.Models
{
    public class PNJ
    {
        #region Champs
        public Guid Id { get; set; }

        public string NomPNJ { get; set; }
        public string DescrptPNJ { get; set; }
        public string DescrptCostume { get; set; }
        public string DescrptAttitude { get; set; }

        #endregion

        #region Constructeur
        public PNJ() { }
        #endregion

        #region Methodes
        #endregion

    }
}