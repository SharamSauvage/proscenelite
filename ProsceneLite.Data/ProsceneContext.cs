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

            /*
             OLD
            modelBuilder.Entity<Univers>()
                .HasOne(t => t.TyposUnivers)
                .WithMany(u => u.LUnivers)
                .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<Projet>()
                .HasOne(u => u.Univers)
                .WithMany(p => p.LProjets)
                .OnDelete(DeleteBehavior.SetNull);
            */
            
            #region GenereViaXL
            modelBuilder.Entity<Adresse>()
                .HasOne(u => u.Voies)
                .WithMany(p => p.ListeVoies)
                .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<Adresse>()
            .HasOne(u => u.Pays1)
            .WithMany(p => p.LPays)
            .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<AdressesUtilisateurs>()
            .HasOne(u => u.Adresse)
            .WithMany(p => p.LAdresseUsers)
            .OnDelete(DeleteBehavior.ClientCascade);

            modelBuilder.Entity<AdressesUtilisateurs>()
            .HasOne(u => u.Utilisateurs)
            .WithMany(p => p.LUtilisateursAdresses)
            .OnDelete(DeleteBehavior.ClientCascade);

            modelBuilder.Entity<Social>()
            .HasOne(u => u.Utilisateurs)
            .WithMany(p => p.LUtilisateurUsersSoc)
            .OnDelete(DeleteBehavior.ClientCascade);

            modelBuilder.Entity<Social>()
            .HasOne(u => u.Contact)
            .WithMany(p => p.LUtilisateursContactSoc)
            .OnDelete(DeleteBehavior.ClientCascade);

            modelBuilder.Entity<PJ>()
            .HasOne(u => u.Inscrits)
            .WithMany(p => p.LInscrits)
            .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<Inscrits>()
            .HasOne(u => u.Projet)
            .WithMany(p => p.LProjetsInscrits)
            .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<Inscrits>()
            .HasOne(u => u.Adresse)
            .WithMany(p => p.LAdresseInscrits)
            .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<ProjetsUtilisateurs>()
            .HasOne(u => u.Utilisateurs)
            .WithMany(p => p.LUtilisateursProjets)
            .OnDelete(DeleteBehavior.ClientCascade);

            modelBuilder.Entity<ProjetsUtilisateurs>()
            .HasOne(u => u.Projet)
            .WithMany(p => p.LProjetUtilisateurs)
            .OnDelete(DeleteBehavior.ClientCascade);

            modelBuilder.Entity<Univers>()
            .HasOne(u => u.TyposUnivers)
            .WithMany(p => p.LUnivers)
            .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<Projet>()
            .HasOne(u => u.Univers)
            .WithMany(p => p.LProjets)
            .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<Quete>()
            .HasOne(u => u.Projet)
            .WithMany(p => p.LProjetQuetes)
            .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<Quete>()
            .HasOne(u => u.TypoQuete)
            .WithMany(p => p.LQuete)
            .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<Quete>()
            .HasOne(u => u.Utilisateurs)
            .WithMany(p => p.LUtilisateursQuete)
            .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<PlotPointsQuete>()
            .HasOne(u => u.Quete)
            .WithMany(p => p.LPlotPoint)
            .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<PlotPointsQuete>()
            .HasOne(u => u.Quete1)
            .WithMany(p => p.LPPParent)
            .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<Scene>()
            .HasOne(u => u.Quete)
            .WithMany(p => p.LScene)
            .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<PartisQuete>()
            .HasOne(u => u.Quete)
            .WithMany(p => p.LPartis)
            .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<ObjetsQuete>()
            .HasOne(u => u.Quete)
            .WithMany(p => p.LObjets)
            .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<PlotPointsQuete>()
            .HasOne(u => u.PartisQuete)
            .WithMany(p => p.LPlotPointPartis)
            .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<PartisPJ>()
            .HasOne(u => u.PartisQuete)
            .WithMany(p => p.LPartisPJ)
            .OnDelete(DeleteBehavior.ClientCascade);

            modelBuilder.Entity<PartisPJ>()
            .HasOne(u => u.PJ)
            .WithMany(p => p.LPJPartis)
            .OnDelete(DeleteBehavior.ClientCascade);

            modelBuilder.Entity<PlotPointsQuete>()
            .HasOne(u => u.PlotPointsQuete1)
            .WithMany(p => p.LPPEnfants)
            .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<ObjetsQuete>()
            .HasOne(u => u.PlotPointsQuete)
            .WithMany(p => p.LObjets)
            .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<Spots>()
            .HasOne(u => u.TypoSpot)
            .WithMany(p => p.LSpots)
            .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<Scene>()
            .HasOne(u => u.Spots)
            .WithMany(p => p.LSpotScene)
            .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<ObjetScene>()
            .HasOne(u => u.Scene)
            .WithMany(p => p.LObjetsScn)
            .OnDelete(DeleteBehavior.ClientCascade);

            modelBuilder.Entity<PNJScene>()
            .HasOne(u => u.Scene)
            .WithMany(p => p.LPNJScn)
            .OnDelete(DeleteBehavior.ClientCascade);

            modelBuilder.Entity<PNJScene>()
            .HasOne(u => u.PNJ)
            .WithMany(p => p.LScene)
            .OnDelete(DeleteBehavior.ClientCascade);

            modelBuilder.Entity<ObjetScene>()
            .HasOne(u => u.ObjetsQuete)
            .WithMany(p => p.LObjQueteScn)
            .OnDelete(DeleteBehavior.ClientCascade);

            #endregion






        }
    }
}

