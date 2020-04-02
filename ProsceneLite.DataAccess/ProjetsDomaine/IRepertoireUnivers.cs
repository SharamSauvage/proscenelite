using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ProsceneLite.Data;
using ProsceneLite.Models;

namespace ProsceneLite.DataAccess
{
    public interface IRepertoireUnivers
    {
        Task<Guid> Create(Models.TyposUnivers TpU);
        Task Update(Models.TyposUnivers tpu);
        Task Delete(Models.TyposUnivers tpu);
        Task<Models.TyposUnivers> GetTypo(Guid id);

        Task<Guid> Create(Models.Univers univ);
        Task Update(Models.Univers univ);
        Task Delete(Models.Univers univ);
        Task<Models.Univers> GetUnivers(Guid id);

    }
}
