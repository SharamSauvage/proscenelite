using System;
using System.Collections.Generic;
using System.Text;

namespace ProsceneLite.Data
{
    
    public class ReservationItem
    {
        #region Champs

        public Guid Id { get; set; }
        public Guid ItemId { get; set; }
        public Guid ProjetId { get; set; }
        public DateTime DébutResa { get; set; }
        public DateTime FinResa { get; set; }
        public Guid StatutResaId { get; set; }
        public DateTime DateDemande { get; set; }
        public virtual StatResa StatResa
        {
            get;
            set;
        }

        public virtual StockEntrepot StockEntrepot
        {
            get;
            set;
        }

        public virtual Projet Projet
        {
            get;
            set;
        }
        #endregion

        #region Constructeur
        public ReservationItem() { }
        #endregion

        #region Methodes
        #endregion

    }
}