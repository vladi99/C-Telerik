using System.IO;
using System.Linq;
using System.Reflection;

using Ninject;
using Ninject.Modules;
using Ninject.Extensions.Factory;
using Ninject.Extensions.Conventions;

using ProjectManager.Framework.Core;
using ProjectManager.ConsoleClient.Configs;
using ProjectManager.Framework.Services;
using ProjectManager.Framework.Core.Common.Providers;
using ProjectManager.Framework.Core.Common.Contracts;
using ProjectManager.Framework.Core.Commands.Contracts;
using ProjectManager.Framework.Core.Commands.Creational;
using ProjectManager.Framework.Core.Commands.Listing;
using ProjectManager.Framework.Data;
using ProjectManager.Data;

namespace ProjectManager.Configs
{
    public class NinjectManagerModule : NinjectModule
    {
        private const string CreateUserCommandName = "createuser";
        private const string CreateTaskCommandName = "createtask";
        private const string CreateProjectCommandName = "createproject";
        private const string ListProjectDetailsCommandName = "listprojectdetails";
        private const string ListProjectsCommandName = "listprojects";

        public override void Load()
        {
            Kernel.Bind(x =>
            {
                x.FromAssembliesInPath(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location))
                .SelectAllClasses()
                .Where(type => type != typeof(Engine) && type != typeof(Database))
                .BindDefaultInterface();
            });
            
            IConfigurationProvider configurationProvider = Kernel.Get<IConfigurationProvider>();

            Kernel.Bind<ILogger>().To<FileLogger>().InSingletonScope().WithConstructorArgument(configurationProvider.LogFilePath);

            Kernel.Bind<ICachingService>().To<CachingService>().WithConstructorArgument(configurationProvider.CacheDurationInSeconds);

            Kernel.Bind<IEngine>().To<Engine>().InSingletonScope();
            
            Kernel.Bind<ICommand>().To<CreateUserCommand>().InSingletonScope().Named(CreateUserCommandName);
            Kernel.Bind<ICommand>().To<CreateTaskCommand>().InSingletonScope().Named(CreateTaskCommandName);
            Kernel.Bind<ICommand>().To<CreateProjectCommand>().InSingletonScope().Named(CreateProjectCommandName);
            Kernel.Bind<ICommand>().To<ListProjectDetailsCommand>().InSingletonScope().Named(ListProjectDetailsCommandName);
            Kernel.Bind<ICommand>().To<ListProjectsCommand>().InSingletonScope().Named(ListProjectsCommandName);

            Kernel.Bind<ICommandsFactory>().ToFactory().InSingletonScope();

            Kernel.Bind<ICommand>()
                .ToMethod(context =>
                {
                    string commandName = (string)context.Parameters.First().GetValue(context, null);
                    commandName = commandName.ToLower();

                    ICommand command = context.Kernel.Get<ICommand>(commandName);

                    return command;
                }).NamedLikeFactoryMethod((ICommandsFactory factory) => factory.GetCommandFromString(null));

            Kernel.Bind<IProcessor>().To<CommandProcessor>();

            Kernel.Bind<IDatabase>().To<Database>().InSingletonScope();
            
        }
    }
}
