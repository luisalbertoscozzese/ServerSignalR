using Microsoft.AspNetCore.SignalR;

namespace ServerSignalR.Hubs
{
    public class MainHub : Hub
    {
        public async Task EnviarMensaje(string mensaje)
        {
            mensaje = "Mensaje enviado desde el servidor";
            await Clients.All.SendAsync("ReceiveMessage", mensaje);
        }
    }
}