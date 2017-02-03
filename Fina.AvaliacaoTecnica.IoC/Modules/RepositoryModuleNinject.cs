using Fina.AvaliacaoTecnica.Data;
using Fina.AvaliacaoTecnica.Data.Context;
using Fina.AvaliacaoTecnica.Data.Repositories;
using Fina.AvaliacaoTecnica.Interfaces.Repositories;
using Ninject.Modules;
using Ninject.Web.Common;
using System.Data.Entity;

namespace Fina.AvaliacaoTecnica.IoC.Modules
{
    public class RepositoryModuleNinject : NinjectModule
    {
        public override void Load()
        {
            Bind<DbContext>().To<DatabaseContext>().InRequestScope();
            Bind(typeof(IRepositoryBase<>)).To(typeof(RepositoryBase<>)).InRequestScope();
        }
    }
}
