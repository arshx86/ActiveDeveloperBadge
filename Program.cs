using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ActiveDeveloperBadge
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Title = "ActiveDeveloperBadge";
            Console.Clear();
            Console.WriteLine("Paste bot token:");
            string BotToken = Console.ReadLine();

            Console.WriteLine("Paste client ID:");
            string ClientID = Console.ReadLine();

            Console.WriteLine("Bot invite link opened in browser, please invite to any server and press any key.");
            Thread.Sleep(3000);

            string InvLink = $"https://discord.com/api/oauth2/authorize?client_id={ClientID}&permissions=36510369792&scope=bot%20applications.commands";
            Process.Start(new ProcessStartInfo
            {
                FileName = InvLink,
                UseShellExecute = true
            });

            Console.ReadKey();

            Console.WriteLine("Executing global commands...");
            new Bot.BotManager(BotToken).Run().GetAwaiter().GetResult();

        }
    }
}
