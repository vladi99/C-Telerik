using Bytes2you.Validation;
using ProjectManager.Framework.Core.Commands.Contracts;
using ProjectManager.Framework.Core.Common.Contracts;
using ProjectManager.Framework.Core.Common.Exceptions;
using ProjectManager.Framework.Core.Common.Providers;
using System;

namespace ProjectManager.Framework.Core
{
    public class Engine : IEngine
    {
        private readonly ILogger logger;
        private readonly IProcessor processor;
        private readonly ICommandsFactory commandsFactory;

        public Engine(ILogger logger, ICommandsFactory commandsFactory, IProcessor processor)
        {
            this.logger = logger;
            this.commandsFactory = commandsFactory;
            this.processor = processor;
        }
     
        public void Start()
        {
            for (;;)
            {
                var commandLine = Console.ReadLine();

                if (commandLine.ToLower() == "exit")
                {
                    Console.WriteLine("Program terminated.");
                    break;
                }

                try
                {
                    var executionResult = this.processor.ProcessCommand(commandLine);
                    Console.WriteLine(executionResult);
                }
                catch (UserValidationException ex)
                {
                    this.logger.Error(ex.Message);
                    Console.WriteLine(ex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Opps, something happened. Check the log file :(");
                    this.logger.Error(ex.Message);
                }
            }
        }
    }
}
