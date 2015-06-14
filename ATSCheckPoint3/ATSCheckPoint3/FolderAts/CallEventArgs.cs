using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ATSCheckPoint3
{
    public class CallEventArgs : EventArgs
    {
        public SubscriberNumber Number { get; private set; }

        public CallEventArgs(SubscriberNumber number)
        {
           Number = number;
        }   
    }
}
