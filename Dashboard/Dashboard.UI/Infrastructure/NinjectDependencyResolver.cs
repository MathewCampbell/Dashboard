using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Ninject;
using Moq;
using Dashboard.Domain.Abstract;
using Dashboard.Domain.Concrete;
using Dashboard.Domain.Entities;

namespace Dashboard.UI.Infrastructure 
{
    public class NinjectDependencyResolver : IDependencyResolver 
    {
        private IKernel kernel;

        public NinjectDependencyResolver(IKernel kernelParam) 
        {
            kernel = kernelParam;
            AddBindings();
        }

        public object GetService(Type serviceType) 
        {
            return kernel.TryGet(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType) 
        {
            return kernel.GetAll(serviceType);
        }

        private void AddBindings()
        {
            kernel.Bind<IHealthBoardRepository>().To<EFProductRepository>();

            //Mock<IHealthBoardRepository> mock = new Mock<IHealthBoardRepository>();
            //mock.Setup(m => m.HealthBoards).Returns(new List<HealthBoard> {
            //    new HealthBoard { HealthBoardId = 1, HealthBoardName = "ABMu", StatudId = 1},
            //    new HealthBoard { HealthBoardId = 2, HealthBoardName = "BCu", StatudId = 2 },
            //    new HealthBoard { HealthBoardId = 3, HealthBoardName = "CTu", StatudId = 3 }
            //});
            //kernel.Bind<IHealthBoardRepository>().ToConstant(mock.Object);
        }
    }
}
