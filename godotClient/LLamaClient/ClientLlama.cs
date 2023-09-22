using System;
using System.Diagnostics;
using System.Net.WebSockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace godotllama2.LLamaClient
{
    public static class EventType
    {
        public const string
            generate = "generate",
            compare = "compare";
    }


    public class ClientLlama
    {
        private ClientWebSocket clientWebSocket;

        private readonly string serverAddress;
        private bool threadLock;

        public ClientLlama(string serverAddress)
        {
            this.serverAddress = serverAddress;
            threadLock = false;
        }

        public async Task Start()
        {
            Console.WriteLine("Connecting to server: ", serverAddress);
            clientWebSocket = new ClientWebSocket();
            await clientWebSocket.ConnectAsync(new Uri(serverAddress), CancellationToken.None);
            Console.WriteLine("Connected to server");
        }


        private async Task GracefulShutdown()
        {
            if (clientWebSocket.State == WebSocketState.Open)
            {
                await clientWebSocket.CloseAsync(WebSocketCloseStatus.NormalClosure, "Closing", CancellationToken.None);
            }
        }

            public async Task<string> SendMessageToServer(string message, int maxTokens = 20, float temperature = 0.8f)
        {
            while (threadLock)
            {
                Console.WriteLine("Waiting for thread lock");
                await Task.Delay(5000);
            }

            threadLock = true;
            ChatMessage chatMessage = new()
            {
                event_type = EventType.generate,
                text = message,
                max_tokens = maxTokens,
                temp = temperature
            };

            string jsonMessage = JsonConvert.SerializeObject(chatMessage);

            byte[] messageBytes = Encoding.UTF8.GetBytes(jsonMessage);
            await clientWebSocket.SendAsync(new ArraySegment<byte>(messageBytes), WebSocketMessageType.Text, true, CancellationToken.None);
            Console.WriteLine($"Message sent: {message}");

            byte[] buffer = new byte[1024];
            var receiveResult = await clientWebSocket.ReceiveAsync(new ArraySegment<byte>(buffer), CancellationToken.None);
            if (receiveResult.MessageType == WebSocketMessageType.Text)
            {
                string receivedMessage = Encoding.UTF8.GetString(buffer, 0, receiveResult.Count);
                Console.WriteLine($"Message received: {receivedMessage}");
                threadLock = false;
                return receivedMessage;
            }
            threadLock = false;
            Debug.WriteLine("No response received");
            return null;
        }
    }
}