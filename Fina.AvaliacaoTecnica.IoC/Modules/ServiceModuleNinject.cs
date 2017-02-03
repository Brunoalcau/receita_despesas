using Fina.AvaliacaoTecnica.Domain.Interfaces.Services;
using Fina.AvaliacaoTecnica.Domain.Services;
using Ninject.Modules;
using Ninject.Web.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fina.AvaliacaoTecnica.IoC.Modules
{
    public class ServiceModuleNinject : NinjectModule
    {
        public override void Load()
        {
            Bind(typeof(IServiceBase<>)).To(typeof(ServiceBase<>)).InRequestScope();
            Bind<IServiceBusiness>().To<ServiceBusiness>();
        }
    }
}
