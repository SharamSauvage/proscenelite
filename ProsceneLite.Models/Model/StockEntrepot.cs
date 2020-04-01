using System;
using System.Collections.Generic;
using System.Text;

namespace ProsceneLite.Models
{
    public class StockEntrepot
    {
        #region Champs
 
        public Guid Id { get; set; }
        public Guid EntrepotId { get; set; }
        public string DesignationItem { get; set; }
        public int Quantite { get; set; }
        public string CheminPhoto { get; set; }
        
        public Byte[] Photo { get; set; }
        public string QRCode { get; set; }
        public string Remarque { get; set; }
        public virtual Entrepot Entrepot
        { get; set; }

        #endregion


        #region Constructeur
        public StockEntrepot() { }
        #endregion

        #region Methodes
        #endregion
    }
}