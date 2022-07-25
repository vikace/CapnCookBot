using Discord;
using System;
using System.Threading.Tasks;
using Discord.WebSocket;
namespace echo
{
    public class Program
    {
        private DiscordSocketClient _client;

        public static void Main(string[] args)
            => new Program().MainAsync().GetAwaiter().GetResult();

        public async Task MainAsync()
        {
            _client = new DiscordSocketClient();
            _client.Log += Log;
            await _client.LoginAsync(TokenType.Bot,
                "MTAwMTAyMzY4MDU4OTA5MDgxOQ.Ge9Ut5.8N6-VeyDqa7I5vOLU4j4ag6dZdQwN69hCp6uSQ");
            await _client.StartAsync();
            _client.MessageReceived += pong;
            _client.MessageReceived += Count;
            await Task.Delay(-1);
        }
        public async Task Count(SocketMessage e)
        {

            if ()
        }
        public async Task pong(SocketMessage e)
        {
            string str = (e.ToString()).ToLower();
            if (str.Equals("ping"))
            {
                await e.Channel.SendMessageAsync("pong");
            }
        }
        private Task Log(LogMessage msg)
        {
            Console.WriteLine(msg);
            return Task.CompletedTask;
        }
    }
}
