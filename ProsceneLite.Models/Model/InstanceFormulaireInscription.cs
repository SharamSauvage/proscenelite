using System;
using System.Collections.Generic;
using System.Text;

namespace ProsceneLite.Data
{
    public class InstanceFormulaireInscription
    {
        #region Champs
        public Guid Id { get; set; }

        public Guid FormulaireInscrpId { get; set; }
        public Guid ChampsFormId { get; set; }
        public string LibelleChamp { get; set; }

        
        public virtual FormulaireInscriptions FormulaireInscriptions
        { get; set; }
        
        public virtual ListeChampsInscriptions ListeChampsInscriptions
        { get; set; }
        #endregion

        #region Constructeur
        public InstanceFormulaireInscription()
        {

        }
        #endregion

        #region Methodes

        #endregion

    }
}