namespace CadastroLivros.MVC.App_Start
{
    using System;
    using CadastroLivros.Application;
    using CadastroLivros.Application.Interfaces;
    using CadastroLivros.Domain.Interfaces.Repositories;
    using CadastroLivros.Domain.Interfaces.Services;
    using CadastroLivros.Domain.Services;
    using CadastroLivros.Infra.Data.Repositories;
    using Ninject;
    using System.Collections.Generic;
    using System.Web.Mvc;

    public class NinjectDependencyResolver : IDependencyResolver
    {
        private IKernel kernel;

        public NinjectDependencyResolver()
        {
            // Initialize kernel and add bindings
            kernel = new StandardKernel();
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
            kernel.Bind<IAppLivroService>().To<AppLivroService>();
            kernel.Bind<IAppAssuntoService>().To<AppAssuntoService>();
            kernel.Bind<IAppAutorService>().To<AppAutorService>();

            kernel.Bind(typeof(IBaseRepository<>)).To(typeof(BaseRepository<>));
            kernel.Bind<ILivroRepository>().To<LivroRepository>();
            kernel.Bind<IAssuntoRepository>().To<AssuntoRepository>();
            kernel.Bind<IAutorRepository>().To<AutorRepository>();

            kernel.Bind<ILivroService>().To<LivroService>();
            kernel.Bind<IAutorService>().To<AutorService>();
            kernel.Bind<IAssuntoService>().To<AssuntoService>();
        }
    }
}
