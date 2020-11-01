[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(CadastroLivros.MVC.App_Start.NinjectWebCommon), "Start")]
[assembly: WebActivatorEx.ApplicationShutdownMethodAttribute(typeof(CadastroLivros.MVC.App_Start.NinjectWebCommon), "Stop")]

namespace CadastroLivros.MVC.App_Start
{
    using System;
    using System.Web;
    using CadastroLivros.Application;
    using CadastroLivros.Application.Interfaces;
    using CadastroLivros.Domain.Interfaces.Repositories;
    using CadastroLivros.Domain.Interfaces.Services;
    using CadastroLivros.Infra.Data.Repositories;
    using Microsoft.Web.Infrastructure.DynamicModuleHelper;

    using Ninject;
    using Ninject.Web.Common;
    using Ninject.Web.Common.WebHost;

    public static class NinjectWebCommon 
    {
        private static readonly Bootstrapper bootstrapper = new Bootstrapper();

        /// <summary>
        /// Starts the application.
        /// </summary>
        public static void Start() 
        {
            DynamicModuleUtility.RegisterModule(typeof(OnePerRequestHttpModule));
            DynamicModuleUtility.RegisterModule(typeof(NinjectHttpModule));
            bootstrapper.Initialize(CreateKernel);
        }

        /// <summary>
        /// Stops the application.
        /// </summary>
        public static void Stop()
        {
            bootstrapper.ShutDown();
        }

        /// <summary>
        /// Creates the kernel that will manage your application.
        /// </summary>
        /// <returns>The created kernel.</returns>
        private static IKernel CreateKernel()
        {
            var kernel = new StandardKernel();
            try
            {
                kernel.Bind<Func<IKernel>>().ToMethod(ctx => () => new Bootstrapper().Kernel);
                kernel.Bind<IHttpModule>().To<HttpApplicationInitializationHttpModule>();
                RegisterServices(kernel);
                return kernel;
            }
            catch
            {
                kernel.Dispose();
                throw;
            }
        }

        /// <summary>
        /// Load your modules or register your services here!
        /// </summary>
        /// <param name="kernel">The kernel.</param>
        private static void RegisterServices(IKernel kernel)
        {
            kernel.Bind(typeof(IAppBaseService<>)).To(typeof(AppServiceBase<>));
            kernel.Bind<IAppLivroService>().To<AppLivroService>();
            kernel.Bind<IAppAssuntoService>().To<AppAssuntoService>();
            kernel.Bind<IAppAutorService>().To<AppAutorService>();

            kernel.Bind(typeof(IBaseRepository<>)).To(typeof(BaseRepository<>));
            kernel.Bind<ILivroRepository>().To<LivroRepository>();
            kernel.Bind<IAssuntoRepository>().To<AssuntoRepository>();
            kernel.Bind<IAutorRepository>().To<AutorRepository>();
        }
    }
}