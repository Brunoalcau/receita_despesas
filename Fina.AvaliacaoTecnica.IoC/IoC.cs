using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonServiceLocator.NinjectAdapter.Unofficial;
using Microsoft.Practices.ServiceLocation;
using Ninject;
using Fina.AvaliacaoTecnica.IoC.Modules;

namespace Fina.AvaliacaoTecnica.IoC
{
    public class IoC
    {
        public IKernel Kernel { get; private set; }

        public IoC()
        {
            Kernel = GetNinjectModules();
            ServiceLocator.SetLocatorProvider(() => new NinjectServiceLocator(Kernel));
        }
        private IKernel GetNinjectModules()
        {
            return new StandardKernel(
                new RepositoryModuleNinject(),
                new ServiceModuleNinject());
        }
    }
}
