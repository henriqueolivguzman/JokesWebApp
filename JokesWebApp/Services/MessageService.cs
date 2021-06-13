using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JokesWebApp.Data;
using JokesWebApp.Models;

namespace JokesWebApp.Services
{
    public class MessageService
    {
        private readonly JokesWebAppContext _context;

        public MessageService(JokesWebAppContext context)
        {
            _context = context;
        }
        public void AddMessage(Message message)
        {
            _context.Add(message);
            _context.SaveChanges();
        }
        public void RemoveMessage(Message message)
        {
            _context.Remove(message);
            _context.SaveChanges();
        }

    }
}
