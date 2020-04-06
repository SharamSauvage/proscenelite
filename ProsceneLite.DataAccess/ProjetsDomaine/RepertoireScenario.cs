using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Text;
using ProsceneLite.Data;
using ProsceneLite.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace ProsceneLite.DataAccess
{
    public class RepertoireScenario : RepertoireBase<ProsceneContext>, IRepertoireScenario
    {
        public RepertoireScenario(DbContextOptions<ProsceneContext> options)
            : base(options)
        {

        }

        #region CReates
        public async Task<Guid> Create(Models.ObjetScene objeSc)
        {
            try
            {
                var context = CreateContext();
                var created = new Data.ObjetScene
                {
                    ObjetId = objeSc.ObjetId,
                    SceneId = objeSc.SceneId,
                    RoleObjet = objeSc.RoleObjet,
                    Id = objeSc.Id,
                };
                var enr = await context
                ._ObjetScene
                .AddAsync(created);
                await context.SaveChangesAsync();

                return enr.Entity.Id;
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
                return objeSc.Id;
            }
        }

        public async Task<Guid> Create(Models.ObjetsQuete objeQt)
        {
            try
            {
                var context = CreateContext();
                int Sv;
                Sv = objeQt.StatuValidId switch
                {
                    StatuValid.redact => Sv = 0,
                    StatuValid.relecture => Sv = 1,
                    StatuValid.validation => Sv = 2,
                    StatuValid.validé => Sv = 3,
                    _ => Sv = 0,
                };
                var created = new Data.ObjetsQuete
                {
                    Id = objeQt.Id,
                    QueteId = objeQt.QueteId,
                    NomObjet = objeQt.NomObjet,
                    PrezObjet = objeQt.PrezObjet,
                    SituationDebJeu = objeQt.SituationDebJeu,
                    Effet = objeQt.Effet,
                    Image = objeQt.Image,
                    PPLieId = objeQt.PPLieId,
                    StatuValidId = Sv,
                    StockId = objeQt.StockId,
                    ExisteDeja = objeQt.ExisteDeja,
                    EstDisponible = objeQt.EstDisponible,
                    EstDemande = objeQt.EstDemande,
                    DemandeResaOK = objeQt.DemandeResaOK,

                };
                var enr = await context
                ._ObjetsQuete
                .AddAsync(created);
                await context.SaveChangesAsync();

                return enr.Entity.Id;
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
                return objeQt.Id;
            }
        }

        public async Task<Guid> Create(Models.PartisQuete partQt)
        {
            try
            {
                var context = CreateContext();
                var created = new Data.PartisQuete
                {
                    Id = partQt.Id,
                    QueteId = partQt.QueteId,
                    NomParti = partQt.NomParti,
                    Synopsis = partQt.Synopsis,
                    But = partQt.But,
                    DebutEnJeu = partQt.DebutEnJeu,
                    FinEnJeu = partQt.FinEnJeu,
                };
                var enr = await context
                ._PartisQuete
                .AddAsync(created);
                await context.SaveChangesAsync();

                return enr.Entity.Id;
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
                return partQt.Id;
            }
        }

        public async Task<Guid> Create(Models.PlotPointsQuete pptQt)
        {
            try
            {
                var context = CreateContext();
                var created = new Data.PlotPointsQuete
                {
                    Id = pptQt.Id,
                    NomPlotPoint = pptQt.NomPlotPoint,
                    DescrptPP = pptQt.DescrptPP,
                    EstBorneTemps = pptQt.EstBorneTemps,
                    DateDebut = pptQt.DateDebut,
                    DateFin = pptQt.DateFin,
                    EstLiéPP = pptQt.EstLiéPP,
                    EstLiéQuete = pptQt.EstLiéQuete,
                    EstLiéParti = pptQt.EstLiéParti,
                    QueteId = pptQt.QueteId,
                    ParentPPId = pptQt.ParentPPId,
                    ParentPPQueteId = pptQt.ParentPPQueteId,
                    PartiId = pptQt.PartiId,
                };
                var enr = await context
                ._PlotPointsQuete
                .AddAsync(created);
                await context.SaveChangesAsync();

                return enr.Entity.Id;
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
                return pptQt.Id;
            }
        }

        public async Task<Guid> Create(Models.PNJ peunj)
        {
            try
            {
                var context = CreateContext();
                var created = new Data.PNJ
                {
                    Id = peunj.Id,
                    NomPNJ = peunj.NomPNJ,
                    DescrptPNJ = peunj.DescrptPNJ,
                    DescrptCostume = peunj.DescrptCostume,
                    DescrptAttitude = peunj.DescrptAttitude,
                };
                var enr = await context
                ._PNJ
                .AddAsync(created);
                await context.SaveChangesAsync();

                return enr.Entity.Id;
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
                return peunj.Id;
            }
        }

        public async Task<Guid> Create(Models.PNJScene pnjscn)
        {
            try
            {
                var context = CreateContext();
                var created = new Data.PNJScene
                {
                    PNJId = pnjscn.PNJId,
                    SceneId = pnjscn.SceneId,
                    DescriptionRoleScene = pnjscn.DescriptionRoleScene,
                    Remarques = pnjscn.Remarques,
                    Id = pnjscn.Id,
                };
                var enr = await context
                ._PNJScene
                .AddAsync(created);
                await context.SaveChangesAsync();

                return enr.Entity.Id;
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
                return pnjscn.Id;
            }
        }

        public async Task<Guid> Create(Models.Quete quet)
        {
            try
            {
                var context = CreateContext();
                int Sv;
                Sv = quet.StatuValidId switch
                {
                    StatuValid.redact => Sv = 0,
                    StatuValid.relecture => Sv = 1,
                    StatuValid.validation => Sv = 2,
                    StatuValid.validé => Sv = 3,
                    _ => Sv = 0,
                };
                var created = new Data.Quete
                {
                    Id = quet.Id,
                    TitreQuete = quet.TitreQuete,
                    ReferentId = quet.ReferentId,
                    StatuValidId = Sv,
                    TypoQueteId = quet.TypoQueteId,
                    ProjetId = quet.ProjetId,
                    SynopsisQuete = quet.SynopsisQuete,
                };
                var enr = await context
                ._Quete
                .AddAsync(created);
                await context.SaveChangesAsync();

                return enr.Entity.Id;
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
                return quet.Id;
            }
        }

        public async Task<Guid> Create(Models.Scene scen)
        {
            try
            {
                var context = CreateContext();
                var created = new Data.Scene
                {
                    Id = scen.Id,
                    DateDebut = scen.DateDebut,
                    DateFin = scen.DateFin,
                    QueteId = scen.QueteId,
                    SpotId = scen.SpotId,
                    DescriptionScene = scen.DescriptionScene,
                };
                var enr = await context
                ._Scene
                .AddAsync(created);
                await context.SaveChangesAsync();

                return enr.Entity.Id;
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
                return scen.Id;
            }
        }

        public async Task<Guid> Create(Models.Spots spot)
        {
            try
            {
                var context = CreateContext();
                int Sv;
                Sv = spot.StatuValidId switch
                {
                    StatuValid.redact => Sv = 0,
                    StatuValid.relecture => Sv = 1,
                    StatuValid.validation => Sv = 2,
                    StatuValid.validé => Sv = 3,
                    _ => Sv = 0,
                };
                var created = new Data.Spots
                {
                    Id = spot.Id,
                    NomSpot = spot.NomSpot,
                    TypeSpotId = spot.TypeSpot,
                    StatuValidId = Sv,
                    Img = spot.Img,
                };
                var enr = await context
                ._Spots
                .AddAsync(created);
                await context.SaveChangesAsync();

                return enr.Entity.Id;
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
                return spot.Id;
            }
        }

        public async Task<Guid> Create(Models.TypoQuete typoQt)
        {
            try
            {
                var context = CreateContext();
                var created = new Data.TypoQuete
                {
                    Id = typoQt.Id,
                    TypeQuete = typoQt.TypeQuete,
                };
                var enr = await context
                ._TypoQuete
                .AddAsync(created);
                await context.SaveChangesAsync();

                return enr.Entity.Id;
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
                return typoQt.Id;
            }
        }

        public async Task<Guid> Create(Models.TypoSpot typoSp)
        {
            try
            {
                var context = CreateContext();
                var created = new Data.TypoSpot
                {
                    Id = typoSp.Id,
                    TypeSpot = typoSp.TypeSpot,
                };
                var enr = await context
                ._TypoSpot
                .AddAsync(created);
                await context.SaveChangesAsync();

                return enr.Entity.Id;
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
                return typoSp.Id;
            }
        }
        #endregion

        #region Updates
        public async Task Update(Models.ObjetScene objeSc)
        {
            try
            {
                var context = CreateContext();
                var toUpdate = await context._ObjetScene.FindAsync(objeSc.Id);
                if (toUpdate != null)
                {
                    toUpdate.ObjetId = objeSc.ObjetId;
                    toUpdate.SceneId = objeSc.SceneId;
                    toUpdate.RoleObjet = objeSc.RoleObjet;
                    toUpdate.Id = objeSc.Id;
                    await context.SaveChangesAsync();
                }
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public async Task Update(Models.ObjetsQuete objeQt)
        {
            try
            {
                var context = CreateContext();
                int Sv;
                Sv = objeQt.StatuValidId switch
                {
                    StatuValid.redact => Sv = 0,
                    StatuValid.relecture => Sv = 1,
                    StatuValid.validation => Sv = 2,
                    StatuValid.validé => Sv = 3,
                    _ => Sv = 0,
                };
                var toUpdate = await context._ObjetsQuete.FindAsync(objeQt.Id);
                if (toUpdate != null)
                {
                    toUpdate.Id = objeQt.Id;
                    toUpdate.QueteId = objeQt.QueteId;
                    toUpdate.NomObjet = objeQt.NomObjet;
                    toUpdate.PrezObjet = objeQt.PrezObjet;
                    toUpdate.SituationDebJeu = objeQt.SituationDebJeu;
                    toUpdate.Effet = objeQt.Effet;
                    toUpdate.Image = objeQt.Image;
                    toUpdate.PPLieId = objeQt.PPLieId;
                    toUpdate.StatuValidId = Sv;
                    toUpdate.StockId = objeQt.StockId;
                    toUpdate.ExisteDeja = objeQt.ExisteDeja;
                    toUpdate.EstDisponible = objeQt.EstDisponible;
                    toUpdate.EstDemande = objeQt.EstDemande;
                    toUpdate.DemandeResaOK = objeQt.DemandeResaOK;

                    await context.SaveChangesAsync();
                }
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public async Task Update(Models.PartisQuete partQt)
        {
            try
            {
                var context = CreateContext();
                var toUpdate = await context._PartisQuete.FindAsync(partQt.Id);
                if (toUpdate != null)
                {
                    toUpdate.Id = partQt.Id;
                    toUpdate.QueteId = partQt.QueteId;
                    toUpdate.NomParti = partQt.NomParti;
                    toUpdate.Synopsis = partQt.Synopsis;
                    toUpdate.But = partQt.But;
                    toUpdate.DebutEnJeu = partQt.DebutEnJeu;
                    toUpdate.FinEnJeu = partQt.FinEnJeu;

                    await context.SaveChangesAsync();
                }
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public async Task Update(Models.PlotPointsQuete pptQt)
        {
            try
            {
                var context = CreateContext();
                var toUpdate = await context._PlotPointsQuete.FindAsync(pptQt.Id);
                if (toUpdate != null)
                {
                    toUpdate.Id = pptQt.Id;
                    toUpdate.NomPlotPoint = pptQt.NomPlotPoint;
                    toUpdate.DescrptPP = pptQt.DescrptPP;
                    toUpdate.EstBorneTemps = pptQt.EstBorneTemps;
                    toUpdate.DateDebut = pptQt.DateDebut;
                    toUpdate.DateFin = pptQt.DateFin;
                    toUpdate.EstLiéPP = pptQt.EstLiéPP;
                    toUpdate.EstLiéQuete = pptQt.EstLiéQuete;
                    toUpdate.EstLiéParti = pptQt.EstLiéParti;
                    toUpdate.QueteId = pptQt.QueteId;
                    toUpdate.ParentPPId = pptQt.ParentPPId;
                    toUpdate.ParentPPQueteId = pptQt.ParentPPQueteId;
                    toUpdate.PartiId = pptQt.PartiId;

                    await context.SaveChangesAsync();
                }
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public async Task Update(Models.PNJ peunj)
        {
            try
            {
                var context = CreateContext();
                var toUpdate = await context._PNJ.FindAsync(peunj.Id);
                if (toUpdate != null)
                {
                    toUpdate.Id = peunj.Id;
                    toUpdate.NomPNJ = peunj.NomPNJ;
                    toUpdate.DescrptPNJ = peunj.DescrptPNJ;
                    toUpdate.DescrptCostume = peunj.DescrptCostume;
                    toUpdate.DescrptAttitude = peunj.DescrptAttitude;

                    await context.SaveChangesAsync();
                }
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public async Task Update(Models.PNJScene pnjscn)
        {
            try
            {
                var context = CreateContext();
                var toUpdate = await context._PNJScene.FindAsync(pnjscn.Id);
                if (toUpdate != null)
                {
                    toUpdate.PNJId = pnjscn.PNJId;
                    toUpdate.SceneId = pnjscn.SceneId;
                    toUpdate.DescriptionRoleScene = pnjscn.DescriptionRoleScene;
                    toUpdate.Remarques = pnjscn.Remarques;
                    toUpdate.Id = pnjscn.Id;

                    await context.SaveChangesAsync();
                }
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public async Task Update(Models.Quete quet)
        {
            try
            {
                var context = CreateContext();
                int Sv;
                Sv = quet.StatuValidId switch
                {
                    StatuValid.redact => Sv = 0,
                    StatuValid.relecture => Sv = 1,
                    StatuValid.validation => Sv = 2,
                    StatuValid.validé => Sv = 3,
                    _ => Sv = 0,
                };
                var toUpdate = await context._Quete.FindAsync(quet.Id);
                if (toUpdate != null)
                {
                    toUpdate.Id = quet.Id;
                    toUpdate.TitreQuete = quet.TitreQuete;
                    toUpdate.ReferentId = quet.ReferentId;
                    toUpdate.StatuValidId = Sv;
                    toUpdate.TypoQueteId = quet.TypoQueteId;
                    toUpdate.ProjetId = quet.ProjetId;
                    toUpdate.SynopsisQuete = quet.SynopsisQuete;

                    await context.SaveChangesAsync();
                }
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public async Task Update(Models.Scene scen)
        {
            try
            {
                var context = CreateContext();
                var toUpdate = await context._Scene.FindAsync(scen.Id);
                if (toUpdate != null)
                {
                    toUpdate.Id = scen.Id;
                    toUpdate.DateDebut = scen.DateDebut;
                    toUpdate.DateFin = scen.DateFin;
                    toUpdate.QueteId = scen.QueteId;
                    toUpdate.SpotId = scen.SpotId;
                    toUpdate.DescriptionScene = scen.DescriptionScene;

                    await context.SaveChangesAsync();
                }
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public async Task Update(Models.Spots spot)
        {
            try
            {
                var context = CreateContext();
                int Sv;
                Sv = spot.StatuValidId switch
                {
                    StatuValid.redact => Sv = 0,
                    StatuValid.relecture => Sv = 1,
                    StatuValid.validation => Sv = 2,
                    StatuValid.validé => Sv = 3,
                    _ => Sv = 0,
                };
                var toUpdate = await context._Spots.FindAsync(spot.Id);
                if (toUpdate != null)
                {
                    toUpdate.Id = spot.Id;
                    toUpdate.NomSpot = spot.NomSpot;
                    toUpdate.TypeSpotId = spot.TypeSpot;
                    toUpdate.StatuValidId = Sv;
                    toUpdate.Img = spot.Img;

                    await context.SaveChangesAsync();
                }
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public async Task Update(Models.TypoQuete typoQt)
        {
            try
            {
                var context = CreateContext();
                var toUpdate = await context._TypoQuete.FindAsync(typoQt.Id);
                if (toUpdate != null)
                {
                    toUpdate.Id = typoQt.Id;
                    toUpdate.TypeQuete = typoQt.TypeQuete;

                    await context.SaveChangesAsync();
                }
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
            }
        }
        
        public async Task Update(Models.TypoSpot typoSp)
        {
            try
            {
                var context = CreateContext();
                var toUpdate = await context._TypoSpot.FindAsync(typoSp.Id);
                if (toUpdate != null)
                {
                    toUpdate.Id = typoSp.Id;
                    toUpdate.TypeSpot = typoSp.TypeSpot;
                    await context.SaveChangesAsync();
                }
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
            }
        }
        #endregion

        #region DEletes
        public async Task Delete(Models.ObjetScene objeSc)
        {
            try
            {
                var context = CreateContext();
                var toDelete = await context._ObjetScene.FindAsync(objeSc.Id);
                if (toDelete != null)
                {
                    context._ObjetScene.Remove(toDelete);
                    await context.SaveChangesAsync();
                }
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public async Task Delete(Models.ObjetsQuete objeQt)
        {
            try
            {
                var context = CreateContext();
                var toDelete = await context._ObjetsQuete.FindAsync(objeQt.Id);
                if (toDelete != null)
                {
                    context._ObjetsQuete.Remove(toDelete);
                    await context.SaveChangesAsync();
                }
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public async Task Delete(Models.PartisQuete partQt)
        {
            try
            {
                var context = CreateContext();
                var toDelete = await context._PartisQuete.FindAsync(partQt.Id);
                if (toDelete != null)
                {
                    context._PartisQuete.Remove(toDelete);
                    await context.SaveChangesAsync();
                }
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public async Task Delete(Models.PlotPointsQuete pptQt)
        {
            try
            {
                var context = CreateContext();
                var toDelete = await context._PlotPointsQuete.FindAsync(pptQt.Id);
                if (toDelete != null)
                {
                    context._PlotPointsQuete.Remove(toDelete);
                    await context.SaveChangesAsync();
                }
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public async Task Delete(Models.PNJ peunj)
        {
            try
            {
                var context = CreateContext();
                var toDelete = await context._PNJ.FindAsync(peunj.Id);
                if (toDelete != null)
                {
                    context._PNJ.Remove(toDelete);
                    await context.SaveChangesAsync();
                }
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public async Task Delete(Models.PNJScene pnjscn)
        {
            try
            {
                var context = CreateContext();
                var toDelete = await context._PNJScene.FindAsync(pnjscn.Id);
                if (toDelete != null)
                {
                    context._PNJScene.Remove(toDelete);
                    await context.SaveChangesAsync();
                }
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public async Task Delete(Models.Quete quet)
        {
            try
            {
                var context = CreateContext();
                var toDelete = await context._Quete.FindAsync(quet.Id);
                if (toDelete != null)
                {
                    context._Quete.Remove(toDelete);
                    await context.SaveChangesAsync();
                }
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public async Task Delete(Models.Scene scen)
        {
            try
            {
                var context = CreateContext();
                var toDelete = await context._Scene.FindAsync(scen.Id);
                if (toDelete != null)
                {
                    context._Scene.Remove(toDelete);
                    await context.SaveChangesAsync();
                }
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public async Task Delete(Models.Spots spot)
        {
            try
            {
                var context = CreateContext();
                var toDelete = await context._Spots.FindAsync(spot.Id);
                if (toDelete != null)
                {
                    context._Spots.Remove(toDelete);
                    await context.SaveChangesAsync();
                }
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public async Task Delete(Models.TypoQuete typoQt)
        {
            try
            {
                var context = CreateContext();
                var toDelete = await context._TypoQuete.FindAsync(typoQt.Id);
                if (toDelete != null)
                {
                    context._TypoQuete.Remove(toDelete);
                    await context.SaveChangesAsync();
                }
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public async Task Delete(Models.TypoSpot typoSp)
        {
            try
            {
                var context = CreateContext();
                var toDelete = await context._TypoSpot.FindAsync(typoSp.Id);
                if (toDelete != null)
                {
                    context._TypoSpot.Remove(toDelete);
                    await context.SaveChangesAsync();
                }
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
            }
        }
        #endregion

        #region Gets
        public async Task<Models.ObjetScene> GetObjetScene(Guid pId)
        {
            try
            {
                var context = CreateContext();
                var toGet = await context
                ._ObjetScene
                .Where(t => t.Id == pId)
                .Select(t => new Models.ObjetScene
                {
                    ObjetId = t.ObjetId,
                    SceneId = t.SceneId,
                    RoleObjet = t.RoleObjet,
                    Id = t.Id,
                })
                .FirstOrDefaultAsync();
                return toGet;
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        public async Task<Models.ObjetsQuete> GetObjetsQuete(Guid pId)
        {
            try
            {
                var context = CreateContext();
                var toGet = await context
                ._ObjetsQuete
                .Where(t => t.Id == pId)
                .Select(t => new Models.ObjetsQuete(t.Id,t.QueteId,t.NomObjet,t.PrezObjet,t.SituationDebJeu,t.Effet,t.Image,t.PPLieId,t.StatuValidId,t.StockId,t.ExisteDeja,t.EstDisponible,t.EstDemande,t.DemandeResaOK))
                .FirstOrDefaultAsync();
                return toGet;
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        public async Task<Models.PartisQuete> GetPartisQuete(Guid pId)
        {
            try
            {
                var context = CreateContext();
                var toGet = await context
                ._PartisQuete
                .Where(t => t.Id == pId)
                .Select(t => new Models.PartisQuete
                {
                    Id = t.Id,
                    QueteId = t.QueteId,
                    NomParti = t.NomParti,
                    Synopsis = t.Synopsis,
                    But = t.But,
                    DebutEnJeu = t.DebutEnJeu,
                    FinEnJeu = t.FinEnJeu,

                })
                .FirstOrDefaultAsync();
                return toGet;
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        public async Task<Models.PlotPointsQuete> GetPlotPointsQuete(Guid pId)
        {
            try
            {
                var context = CreateContext();
                var toGet = await context
                ._PlotPointsQuete
                .Where(t => t.Id == pId)
                .Select(t => new Models.PlotPointsQuete
                {
                    Id = t.Id,
                    NomPlotPoint = t.NomPlotPoint,
                    DescrptPP = t.DescrptPP,
                    EstBorneTemps = t.EstBorneTemps,
                    DateDebut = t.DateDebut,
                    DateFin = t.DateFin,
                    EstLiéPP = t.EstLiéPP,
                    EstLiéQuete = t.EstLiéQuete,
                    EstLiéParti = t.EstLiéParti,
                    QueteId = t.QueteId,
                    ParentPPId = t.ParentPPId,
                    ParentPPQueteId = t.ParentPPQueteId,
                    PartiId = t.PartiId,

                })
                .FirstOrDefaultAsync();
                return toGet;
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        public async Task<Models.PNJ> GetPNJ(Guid pId)
        {
            try
            {
                var context = CreateContext();
                var toGet = await context
                ._PNJ
                .Where(t => t.Id == pId)
                .Select(t => new Models.PNJ
                {
                    Id = t.Id,
                    NomPNJ = t.NomPNJ,
                    DescrptPNJ = t.DescrptPNJ,
                    DescrptCostume = t.DescrptCostume,
                    DescrptAttitude = t.DescrptAttitude,

                })
                .FirstOrDefaultAsync();
                return toGet;
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        public async Task<Models.PNJScene> GetPNJScene(Guid pId)
        {
            try
            {
                var context = CreateContext();
                var toGet = await context
                ._PNJScene
                .Where(t => t.Id == pId)
                .Select(t => new Models.PNJScene
                {
                    PNJId = t.PNJId,
                    SceneId = t.SceneId,
                    DescriptionRoleScene = t.DescriptionRoleScene,
                    Remarques = t.Remarques,
                    Id = t.Id,

                })
                .FirstOrDefaultAsync();
                return toGet;
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        public async Task<Models.Quete> GetQuete(Guid pId)
        {
            try
            {
                var context = CreateContext();
                var toGet = await context
                ._Quete
                .Where(t => t.Id == pId)
                .Select(t => new Models.Quete(t.Id,t.TitreQuete,t.ReferentId,t.StatuValidId,t.TypoQueteId,t.ProjetId,t.SynopsisQuete))
                .FirstOrDefaultAsync();
                return toGet;
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        public async Task<Models.Scene> GetScene(Guid pId)
        {
            try
            {
                var context = CreateContext();
                var toGet = await context
                ._Scene
                .Where(t => t.Id == pId)
                .Select(t => new Models.Scene
                {
                    Id = t.Id,
                    DateDebut = t.DateDebut,
                    DateFin = t.DateFin,
                    QueteId = t.QueteId,
                    SpotId = t.SpotId,
                    DescriptionScene = t.DescriptionScene,

                })
                .FirstOrDefaultAsync();
                return toGet;
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        public async Task<Models.Spots> GetSpots(Guid pId)
        {
            try
            {
                var context = CreateContext();
                var toGet = await context
                ._Spots
                .Where(t => t.Id == pId)
                .Select(t => new Models.Spots(t.Id,t.NomSpot,t.TypeSpotId,t.StatuValidId,t.Img))
                .Select(t => new Models.Spots
                {
                    Id = t.Id,
                    NomSpot = t.NomSpot,
                    TypeSpotId = t.TypeSpotId,
                    StatuValidId = t.StatuValidId,
                    Img = t.Img,

                })
                .FirstOrDefaultAsync();
                return toGet;
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        public async Task<Models.TypoQuete> GetTypoQuete(Guid pId)
        {
            try
            {
                var context = CreateContext();
                var toGet = await context
                ._TypoQuete
                .Where(t => t.Id == pId)
                .Select(t => new Models.TypoQuete
                {
                    Id = t.Id,
                    TypeQuete = t.TypeQuete,

                })
                .FirstOrDefaultAsync();
                return toGet;
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        public async Task<Models.TypoSpot> GetTypoSpot(Guid pId)
        {
            try
            {
                var context = CreateContext();
                var toGet = await context
                ._TypoSpot
                .Where(t => t.Id == pId)
                .Select(t => new Models.TypoSpot
                {
                    Id = t.Id,
                    TypeSpot = t.TypeSpot,

                })
                .FirstOrDefaultAsync();
                return toGet;
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }    
        #endregion
    }
}
