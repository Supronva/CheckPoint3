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
            SubscriberName = name;
            Number = number;
            TheTerminal = terminal;
        }

        public void ToBeginCall(SubscriberNumber number)
        {
            TheTerminal.ToBeginCall(number);
        }

        public void SwitchTerminal(bool onterminal)
        {
            var t = StateTerminal.Off;
            if (onterminal)
            {
                t = StateTerminal.On; 
            }
        }

    }
}

