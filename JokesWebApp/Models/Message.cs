using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JokesWebApp.Models
{
    public class Message
    {
        public int MessageId { get; set; }
        public string UserName { get; set; }
        public string TextMessage { get; set; }

        public Message()
        {
            
        }
    }
}
