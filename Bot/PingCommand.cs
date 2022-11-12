#region

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSharpPlus;
using DSharpPlus.Entities;
using DSharpPlus.SlashCommands;

#endregion

namespace ActiveDeveloperBadge.Bot
{
    public class PingCommand : ApplicationCommandModule
    {

        [SlashCommand("ping", "Ping command.")]
        public async Task Ping(InteractionContext c)
        {

            await c.CreateResponseAsync(InteractionResponseType.ChannelMessageWithSource, new DiscordInteractionResponseBuilder()
                .WithContent($"Hi, {c.User.Username}."));

        }

    }
}