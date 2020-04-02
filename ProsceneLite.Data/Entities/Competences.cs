using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ProsceneLite.Data
{
    [Table("Competences")]
    public class Competences
    {
        #region Key(s)
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        #endregion

        #region Champs
        public Guid? UniversId { get; set; }
        public string NomCompetence { get; set; }
        public bool EstNumerique { get; set; }

        [InverseProperty(nameof(CompetencesPJ.Competences))]
        public virtual ICollection<CompetencesPJ> LComp { get; set; }

        #endregion

        #region ForeignKeys
        [ForeignKey(nameof(UniversId))]
        public virtual Univers Univers
        { get; set; }

        #endregion


    }
}