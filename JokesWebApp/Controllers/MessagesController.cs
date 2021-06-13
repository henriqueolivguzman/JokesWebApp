using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JokesWebApp.Services;
using JokesWebApp.Models;

namespace JokesWebApp.Controllers
{
    public class MessagesController : Controller
    {
        private readonly MessageService _messageService;

        public MessagesController(MessageService messageService)
        {
            _messageService = messageService;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddMessage(Message message)
        {
            _messageService.AddMessage(message);
            return RedirectToAction(nameof(Index));
        }

    }
}
