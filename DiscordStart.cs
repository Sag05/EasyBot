using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discord;
using Discord.WebSocket;


namespace EasyBot
{
    internal class DiscordStart
    {
        public static DiscordStart instance;

        public static async Task StartBot(string token)
        {
            instance = new DiscordStart();
            instance.MainAsync(token).GetAwaiter().GetResult();
        }
            
        public DiscordSocketClient _client;


        public async Task MainAsync(string token)
        {
            var socketConfig = new DiscordSocketConfig
            {
                GatewayIntents = GatewayIntents.AllUnprivileged | GatewayIntents.GuildMembers | GatewayIntents.GuildBans
            };

            _client = new DiscordSocketClient(socketConfig);

            _client.Log += Log;

            await _client.LoginAsync(TokenType.Bot, token);
            await _client.StartAsync();

            await Task.Delay(-1);
        }

        private Task Log(LogMessage msg)
        {
            Form1.outputAddText(msg.ToString());
            Console.WriteLine(msg.ToString());
            return Task.CompletedTask;
        }
    }
}
