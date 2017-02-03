using Fina.AvaliacaoTecnica.Domain.Entities;
using Fina.AvaliacaoTecnica.Domain.Interfaces.Services;
using Fina.AvaliacaoTecnica.Interfaces.Repositories;

namespace Fina.AvaliacaoTecnica.Domain.Services
{
    public class ServiceBusiness : ServiceBase<Business>, IServiceBusiness
    {
        public ServiceBusiness(IRepositoryBase<Business> respositoryBase) 
            : base(respositoryBase)
        {
        }
    }
}
