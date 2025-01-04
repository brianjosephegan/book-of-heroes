using System;
using System.Collections.Generic;

namespace BookOfHeroes.Data
{
    public class MessageService
    {
        public event EventHandler<string> MessagesUpdated;

        public List<string> Messages => _messages;

        private readonly List<string> _messages = [];

        public void Add(string messge)
        {
            _messages.Add(messge);
            MessagesUpdated?.Invoke(this, messge);
        }
    }
}
