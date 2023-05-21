using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using ServerSignalR.Hubs;

[Route("api/[controller]")]
[ApiController]
public class MessageController : ControllerBase
{
    private readonly IHubContext<MainHub> _hubContext;

    public MessageController(IHubContext<MainHub> hubContext)
    {
        _hubContext = hubContext;
    }

    [HttpPost]
    public async Task SendMensaje(string mensaje)
    {
        await _hubContext.Clients.All.SendAsync("ClientMessage", mensaje);
    }
}