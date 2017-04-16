using Ninject;
using Practice.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Practice.Web.App_Start
{
    public class NinjectControllerFactory : DefaultControllerFactory
    {
        public IKernel Kernel { get; private set; }

        public NinjectControllerFactory()
        {
            this.Kernel = new StandardKernel();
            AddBindings();
        }

        protected override IController GetControllerInstance(System.Web.Routing.RequestContext requestContext, Type controllerType)
        {
            IController controller = null;

            if (controllerType != null)
                controller = (IController)Kernel.Get(controllerType);

            return controller;
        }

        private void AddBindings()
        {
            Kernel.Bind<ICustomerRepository>().To<EFCustomerRepository>();
        }
    }
}