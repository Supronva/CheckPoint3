using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATSCheckPoint3
{
    class Program
    {
        private static List<Port> Ports()
        {
            var ports = new List<Port>
            {
                new Port() {StatePort = StatePort.Ready},
            };
            return ports;
        }

        private static List<Terminal> Terminals()
        {
            var terminals = new List<Terminal>
                {
                    new Terminal() {StateTerminal = StateTerminal.On},
                };
            return terminals;
        }

        private static void Main(string[] args)
        {
           
            var listNumbers = new List<int> { 1, 2, 3, 4 };
            var terminals = Terminals();
            var ports = Ports();
            var beltelecom = new Ats(listNumbers, terminals, ports);
            SubscriberNumber t = new SubscriberNumber(767676);
            var vitali = new Client(1, "Виталий", 24);
            var abonentvitali = vitali.Contracts.First().TheSubscriber;
            abonentvitali.SwitchTerminal(true);
            abonentvitali.ToBeginCall(t);
        }


       
    }
}
