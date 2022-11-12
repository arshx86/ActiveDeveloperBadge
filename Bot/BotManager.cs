#region

using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using DSharpPlus;
using DSharpPlus.Entities;
using DSharpPlus.EventArgs;
using DSharpPlus.SlashCommands;
using DSharpPlus.SlashCommands.EventArgs;

#endregion

namespace ActiveDeveloperBadge.Bot
{
    public class BotManager
    {

        public static DiscordClient Client { get; set; }
        public BotManager(string Token)
        {

            Client = new DiscordClient(new DiscordConfiguration
            {
                Token = Token,
                TokenType = TokenType.Bot,
            });

            var Slash = Client.UseSlashCommands();

            // global register
            Slash.RegisterCommands<PingCommand>();

            Client.Ready += Ready;

        }

        private async Task Ready(DiscordClient sender, ReadyEventArgs e)
        {
            Console.WriteLine("Ready to execute. Use /ping");
        }

        public async Task Run()
        {
            await Client.ConnectAsync();
            await Task.Delay(-1);
        }
    }
}