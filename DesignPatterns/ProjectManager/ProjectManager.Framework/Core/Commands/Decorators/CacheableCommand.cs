using ProjectManager.Framework.Core.Commands.Contracts;
using ProjectManager.Framework.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManager.Framework.Core.Commands.Decorators
{
    public class CacheableCommand : ICommand
    {
        private readonly ICommand command;
        private readonly ICachingService cachingService;

        public CacheableCommand(ICommand command, ICachingService cachingService)
        {
            this.command = command;
            this.cachingService = cachingService;
        }

        public int ParameterCount
        {
            get
            {
                return this.command.ParameterCount;
            }
        }

        public string Execute(IList<string> parameters)
        {
           throw new NotImplementedException();
        }
    }
}
