using CryptHash.Net;
using McMaster.Extensions.CommandLineUtils;
using System;

namespace Kizuna.Commands
{
    [Command(name: "generate", Description = "Generate a new AES-256 key.")]
    public class GenerateKeyCommand
    {
        private void OnExecute(CommandLineApplication app)
        {
            byte[] key = CommonMethods.Generate256BitKey();

            Console.WriteLine(Convert.ToBase64String(key));
        }
    }
}
