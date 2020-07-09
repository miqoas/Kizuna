using System;
using System.Reflection;
using System.Text;
using McMaster.Extensions.CommandLineUtils;

namespace Kizuna
{
    [Command(
        Name = "Kizuna",
        FullName = "Kizuna",
        Description = "A tool to encrypt and decrypt files using AES-256-GCM encryption."
    )]
    [Subcommand(typeof(Commands.GenerateKeyCommand))]
    [Subcommand(typeof(Commands.EncryptCommand))]
    [Subcommand(typeof(Commands.DecryptCommand))]
    public class Program
    {
        public static int Main(string[] args)
        {
            var app = new CommandLineApplication<Program>();
            app.HelpOption();

            Console.OutputEncoding = Encoding.UTF8;
            app.Conventions.UseDefaultConventions();

            if (args.Length == 0)
            {
                app.ShowHelp();
            }

            try
            {
                app.Execute(args);
            }
            catch
            {
                return 1;
            }

            return 0;
        }

        private int OnExecute(CommandLineApplication app)
        {
            return 0;
        }
    }
}