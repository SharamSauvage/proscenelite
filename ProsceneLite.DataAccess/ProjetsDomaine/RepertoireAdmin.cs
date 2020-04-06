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
    public class RepertoireAdmin : RepertoireBase<ProsceneContext>, IRepertoireAdmin
    {
        public RepertoireAdmin(DbContextOptions<ProsceneContext> options)
            : base(options)
        {

        }
        #region CReates
        public async Task<Guid> Create(Models.Adresse adre)
        {
            try
            {
                var context = CreateContext();
                var created = new Data.Adresse
                {
                    //ajouter les champs séparés par des , 
                    Id=adre.Id,
                    Num=adre.Num,
                    NomVoie=adre.NomVoie,
                    CodePostal=adre.CodePostal,
                    Ville=adre.Ville,
                    Region=adre.Region,
                    Pays=adre.Pays,
                };
                var enr = await context
                ._Adresse
                .AddAsync(created);
                await context.SaveChangesAsync();

                return enr.Entity.Id;
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
                return adre.Id;
            }
        }

        public async Task<Guid> Create(Models.AdressesUtilisateurs adreutil)
        {
            try
            {
                var context = CreateContext();
                var created = new Data.AdressesUtilisateurs
                {
                    UtilisateurId = adreutil.UtilisateurId,
                    AdresseId = adreutil.AdresseId,
                    Id = adreutil.Id,
                };
                var enr = await context
                ._AdressesUtilisateurs
                .AddAsync(created);
                await context.SaveChangesAsync();

                return enr.Entity.Id;
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
                return adreutil.Id;
            }
        }

        public async Task<Guid> Create(Models.Inscrits insc)
        {
            try
            {
                var context = CreateContext();
                var created = new Data.Inscrits
                {
                    Id = insc.Id,
                    Nom = insc.Nom,
                    Prenom = insc.Prenom,
                    CptFacebook = insc.CptFacebook,
                    AdEmail = insc.AdEmail,
                    AdresseId = insc.AdresseId,
                    DdN = insc.DdN,
                    ReglementOK = insc.ReglementOK,
                    EstPJ = insc.EstPJ,
                    EstPNJ = insc.EstPNJ,
                    EstOrga = insc.EstOrga,
                };
                var enr = await context
                ._Inscrits
                .AddAsync(created);
                await context.SaveChangesAsync();

                return enr.Entity.Id;
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
                return insc.Id;
            }
        }

        public async Task<Guid> Create(Models.Pays ppays)
        {
            try
            {
                var context = CreateContext();
                var created = new Data.Pays
                {
                    Id = ppays.Id,
                    NomPays = ppays.NomPays,
                };
                var enr = await context
                ._Pays
                .AddAsync(created);
                await context.SaveChangesAsync();

                return enr.Entity.Id;
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
                return ppays.Id;
            }
        }

        public async Task<Guid> Create(Models.Projet proj)
        {
            try
            {
                var context = CreateContext();
                int Ti,Ts;
                Ts = proj.TypoStockageId switch
                {
                    TypoStockage.Distribue => Ts = 0,
                    TypoStockage.Centralise => Ts = 1,
                    TypoStockage.Mixte => Ts = 2,
                    _ => Ts=0,
                };
                Ti = proj.TypoInscriptions switch
                {
                    TypoInscription.Invitation => Ti = 0,
                    TypoInscription.Publique => Ti = 1,
                    TypoInscription.Mixte => Ti = 2,
                    _ => Ti = 0,
                };
                var created = new Data.Projet
                {
                    Id = proj.Id,
                    Nom = proj.Nom,
                    UniversId = proj.UniversId,
                    TypoStockageId = Ts,
                    DateDébutJeu = proj.DateDébutJeu,
                    DateFinJeu = proj.DateFinJeu,
                    DateDebutInstal = proj.DateDebutInstal,
                    DateFinRangement = proj.DateFinRangement,
                    NbPJ = proj.NbPJ,
                    NbPNJ = proj.NbPNJ,
                    NbOrgas = proj.NbOrgas,
                    PrxPJ = proj.PrxPJ,
                    PrxPNJ = proj.PrxPNJ,
                    PrxOrga = proj.PrxOrga,
                    RepasInclus = proj.RepasInclus,
                    CouchagesInclus = proj.CouchagesInclus,
                    NbCouchages = proj.NbCouchages,
                    TypoInscriptions = Ti,
                    TerrainId = proj.TerrainId,
                };
                var enr = await context
                ._Projet
                .AddAsync(created);
                await context.SaveChangesAsync();

                return enr.Entity.Id;
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
                return proj.Id;
            }
        }

        public async Task<Guid> Create(Models.ProjetsUtilisateurs projutil)
        {
            try
            {
                var context = CreateContext();
                var created = new Data.ProjetsUtilisateurs
                {
                    ProjetId = projutil.ProjetId,
                    UtilisateurId = projutil.UtilisateurId,
                    Id = projutil.Id,
                };
                var enr = await context
                ._ProjetsUtilisateurs
                .AddAsync(created);
                await context.SaveChangesAsync();

                return enr.Entity.Id;
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
                return projutil.Id;
            }
        }

        public async Task<Guid> Create(Models.Social soci)
        {
            try
            {
                var context = CreateContext();
                int Sc, Sd;
                Sd = soci.StatutDemCtct switch
                {
                    StatuDemContact.envoyee => Sd = 0,
                    StatuDemContact.approuvee => Sd = 1,
                    StatuDemContact.blacklist => Sd = 3,
                    _ => Sc = 0,
                };
                Sc = soci.StatutCtct switch
                {
                    StatuContact.connecte => Sc = 0,
                    StatuContact.occupe => Sc = 1,
                    StatuContact.nepasdéranger => Sc = 2,
                    StatuContact.deretourbientot => Sc = 3,
                    StatuContact.absent => Sc = 4,
                    StatuContact.deconnecte => Sc = 5,
                    _ => Sc = 0,
                };
                var created = new Data.Social
                {
                    Id = soci.Id,
                    UserId = soci.UserId,
                    ContactId = soci.ContactId,
                    StatutDemContact = Sd,
                    StatutContact = Sc,
                };
                var enr = await context
                ._Social
                .AddAsync(created);
                await context.SaveChangesAsync();

                return enr.Entity.Id;
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
                return soci.Id;
            }
        }

        public async Task<Guid> Create(Models.Utilisateurs util)
        {
            try
            {
                var context = CreateContext();
                var created = new Data.Utilisateurs
                {
                    Id = util.Id,
                    Nom = util.Nom,
                    Prenom = util.Prenom,
                    UserName = util.UserName,
                    Email = util.Email,
                    Ddn = util.Ddn,
                    Avatar = util.Avatar,
                };
                var enr = await context
                ._Utilisateurs
                .AddAsync(created);
                await context.SaveChangesAsync();

                return enr.Entity.Id;
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
                return util.Id;
            }
        }

        public async Task<Guid> Create(Models.Voies voie)
        {
            try
            {
                var context = CreateContext();
                var created = new Data.Voies
                {
                    Id = voie.Id,
                    NomVoie = voie.NomVoie,
                };
                var enr = await context
                ._Voies
                .AddAsync(created);
                await context.SaveChangesAsync();

                return enr.Entity.Id;
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
                return voie.Id;
            }
        }
        #endregion

        #region Updates
        public async Task Update(Models.Adresse adre)
        {
            try
            {
                var context = CreateContext();
                var toUpdate = await context._Adresse.FindAsync(adre.Id);
                if (toUpdate != null)
                {
                    toUpdate.Id = adre.Id;
                    toUpdate.Num = adre.Num;
                    toUpdate.Voie = adre.Voie;
                    toUpdate.NomVoie = adre.NomVoie;
                    toUpdate.CodePostal = adre.CodePostal;
                    toUpdate.Ville = adre.Ville;
                    toUpdate.Region = adre.Region;
                    toUpdate.Pays = adre.Pays;

                    await context.SaveChangesAsync();
                }
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public async Task Update(Models.AdressesUtilisateurs adreutil)
        {
            try
            {
                var context = CreateContext();
                var toUpdate = await context._AdressesUtilisateurs.FindAsync(adreutil.Id);
                if (toUpdate != null)
                {
                    toUpdate.UtilisateurId = adreutil.UtilisateurId;
                    toUpdate.AdresseId = adreutil.AdresseId;
                    toUpdate.Id = adreutil.Id;

                    await context.SaveChangesAsync();
                }
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public async Task Update(Models.Inscrits insc)
        {
            try
            {
                var context = CreateContext();
                var toUpdate = await context._Inscrits.FindAsync(insc.Id);
                if (toUpdate != null)
                {
                    toUpdate.Id = insc.Id;
                    toUpdate.Nom = insc.Nom;
                    toUpdate.Prenom = insc.Prenom;
                    toUpdate.CptFacebook = insc.CptFacebook;
                    toUpdate.AdEmail = insc.AdEmail;
                    toUpdate.AdresseId = insc.AdresseId;
                    toUpdate.DdN = insc.DdN;
                    toUpdate.ReglementOK = insc.ReglementOK;
                    toUpdate.EstPJ = insc.EstPJ;
                    toUpdate.EstPNJ = insc.EstPNJ;
                    toUpdate.EstOrga = insc.EstOrga;

                    await context.SaveChangesAsync();
                }
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public async Task Update(Models.Pays ppays)
        {
            try
            {
                var context = CreateContext();
                var toUpdate = await context._Pays.FindAsync(ppays.Id);
                if (toUpdate != null)
                {
                    toUpdate.Id = ppays.Id;
                    toUpdate.NomPays = ppays.NomPays;

                    await context.SaveChangesAsync();
                }
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public async Task Update(Models.Projet proj)
        {
            try
            {
                var context = CreateContext();
                var toUpdate = await context._Projet.FindAsync(proj.Id);
                int Ti, Ts;
                Ts = proj.TypoStockageId switch
                {
                    TypoStockage.Distribue => Ts = 0,
                    TypoStockage.Centralise => Ts = 1,
                    TypoStockage.Mixte => Ts = 2,
                    _ => Ts = 0,
                };
                Ti = proj.TypoInscriptions switch
                {
                    TypoInscription.Invitation => Ti = 0,
                    TypoInscription.Publique => Ti = 1,
                    TypoInscription.Mixte => Ti = 2,
                    _ => Ti = 0,
                };
                if (toUpdate != null)
                {
                    toUpdate.Id = proj.Id;
                    toUpdate.Nom = proj.Nom;
                    toUpdate.UniversId = proj.UniversId;
                    toUpdate.TypoStockageId = Ts;
                    toUpdate.DateDébutJeu = proj.DateDébutJeu;
                    toUpdate.DateFinJeu = proj.DateFinJeu;
                    toUpdate.DateDebutInstal = proj.DateDebutInstal;
                    toUpdate.DateFinRangement = proj.DateFinRangement;
                    toUpdate.NbPJ = proj.NbPJ;
                    toUpdate.NbPNJ = proj.NbPNJ;
                    toUpdate.NbOrgas = proj.NbOrgas;
                    toUpdate.PrxPJ = proj.PrxPJ;
                    toUpdate.PrxPNJ = proj.PrxPNJ;
                    toUpdate.PrxOrga = proj.PrxOrga;
                    toUpdate.RepasInclus = proj.RepasInclus;
                    toUpdate.CouchagesInclus = proj.CouchagesInclus;
                    toUpdate.NbCouchages = proj.NbCouchages;
                    toUpdate.TypoInscriptions = Ti;
                    toUpdate.TerrainId = proj.TerrainId;

                    await context.SaveChangesAsync();
                }
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public async Task Update(Models.ProjetsUtilisateurs projutil)
        {
            try
            {
                var context = CreateContext();
                var toUpdate = await context._ProjetsUtilisateurs.FindAsync(projutil.Id);
                if (toUpdate != null)
                {
                    toUpdate.ProjetId = projutil.ProjetId;
                    toUpdate.UtilisateurId = projutil.UtilisateurId;
                    toUpdate.Id = projutil.Id;

                    await context.SaveChangesAsync();
                }
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public async Task Update(Models.Social soci)
        {
            try
            {
                var context = CreateContext();
                var toUpdate = await context._Social.FindAsync(soci.Id);
                int Sc, Sd;
                Sd = soci.StatutDemCtct switch
                {
                    StatuDemContact.envoyee => Sd = 0,
                    StatuDemContact.approuvee => Sd = 1,
                    StatuDemContact.blacklist => Sd = 3,
                    _ => Sc = 0,
                };
                Sc = soci.StatutCtct switch
                {
                    StatuContact.connecte => Sc = 0,
                    StatuContact.occupe => Sc = 1,
                    StatuContact.nepasdéranger => Sc = 2,
                    StatuContact.deretourbientot => Sc = 3,
                    StatuContact.absent => Sc = 4,
                    StatuContact.deconnecte => Sc = 5,
                    _ => Sc = 0,
                };
                if (toUpdate != null)
                {
                    toUpdate.Id = soci.Id;
                    toUpdate.UserId = soci.UserId;
                    toUpdate.ContactId = soci.ContactId;
                    toUpdate.StatutDemContact = Sd;
                    toUpdate.StatutContact = Sc;

                    await context.SaveChangesAsync();
                }
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public async Task Update(Models.Utilisateurs util)
        {
            try
            {
                var context = CreateContext();
                var toUpdate = await context._Utilisateurs.FindAsync(util.Id);
                if (toUpdate != null)
                {
                    toUpdate.Id = util.Id;
                    toUpdate.Nom = util.Nom;
                    toUpdate.Prenom = util.Prenom;
                    toUpdate.UserName = util.UserName;
                    toUpdate.Email = util.Email;
                    toUpdate.Ddn = util.Ddn;
                    toUpdate.Avatar = util.Avatar;

                    await context.SaveChangesAsync();
                }
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public async Task Update(Models.Voies voie)
        {
            try
            {
                var context = CreateContext();
                var toUpdate = await context._Voies.FindAsync(voie.Id);
                if (toUpdate != null)
                {
                    toUpdate.Id = voie.Id;
                    toUpdate.NomVoie = voie.NomVoie;

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
        public async Task Delete(Models.Adresse adre)
        {
            try
            {
                var context = CreateContext();
                var toDelete = await context._Adresse.FindAsync(adre.Id);
                if (toDelete != null)
                {
                    context._Adresse.Remove(toDelete);
                    await context.SaveChangesAsync();
                }
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public async Task Delete(Models.AdressesUtilisateurs adreutil)
        {
            try
            {
                var context = CreateContext();
                var toDelete = await context._AdressesUtilisateurs.FindAsync(adreutil.Id);
                if (toDelete != null)
                {
                    context._AdressesUtilisateurs.Remove(toDelete);
                    await context.SaveChangesAsync();
                }
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public async Task Delete(Models.Inscrits insc)
        {
            try
            {
                var context = CreateContext();
                var toDelete = await context._Inscrits.FindAsync(insc.Id);
                if (toDelete != null)
                {
                    context._Inscrits.Remove(toDelete);
                    await context.SaveChangesAsync();
                }
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public async Task Delete(Models.Pays ppays)
        {
            try
            {
                var context = CreateContext();
                var toDelete = await context._Pays.FindAsync(ppays.Id);
                if (toDelete != null)
                {
                    context._Pays.Remove(toDelete);
                    await context.SaveChangesAsync();
                }
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public async Task Delete(Models.Projet proj)
        {
            try
            {
                var context = CreateContext();
                var toDelete = await context._Projet.FindAsync(proj.Id);
                if (toDelete != null)
                {
                    context._Projet.Remove(toDelete);
                    await context.SaveChangesAsync();
                }
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public async Task Delete(Models.ProjetsUtilisateurs projutil)
        {
            try
            {
                var context = CreateContext();
                var toDelete = await context._ProjetsUtilisateurs.FindAsync(projutil.Id);
                if (toDelete != null)
                {
                    context._ProjetsUtilisateurs.Remove(toDelete);
                    await context.SaveChangesAsync();
                }
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public async Task Delete(Models.Social soci)
        {
            try
            {
                var context = CreateContext();
                var toDelete = await context._Social.FindAsync(soci.Id);
                if (toDelete != null)
                {
                    context._Social.Remove(toDelete);
                    await context.SaveChangesAsync();
                }
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public async Task Delete(Models.Utilisateurs util)
        {
            try
            {
                var context = CreateContext();
                var toDelete = await context._Utilisateurs.FindAsync(util.Id);
                if (toDelete != null)
                {
                    context._Utilisateurs.Remove(toDelete);
                    await context.SaveChangesAsync();
                }
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public async Task Delete(Models.Voies voie)
        {
            try
            {
                var context = CreateContext();
                var toDelete = await context._Voies.FindAsync(voie.Id);
                if (toDelete != null)
                {
                    context._Voies.Remove(toDelete);
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
        public async Task<Models.Adresse> GetAdresse(Guid pId)
        {
            try
            {
                var context = CreateContext();
                var toGet = await context
                ._Adresse
                .Where(t => t.Id == pId)
                .Select(t => new Models.Adresse()
                {
                    Id = t.Id,
                    Num = t.Num,
                    Voie = t.Voie,
                    NomVoie = t.NomVoie,
                    CodePostal = t.CodePostal,
                    Ville = t.Ville,
                    Region = t.Region,
                    Pays = t.Pays,
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

        public async Task<Models.AdressesUtilisateurs> GetAdressesUtilisateurs(Guid pId)
        {
            try
            {
                var context = CreateContext();
                var toGet = await context
                ._AdressesUtilisateurs
                .Where(t => t.Id == pId)
                .Select(t => new Models.AdressesUtilisateurs
                {
                    UtilisateurId = t.UtilisateurId,
                    AdresseId = t.AdresseId,
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

        public async Task<Models.Inscrits> GetInscrits(Guid pId)
        {
            try
            {
                var context = CreateContext();
                var toGet = await context
                ._Inscrits
                .Where(t => t.Id == pId)
                .Select(t => new Models.Inscrits
                {
                    Id = t.Id,
                    Nom = t.Nom,
                    Prenom = t.Prenom,
                    CptFacebook = t.CptFacebook,
                    AdEmail = t.AdEmail,
                    AdresseId = t.AdresseId,
                    DdN = t.DdN,
                    ReglementOK = t.ReglementOK,
                    EstPJ = t.EstPJ,
                    EstPNJ = t.EstPNJ,
                    EstOrga = t.EstOrga,
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

        public async Task<Models.Pays> GetPays(Guid pId)
        {
            try
            {
                var context = CreateContext();
                var toGet = await context
                ._Pays
                .Where(t => t.Id == pId)
                .Select(t => new Models.Pays
                {
                    Id = t.Id,
                    NomPays = t.NomPays,
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

        public async Task<Models.Projet> GetProjet(Guid pId)
        {
            try
            {
                var context = CreateContext();
                var toGet = await context
                ._Projet
                .Where(t => t.Id == pId)
                .Select(t => new Models.Projet(t.Id,t.Nom,t.UniversId, t.TypoStockageId, t.DateDébutJeu, t.DateFinJeu, t.DateDebutInstal,t.DateFinRangement, t.NbPJ, t.NbPNJ, t.NbOrgas, t.PrxPJ,t.PrxPNJ,t.PrxOrga, t.RepasInclus, t.CouchagesInclus,t.NbCouchages, t.TypoInscriptions, t.TerrainId))
                .FirstOrDefaultAsync();
                return toGet;
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        public async Task<Models.ProjetsUtilisateurs> GetProjetsUtilisateurs(Guid pId)
        {
            try
            {
                var context = CreateContext();
                var toGet = await context
                ._ProjetsUtilisateurs
                .Where(t => t.Id == pId)
                .Select(t => new Models.ProjetsUtilisateurs
                {
                    ProjetId = t.ProjetId,
                    UtilisateurId = t.UtilisateurId,
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

        public async Task<Models.Social> GetSocial(Guid pId)
        {
            try
            {
                var context = CreateContext();
                var toGet = await context
                ._Social
                .Where(t => t.Id == pId)
                .Select(t=> new Models.Social(t.Id,t.UserId, t.ContactId, t.StatutDemContact, t.StatutContact))
                .FirstOrDefaultAsync();
                return toGet;
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        public async Task<Models.Utilisateurs> GetUtilisateurs(Guid pId)
        {
            try
            {
                var context = CreateContext();
                var toGet = await context
                ._Utilisateurs
                .Where(t => t.Id == pId)
                .Select(t => new Models.Utilisateurs
                {
                    Id = t.Id,
                    Nom = t.Nom,
                    Prenom = t.Prenom,
                    UserName = t.UserName,
                    Email = t.Email,
                    Ddn = t.Ddn,
                    Avatar = t.Avatar,
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

        public async Task<Models.Voies> GetVoies(Guid pId)
        {
            try
            {
                var context = CreateContext();
                var toGet = await context
                ._Voies
                .Where(t => t.Id == pId)
                .Select(t => new Models.Voies
                {
                    Id = t.Id,
                    NomVoie = t.NomVoie,
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
