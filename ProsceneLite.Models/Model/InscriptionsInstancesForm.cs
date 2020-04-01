using System;
using System.Collections.Generic;
using System.Text;

namespace ProsceneLite.Data
{
    public class InscriptionsInstancesForm
    {
        #region Champs
        public Guid InscritId { get; set; }
        public Guid InstanceFormId { get; set; }

        public string Valeur { get; set; }
        
        public virtual Inscrits Inscrits
        { get; set; }

        public virtual InstanceFormulaireInscription InstanceFormulaireInscription
        { get; set; }

        #endregion

        #region Constructeur
        public InscriptionsInstancesForm()
        {

        }
        #endregion

        #region Methodes

        #endregion

    }
}