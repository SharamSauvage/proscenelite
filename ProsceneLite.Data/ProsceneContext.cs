using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Debug;
using System;
using System.Diagnostics;


namespace ProsceneLite.Data
{
    public class ProsceneContext : DbContext
    {
#if DEBUG
        public static readonly LoggerFactory MyLoggerFactory = new LoggerFactory(new[] { new DebugLoggerProvider() });
#endif
        #region DbSets
        public virtual DbSet<Adresse> _Adresse { get; set; }
        //public virtual DbSet<AdressesEntites> _AdressesEntites { get; set; }
        public virtual DbSet<AdressesUtilisateurs> _AdressesUtilisateurs { get; set; }
        //public virtual DbSet<Entite> _Entites { get; set; }
        //public virtual DbSet<EntiteBanque> _EntiteBanques { get; set; }
        //public virtual DbSet<Entrepot> _Entrepots { get; set; }
        //public virtual DbSet<FormulaireInscriptions> _FormulaireInscriptions { get; set; }
        //public virtual DbSet<InscriptionsInstancesForm> _InscriptionsInstancesForms { get; set; }
        public virtual DbSet<Inscrits> _Inscrits { get; set; }
        //public virtual DbSet<InstanceFormulaireInscription> _InstanceFormulaireInscriptions { get; set; }
        //public virtual DbSet<ListeChampsInscriptions> _ListeChampsInscriptions { get; set; }
        //public virtual DbSet<ListeChampsUnivers> _ListeChampsUnivers { get; set; }
        public virtual DbSet<ObjetScene> _ObjetScenes { get; set; }
        public virtual DbSet<ObjetsQuete> _ObjetsQuetes { get; set; }
        public virtual DbSet<PartisPJ> _PartisPJs { get; set; }
        public virtual DbSet<PartisQuete> _PartisQuetes { get; set; }
        public virtual DbSet<Pays> _Pays { get; set; }
        public virtual DbSet<PJ> _PJ { get; set; }
        public virtual DbSet<PlotPointsQuete> _PlotPointsQuetes { get; set; }
        public virtual DbSet<PNJ> _PNJ { get; set; }
        public virtual DbSet<PNJScene> _PNJScenes { get; set; }
        public virtual DbSet<Projet> _Projets { get; set; }
        //public virtual DbSet<ProjetsEntites> _ProjetsEntites { get; set; }
        public virtual DbSet<ProjetsUtilisateurs> _ProjetsUtilisateurs { get; set; }
        public virtual DbSet<Quete> _Quetes { get; set; }
        //public virtual DbSet<ReservationItem> _ReservationItems { get; set; }
        public virtual DbSet<Scene> _Scenes { get; set; }
        public virtual DbSet<Spots> _Spots { get; set; }
        //public virtual DbSet<StatResa> _StatResas { get; set; }
        public virtual DbSet<StatutValidation> _StatutValidations { get; set; }
        //public virtual DbSet<StockEntrepot> _StockEntrepots { get; set; }
        //public virtual DbSet<Terrains> _Terrains { get; set; }
        public virtual DbSet<TypoQuete> _TypoQuetes { get; set; }
        public virtual DbSet<TypoSpot> _TypoSpot { get; set; }
        public virtual DbSet<TyposUnivers> _TypoUnivers { get; set; }
        public virtual DbSet<Univers> _Univers { get; set; }
        public virtual DbSet<Utilisateurs> _Utilisateurs { get; set; }
        //public virtual DbSet<UtilisateursEntites> _UtilisateursEntites { get; set; }
        public virtual DbSet<Voies> _Voies { get; set; }
        public virtual DbSet<Social> _Socials { get; set; }

        #endregion

        public ProsceneContext(DbContextOptions<ProsceneContext> options)
            :base(options)
        { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
#if DEBUG
            optionsBuilder.UseLoggerFactory(MyLoggerFactory);
#endif
        }

#if DEBUG
        public override void Dispose()
        {
            base.Dispose();
            Debug.WriteLine($"{nameof(ProsceneContext)} disposed!");
        }
#endif
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Univers>()
                .HasOne(t => t.TyposUnivers)
                .WithMany(u => u.UniversLiés)
                .OnDelete(DeleteBehavior.SetNull);

            /*modelBuilder.Entity<ListeChampsUnivers>()
                .HasOne(u => u.Univers)
                .WithMany(l => l.ListeChamps)
                .OnDelete(DeleteBehavior.NoAction);
            */
            modelBuilder.Entity<Projet>()
                .HasOne(u => u.Univers)
                .WithMany(p => p.ListeProjets)
                .OnDelete(DeleteBehavior.SetNull);

            
        }
    }
}

