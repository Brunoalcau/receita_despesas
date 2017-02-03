using Fina.AvaliacaoTecnica.Domain.Entities;
using Fina.AvaliacaoTecnica.Data.Context;
using Fina.AvaliacaoTecnica.Domain.Interfaces.Repositories;

namespace Fina.AvaliacaoTecnica.Data.Repositories
{
    public class BusinessRepository : RepositoryBase<Business>, IRepositoryBusiness
    {
        public BusinessRepository(DatabaseContext _databaseContext) 
            : base(_databaseContext)
        {
        }
    }
}
