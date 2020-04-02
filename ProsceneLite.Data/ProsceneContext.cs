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
        public virtual DbSet<AdressesUtilisateurs> _AdressesUtilisateurs { get; set; }
        public virtual DbSet<Alignement> _Alignement { get; set; }
        public virtual DbSet<Archetype> _Archetype { get; set; }
        public virtual DbSet<Calendrier> _Calendrier { get; set; }
        public virtual DbSet<CalendriersMultiples> _CalendriersMultiples { get; set; }
        public virtual DbSet<Caracteristiques> _Caracteristiques { get; set; }
        public virtual DbSet<CaracteristiquesPJ> _CaracteristiquesPJ { get; set; }
        public virtual DbSet<ClasseMetier> _ClasseMetier { get; set; }
        public virtual DbSet<ClassePJ> _ClassePJ { get; set; }
        public virtual DbSet<Competences> _Competences { get; set; }
        public virtual DbSet<CompetencesPJ> _CompetencesPJ { get; set; }
        public virtual DbSet<Inscrits> _Inscrits { get; set; }
        public virtual DbSet<Mois> _Mois { get; set; }
        public virtual DbSet<ObjetScene> _ObjetScene { get; set; }
        public virtual DbSet<ObjetsQuete> _ObjetsQuete { get; set; }
        public virtual DbSet<Organisations> _Organisations { get; set; }
        public virtual DbSet<PartisPJ> _PartisPJ { get; set; }
        public virtual DbSet<PartisQuete> _PartisQuete { get; set; }
        public virtual DbSet<Pays> _Pays { get; set; }
        public virtual DbSet<PaysContree> _PaysContree { get; set; }
        public virtual DbSet<PJ> _PJ { get; set; }
        public virtual DbSet<PlotPointsQuete> _PlotPointsQuete { get; set; }
        public virtual DbSet<PNJ> _PNJ { get; set; }
        public virtual DbSet<PNJScene> _PNJScene { get; set; }
        public virtual DbSet<Projet> _Projet { get; set; }
        public virtual DbSet<ProjetsUtilisateurs> _ProjetsUtilisateurs { get; set; }
        public virtual DbSet<Quete> _Quete { get; set; }
        public virtual DbSet<Race> _Race { get; set; }
        public virtual DbSet<Religion> _Religion { get; set; }
        public virtual DbSet<Scene> _Scene { get; set; }
        public virtual DbSet<Social> _Social { get; set; }
        public virtual DbSet<Spots> _Spots { get; set; }
        public virtual DbSet<TypoQuete> _TypoQuete { get; set; }
        public virtual DbSet<TypoSpot> _TypoSpot { get; set; }
        public virtual DbSet<TyposUnivers> _TyposUnivers { get; set; }
        public virtual DbSet<Univers> _Univers { get; set; }
        public virtual DbSet<Utilisateurs> _Utilisateurs { get; set; }
        public virtual DbSet<Voies> _Voies { get; set; }


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

            modelBuilder.Entity<Archetype>()
                .HasOne(u => u.Univers)
                .WithMany(p => p.LArchetypes)
                .OnDelete(DeleteBehavior.ClientCascade);
            modelBuilder.Entity<PJ>()
                .HasOne(u => u.Archetype)
                .WithMany(p => p.LPJ)
                .OnDelete(DeleteBehavior.ClientSetNull);

            #endregion
            #region GenereviaXL2
            modelBuilder.Entity<Caracteristiques>()
                .HasOne(u => u.Univers)
                .WithMany(p => p.LCarac)
                .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<Alignement>()
                .HasOne(u => u.Univers)
                .WithMany(p => p.LAlign)
                .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<Competences>()
                .HasOne(u => u.Univers)
                .WithMany(p => p.LComp)
                .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<ClasseMetier>()
                .HasOne(u => u.Univers)
                .WithMany(p => p.LClasseMet)
                .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<Calendrier>()
                .HasOne(u => u.Univers)
                .WithMany(p => p.LCalendr)
                .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<PaysContree>()
                .HasOne(u => u.Univers)
                .WithMany(p => p.LPays)
                .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<Race>()
                .HasOne(u => u.Univers)
                .WithMany(p => p.LRace)
                .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<Religion>()
                .HasOne(u => u.Univers)
                .WithMany(p => p.LRelig)
                .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<Organisations>()
                .HasOne(u => u.Univers)
                .WithMany(p => p.LOrganisa)
                .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<Mois>()
                .HasOne(u => u.Calendrier)
                .WithMany(p => p.LMois)
                .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<CalendriersMultiples>()
                .HasOne(u => u.Calendrier)
                .WithMany(p => p.LCalendMult)
                .OnDelete(DeleteBehavior.ClientCascade);

            modelBuilder.Entity<CalendriersMultiples>()
                .HasOne(u => u.PaysContree)
                .WithMany(p => p.LCalend)
                .OnDelete(DeleteBehavior.ClientCascade);

            modelBuilder.Entity<PJ>()
                .HasOne(u => u.PaysContree)
                .WithMany(p => p.LPJ)
                .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<PJ>()
                .HasOne(u => u.Alignement)
                .WithMany(p => p.LPJ)
                .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<PJ>()
                .HasOne(u => u.Religion)
                .WithMany(p => p.LPJ)
                .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<PJ>()
                .HasOne(u => u.Organisations)
                .WithMany(p => p.LPJ)
                .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<PJ>()
                .HasOne(u => u.Race)
                .WithMany(p => p.LPJ)
                .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<ClassePJ>()
                .HasOne(u => u.PJ)
                .WithMany(p => p.LClasses)
                .OnDelete(DeleteBehavior.ClientCascade);

            modelBuilder.Entity<ClassePJ>()
                .HasOne(u => u.ClasseMetier)
                .WithMany(p => p.LClassPJ)
                .OnDelete(DeleteBehavior.ClientCascade);

            modelBuilder.Entity<CompetencesPJ>()
                .HasOne(u => u.PJ)
                .WithMany(p => p.LComp)
                .OnDelete(DeleteBehavior.ClientCascade);

            modelBuilder.Entity<CompetencesPJ>()
                .HasOne(u => u.Competences)
                .WithMany(p => p.LComp)
                .OnDelete(DeleteBehavior.ClientCascade);

            modelBuilder.Entity<CaracteristiquesPJ>()
                .HasOne(u => u.PJ)
                .WithMany(p => p.LCarac)
                .OnDelete(DeleteBehavior.ClientCascade);

            modelBuilder.Entity<CaracteristiquesPJ>()
                .HasOne(u => u.Caracteristiques)
                .WithMany(p => p.LCarac)
                .OnDelete(DeleteBehavior.ClientCascade);
            #endregion

            #region Indexes
            modelBuilder.Entity<ChronoPJ>()
                .HasIndex(p => new { p.PJId, p.MoisId, p.Annee })
                .IsUnique();

            modelBuilder.Entity<RelationsPJ>()
                .HasIndex(p => p.Id)
                .IsUnique();

            #endregion





        }
    }
}

