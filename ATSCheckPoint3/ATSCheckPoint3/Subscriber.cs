using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ATSCheckPoint3
{
    public class Subscriber
    {
        public string SubscriberName { get; set; }
        public SubscriberNumber Number { get; set; }
        public Terminal TheTerminal { get; set; }

        public Subscriber(string name, SubscriberNumber number, Terminal terminal)
        {
            this.SubscriberName = name;
            this.Number = number;
            this.TheTerminal = terminal;
        }
    }
}
