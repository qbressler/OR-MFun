using Ninject;
using ORMNorthwind.Business.Abstract;
using ORMNorthwind.Business.Concrete;
using ORMNothwind.DataAccess.Abstract;
using ORMNothwind.DataAccess.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ORMNorthwind.Web.DependencyResolver
{
    public class NinjectFactoryController:DefaultControllerFactory
    {
        private IKernel _kernel;

        public NinjectFactoryController()
        {
            _kernel = new StandardKernel();
            _kernel.Bind<IProductService>().To<ProductManager>().InSingletonScope();
            _kernel.Bind<IProductDal>().To<ProductDal>().InSingletonScope();

            _kernel.Bind<ICategoryService>().To<CategoryManager>().InSingletonScope();
            _kernel.Bind<ICategoryDal>().To<CategoryDal>().InSingletonScope();
        }

        protected override IController GetControllerInstance(RequestContext requestContext, Type controllerType)
        {
            return controllerType == null ? null : (IController)_kernel.Get(controllerType);
        }
    }
}