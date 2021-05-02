using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookOfHeroes.Data
{
    public class MessageService
    {
        public event EventHandler MessagesUpdated;

        public List<string> Messages => messages;

        private readonly List<string> messages = new List<string>();

        public void Add(string messge)
        {
            messages.Add(messge);
            MessagesUpdated?.Invoke(this, new EventArgs());
        }

        public void Clear()
        {
            messages.Clear();
            MessagesUpdated?.Invoke(this, new EventArgs());
        }
    }
}
