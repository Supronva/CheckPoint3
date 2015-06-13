using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;

namespace ATSCheckPoint3
{
    public class ATS
    {
        public List<int> SubscriberNumber { get; set; }
        public List<Port> Ports { get; set; }
        public List<Terminal> Terminals { get; set; }
        public List<Contract> Contracts { get; set; }



        private int GenerateNewSubscriberNumber()
        {
            var number = SubscriberNumber.First();
            SubscriberNumber.Remove(number);
            return number;
        }

        private Terminal GetTermenal()
        {
            var termenal =Terminals.First();
            Terminals.Remove(termenal);
            return termenal;

        }
    }
}
