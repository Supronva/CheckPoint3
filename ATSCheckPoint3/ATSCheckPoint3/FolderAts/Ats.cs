using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;

namespace ATSCheckPoint3
{
    public class Ats
    {
        public List<int> SubscriberNumber { get; set; }
        public List<Port> Ports { get; set; }
        public List<Terminal> Terminals { get; set; }
        public Dictionary<Terminal, Port> TerminalsPortsConnections { get; set; }
        public List<Contract> Contracts { get; set; }

        public Ats(List<int> number, List<Terminal> terminals, List<Port> ports)
        {
            SubscriberNumber = number;
            Terminals = terminals;
            Ports = ports;
            foreach (var terminal in Terminals)
            {
                terminal.PropertyChanged += ChangeStateOfTerminal;
            }
        }

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

        public Contract CreateContract(TariffPlan plan, Client client)
        {
            var newSubscriber = new Subscriber(client.Person, new SubscriberNumber(GenerateNewSubscriberNumber()), GetTermenal());
            var contract = new Contract(newSubscriber);
            contract.CreatePlanHistory(DateTime.Now, plan);
            Contracts.Add(contract);
            return contract;
        }

        private Port FindusedPort(Terminal terminal)
        {
            return TerminalsPortsConnections.First(x => x.Key == terminal).Value;
        }

        private Port FindFreePort()
        {
            return Ports.First(x => x.StatePort == StatePort.Ready);
        }

        private void ChangeStateOfTerminal(object s,PropertyChangedEventArgs e)
        {
            if (e.PropertyName != "StateTerminal") return;
            var terminal = s as Terminal;
            if (terminal == null) return;
            if (!Terminals.Contains(terminal)) return;
            switch (terminal.StateTerminal)
            {
                case StateTerminal.On:
                    var newPortConct = FindFreePort();
                    newPortConct.StatePort = StatePort.Busy;
                    TerminalsPortsConnections.Add(terminal, newPortConct);
                    newPortConct.Conect(terminal);
                    break;
                case StateTerminal.Off:
                    var usedPort = FindusedPort(terminal);
                    usedPort.StatePort = StatePort.Ready;
                    TerminalsPortsConnections.Remove(terminal);
                    usedPort.UnConect(terminal);
                    break;
            }
        }
    }
}
