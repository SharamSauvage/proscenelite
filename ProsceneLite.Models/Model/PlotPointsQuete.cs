using System;
using System.Collections.Generic;
using System.Text;

namespace ProsceneLite.Models
{
    public class PlotPointsQuete
    {
        #region Champs
        public Guid Id { get; set; }
        public string NomPlotPoint { get; set; }
        public string DescrptPP { get; set; }
        public bool EstBorneTemps { get; set; }
        public DateTime DateDebut { get; set; }
        public DateTime DateFin { get; set; }
        public bool EstLiéPP { get; set; }
        public bool EstLiéQuete { get; set; }
        public bool EstLiéParti { get; set; }
        public Guid? QueteId { get; set; }
        public Guid? ParentPPId { get; set; }
        public Guid? ParentPPQueteId { get; set; }
        public Guid? PartiId { get; set; }

        #endregion

        #region Constructeur
        public PlotPointsQuete() { }
        #endregion

        #region Methodes
        #endregion

    }
}