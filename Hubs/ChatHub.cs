using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Razor.Compilation;
using Microsoft.AspNetCore.SignalR;
using SignalRTest.Models;

namespace SignalRBasics.Hubs
{

    public class ChatHub : Hub
    {
        private readonly ApplicationDbContext _context;
        public ChatHub(ApplicationDbContext context)
        {
            _context = context;
        }
        public Task SendMessageToAll(string user, string message)
        {
             

            // Create a new message entity
            var newMessage = new tblMes
            {
                
                User = user,
                Message = message,
                Timestamp = DateTime.Now // You may want to use a timestamp or datetime property
            };
            
            // Assuming _context is your DbContext
           // _context.tblMes.Add(newMessage);

            // Save the changes to the database
             //_context.SaveChanges();
            Clients.All.SendAsync("RecievedMessage", user, message);
            return Task.CompletedTask;
            
        }

    }
}
