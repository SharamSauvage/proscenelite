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
    public class RepertoireUniv2Jeu : RepertoireBase<ProsceneContext>, IRepertoireUniv2Jeu
    {
        public RepertoireUniv2Jeu(DbContextOptions<ProsceneContext> options)
            : base(options)
        {

        }

        #region CReates
        public async Task<Guid> Create(Models.Alignement alig)
        {
            try
            {
                var context = CreateContext();
                var created = new Data.Alignement
                {
                    //ajouter les champs séparés par des , 
                };
                var enr = await context
                ._Alignement
                .AddAsync(created);
                await context.SaveChangesAsync();

                return enr.Entity.Id;
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
                return alig.Id;
            }
        }

        public async Task<Guid> Create(Models.Archetype arch)
        {
            try
            {
                var context = CreateContext();
                var created = new Data.Archetype
                {
                    //ajouter les champs séparés par des , 
                };
                var enr = await context
                ._Archetype
                .AddAsync(created);
                await context.SaveChangesAsync();

                return enr.Entity.Id;
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
                return arch.Id;
            }
        }

        public async Task<Guid> Create(Models.Calendrier cale)
        {
            try
            {
                var context = CreateContext();
                var created = new Data.Calendrier
                {
                    //ajouter les champs séparés par des , 
                };
                var enr = await context
                ._Calendrier
                .AddAsync(created);
                await context.SaveChangesAsync();

                return enr.Entity.Id;
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
                return cale.Id;
            }
        }

        public async Task<Guid> Create(Models.CalendriersMultiples cale)
        {
            try
            {
                var context = CreateContext();
                var created = new Data.CalendriersMultiples
                {
                    //ajouter les champs séparés par des , 
                };
                var enr = await context
                ._CalendriersMultiples
                .AddAsync(created);
                await context.SaveChangesAsync();

                return enr.Entity.Id;
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
                return cale.Id;
            }
        }

        public async Task<Guid> Create(Models.Caracteristiques cara)
        {
            try
            {
                var context = CreateContext();
                var created = new Data.Caracteristiques
                {
                    //ajouter les champs séparés par des , 
                };
                var enr = await context
                ._Caracteristiques
                .AddAsync(created);
                await context.SaveChangesAsync();

                return enr.Entity.Id;
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
                return cara.Id;
            }
        }

        public async Task<Guid> Create(Models.ClasseMetier clas)
        {
            try
            {
                var context = CreateContext();
                var created = new Data.ClasseMetier
                {
                    //ajouter les champs séparés par des , 
                };
                var enr = await context
                ._ClasseMetier
                .AddAsync(created);
                await context.SaveChangesAsync();

                return enr.Entity.Id;
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
                return clas.Id;
            }
        }

        public async Task<Guid> Create(Models.Competences comp)
        {
            try
            {
                var context = CreateContext();
                var created = new Data.Competences
                {
                    //ajouter les champs séparés par des , 
                };
                var enr = await context
                ._Competences
                .AddAsync(created);
                await context.SaveChangesAsync();

                return enr.Entity.Id;
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
                return comp.Id;
            }
        }

        public async Task<Guid> Create(Models.Mois mois)
        {
            try
            {
                var context = CreateContext();
                var created = new Data.Mois
                {
                    //ajouter les champs séparés par des , 
                };
                var enr = await context
                ._Mois
                .AddAsync(created);
                await context.SaveChangesAsync();

                return enr.Entity.Id;
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
                return mois.Id;
            }
        }

        public async Task<Guid> Create(Models.Organisations organs)
        {
            try
            {
                var context = CreateContext();
                var created = new Data.Organisations
                {
                    //ajouter les champs séparés par des , 
                };
                var enr = await context
                ._Organisations
                .AddAsync(created);
                await context.SaveChangesAsync();

                return enr.Entity.Id;
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
                return organs.Id;
            }
        }

        public async Task<Guid> Create(Models.PaysContree payscontr)
        {
            try
            {
                var context = CreateContext();
                var created = new Data.PaysContree
                {
                    //ajouter les champs séparés par des , 
                };
                var enr = await context
                ._PaysContree
                .AddAsync(created);
                await context.SaveChangesAsync();

                return enr.Entity.Id;
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
                return payscontr.Id;
            }
        }

        public async Task<Guid> Create(Models.Race rac)
        {
            try
            {
                var context = CreateContext();
                var created = new Data.Race
                {
                    //ajouter les champs séparés par des , 
                };
                var enr = await context
                ._Race
                .AddAsync(created);
                await context.SaveChangesAsync();

                return enr.Entity.Id;
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
                return rac.Id;
            }
        }

        public async Task<Guid> Create(Models.Religion relig)
        {
            try
            {
                var context = CreateContext();
                var created = new Data.Religion
                {
                    //ajouter les champs séparés par des , 
                };
                var enr = await context
                ._Religion
                .AddAsync(created);
                await context.SaveChangesAsync();

                return enr.Entity.Id;
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
                return relig.Id;
            }
        }

        public async Task<Guid> Create(Models.TyposUnivers typoUn)
        {
            try
            {
                var context = CreateContext();
                var created = new Data.TyposUnivers
                {
                    //ajouter les champs séparés par des , 
                };
                var enr = await context
                ._TyposUnivers
                .AddAsync(created);
                await context.SaveChangesAsync();

                return enr.Entity.Id;
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
                return typoUn.Id;
            }
        }

        public async Task<Guid> Create(Models.Univers univ)
        {
            try
            {
                var context = CreateContext();
                var created = new Data.Univers
                {
                    //ajouter les champs séparés par des , 
                };
                var enr = await context
                ._Univers
                .AddAsync(created);
                await context.SaveChangesAsync();

                return enr.Entity.Id;
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
                return univ.Id;
            }
        }
        #endregion

        #region Updates
        public async Task Update(Models.Alignement alig)
        {
            try
            {
                var context = CreateContext();
                var toUpdate = await context._Alignement.FindAsync(alig.Id);
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

        public async Task Update(Models.Archetype arch)
        {
            try
            {
                var context = CreateContext();
                var toUpdate = await context._Archetype.FindAsync(arch.Id);
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

        public async Task Update(Models.Calendrier cale)
        {
            try
            {
                var context = CreateContext();
                var toUpdate = await context._Calendrier.FindAsync(cale.Id);
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

        public async Task Update(Models.CalendriersMultiples cale)
        {
            try
            {
                var context = CreateContext();
                var toUpdate = await context._CalendriersMultiples.FindAsync(cale.Id);
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

        public async Task Update(Models.Caracteristiques cara)
        {
            try
            {
                var context = CreateContext();
                var toUpdate = await context._Caracteristiques.FindAsync(cara.Id);
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

        public async Task Update(Models.ClasseMetier clas)
        {
            try
            {
                var context = CreateContext();
                var toUpdate = await context._ClasseMetier.FindAsync(clas.Id);
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

        public async Task Update(Models.Competences comp)
        {
            try
            {
                var context = CreateContext();
                var toUpdate = await context._Competences.FindAsync(comp.Id);
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

        public async Task Update(Models.Mois mois)
        {
            try
            {
                var context = CreateContext();
                var toUpdate = await context._Mois.FindAsync(mois.Id);
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

        public async Task Update(Models.Organisations organs)
        {
            try
            {
                var context = CreateContext();
                var toUpdate = await context._Organisations.FindAsync(organs.Id);
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

        public async Task Update(Models.PaysContree payscontr)
        {
            try
            {
                var context = CreateContext();
                var toUpdate = await context._PaysContree.FindAsync(payscontr.Id);
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

        public async Task Update(Models.Race rac)
        {
            try
            {
                var context = CreateContext();
                var toUpdate = await context._Race.FindAsync(rac.Id);
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

        public async Task Update(Models.Religion relig)
        {
            try
            {
                var context = CreateContext();
                var toUpdate = await context._Religion.FindAsync(relig.Id);
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

        public async Task Update(Models.TyposUnivers typoUn)
        {
            try
            {
                var context = CreateContext();
                var toUpdate = await context._TyposUnivers.FindAsync(typoUn.Id);
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

        public async Task Update(Models.Univers univ)
        {
            try
            {
                var context = CreateContext();
                var toUpdate = await context._Univers.FindAsync(univ.Id);
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
        public async Task Delete(Models.Alignement alig)
        {
            try
            {
                var context = CreateContext();
                var toDelete = await context._Alignement.FindAsync(alig.Id);
                if (toDelete != null)
                {
                    context._Alignement.Remove(toDelete);
                    await context.SaveChangesAsync();
                }
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public async Task Delete(Models.Archetype arch)
        {
            try
            {
                var context = CreateContext();
                var toDelete = await context._Archetype.FindAsync(arch.Id);
                if (toDelete != null)
                {
                    context._Archetype.Remove(toDelete);
                    await context.SaveChangesAsync();
                }
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public async Task Delete(Models.Calendrier cale)
        {
            try
            {
                var context = CreateContext();
                var toDelete = await context._Calendrier.FindAsync(cale.Id);
                if (toDelete != null)
                {
                    context._Calendrier.Remove(toDelete);
                    await context.SaveChangesAsync();
                }
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public async Task Delete(Models.CalendriersMultiples cale)
        {
            try
            {
                var context = CreateContext();
                var toDelete = await context._CalendriersMultiples.FindAsync(cale.Id);
                if (toDelete != null)
                {
                    context._CalendriersMultiples.Remove(toDelete);
                    await context.SaveChangesAsync();
                }
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public async Task Delete(Models.Caracteristiques cara)
        {
            try
            {
                var context = CreateContext();
                var toDelete = await context._Caracteristiques.FindAsync(cara.Id);
                if (toDelete != null)
                {
                    context._Caracteristiques.Remove(toDelete);
                    await context.SaveChangesAsync();
                }
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public async Task Delete(Models.ClasseMetier clas)
        {
            try
            {
                var context = CreateContext();
                var toDelete = await context._ClasseMetier.FindAsync(clas.Id);
                if (toDelete != null)
                {
                    context._ClasseMetier.Remove(toDelete);
                    await context.SaveChangesAsync();
                }
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public async Task Delete(Models.Competences comp)
        {
            try
            {
                var context = CreateContext();
                var toDelete = await context._Competences.FindAsync(comp.Id);
                if (toDelete != null)
                {
                    context._Competences.Remove(toDelete);
                    await context.SaveChangesAsync();
                }
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public async Task Delete(Models.Mois mois)
        {
            try
            {
                var context = CreateContext();
                var toDelete = await context._Mois.FindAsync(mois.Id);
                if (toDelete != null)
                {
                    context._Mois.Remove(toDelete);
                    await context.SaveChangesAsync();
                }
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public async Task Delete(Models.Organisations organs)
        {
            try
            {
                var context = CreateContext();
                var toDelete = await context._Organisations.FindAsync(organs.Id);
                if (toDelete != null)
                {
                    context._Organisations.Remove(toDelete);
                    await context.SaveChangesAsync();
                }
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public async Task Delete(Models.PaysContree payscontr)
        {
            try
            {
                var context = CreateContext();
                var toDelete = await context._PaysContree.FindAsync(payscontr.Id);
                if (toDelete != null)
                {
                    context._PaysContree.Remove(toDelete);
                    await context.SaveChangesAsync();
                }
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public async Task Delete(Models.Race rac)
        {
            try
            {
                var context = CreateContext();
                var toDelete = await context._Race.FindAsync(rac.Id);
                if (toDelete != null)
                {
                    context._Race.Remove(toDelete);
                    await context.SaveChangesAsync();
                }
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public async Task Delete(Models.Religion relig)
        {
            try
            {
                var context = CreateContext();
                var toDelete = await context._Religion.FindAsync(relig.Id);
                if (toDelete != null)
                {
                    context._Religion.Remove(toDelete);
                    await context.SaveChangesAsync();
                }
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public async Task Delete(Models.TyposUnivers typoUn)
        {
            try
            {
                var context = CreateContext();
                var toDelete = await context._TyposUnivers.FindAsync(typoUn.Id);
                if (toDelete != null)
                {
                    context._TyposUnivers.Remove(toDelete);
                    await context.SaveChangesAsync();
                }
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public async Task Delete(Models.Univers univ)
        {
            try
            {
                var context = CreateContext();
                var toDelete = await context._Univers.FindAsync(univ.Id);
                if (toDelete != null)
                {
                    context._Univers.Remove(toDelete);
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
        public async Task<Models.Alignement> GetAlignement(Guid pId)
        {
            try
            {
                var context = CreateContext();
                var toGet = await context
                ._Alignement
                .Where(t => t.Id == pId)
                .Select(t => new Models.Alignement
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

        public async Task<Models.Archetype> GetArchetype(Guid pId)
        {
            try
            {
                var context = CreateContext();
                var toGet = await context
                ._Archetype
                .Where(t => t.Id == pId)
                .Select(t => new Models.Archetype
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

        public async Task<Models.Calendrier> GetCalendrier(Guid pId)
        {
            try
            {
                var context = CreateContext();
                var toGet = await context
                ._Calendrier
                .Where(t => t.Id == pId)
                .Select(t => new Models.Calendrier
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

        public async Task<Models.CalendriersMultiples> GetCalendriersMultiples(Guid pId)
        {
            try
            {
                var context = CreateContext();
                var toGet = await context
                ._CalendriersMultiples
                .Where(t => t.Id == pId)
                .Select(t => new Models.CalendriersMultiples
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

        public async Task<Models.Caracteristiques> GetCaracteristiques(Guid pId)
        {
            try
            {
                var context = CreateContext();
                var toGet = await context
                ._Caracteristiques
                .Where(t => t.Id == pId)
                .Select(t => new Models.Caracteristiques
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

        public async Task<Models.ClasseMetier> GetClasseMetier(Guid pId)
        {
            try
            {
                var context = CreateContext();
                var toGet = await context
                ._ClasseMetier
                .Where(t => t.Id == pId)
                .Select(t => new Models.ClasseMetier
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

        public async Task<Models.Competences> GetCompetences(Guid pId)
        {
            try
            {
                var context = CreateContext();
                var toGet = await context
                ._Competences
                .Where(t => t.Id == pId)
                .Select(t => new Models.Competences
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

        public async Task<Models.Mois> GetMois(Guid pId)
        {
            try
            {
                var context = CreateContext();
                var toGet = await context
                ._Mois
                .Where(t => t.Id == pId)
                .Select(t => new Models.Mois
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

        public async Task<Models.Organisations> GetOrganisations(Guid pId)
        {
            try
            {
                var context = CreateContext();
                var toGet = await context
                ._Organisations
                .Where(t => t.Id == pId)
                .Select(t => new Models.Organisations
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

        public async Task<Models.PaysContree> GetPaysContree(Guid pId)
        {
            try
            {
                var context = CreateContext();
                var toGet = await context
                ._PaysContree
                .Where(t => t.Id == pId)
                .Select(t => new Models.PaysContree
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

        public async Task<Models.Race> GetRace(Guid pId)
        {
            try
            {
                var context = CreateContext();
                var toGet = await context
                ._Race
                .Where(t => t.Id == pId)
                .Select(t => new Models.Race
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

        public async Task<Models.Religion> GetReligion(Guid pId)
        {
            try
            {
                var context = CreateContext();
                var toGet = await context
                ._Religion
                .Where(t => t.Id == pId)
                .Select(t => new Models.Religion
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

        public async Task<Models.TyposUnivers> GetTyposUnivers(Guid pId)
        {
            try
            {
                var context = CreateContext();
                var toGet = await context
                ._TyposUnivers
                .Where(t => t.Id == pId)
                .Select(t => new Models.TyposUnivers
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

        public async Task<Models.Univers> GetUnivers(Guid pId)
        {
            try
            {
                var context = CreateContext();
                var toGet = await context
                ._Univers
                .Where(t => t.Id == pId)
                .Select(t => new Models.Univers
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
