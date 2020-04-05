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
                    //ajouter les champs séparés par des , 
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
                    //ajouter les champs séparés par des , 
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
                    //ajouter les champs séparés par des , 
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
                var created = new Data.Projet
                {
                    //ajouter les champs séparés par des , 
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
                    //ajouter les champs séparés par des , 
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
                var created = new Data.Social
                {
                    //ajouter les champs séparés par des , 
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
                    //ajouter les champs séparés par des , 
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
                    //ajouter les champs séparés par des , 
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
                    //mise à jour des champs séparation ;
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
                    //mise à jour des champs séparation ;
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
                    //mise à jour des champs séparation ;
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
                    //mise à jour des champs séparation ;
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
                if (toUpdate != null)
                {
                    //mise à jour des champs séparation ;
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
                    //mise à jour des champs séparation ;
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
                if (toUpdate != null)
                {
                    //mise à jour des champs séparation ;
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
                    //mise à jour des champs séparation ;
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
                    //mise à jour des champs séparation ;
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
                .Select(t => new Models.Adresse
                {
    //récupérer les valeurs des champs
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
                //récupérer les valeurs des champs
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
    //récupérer les valeurs des champs
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
    //récupérer les valeurs des champs
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
                .Select(t => new Models.Projet
                {
                    //récupérer les valeurs des champs
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
    //récupérer les valeurs des champs
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
                .Select(t => new Models.Social
                {
    //récupérer les valeurs des champs
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
    //récupérer les valeurs des champs
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
                    //récupérer les valeurs des champs
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
