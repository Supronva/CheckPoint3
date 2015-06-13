using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ATSCheckPoint3
{
    public class Client
    {
        public string Person { get; set; }
        public List<Contract> Contracts { get; set; }

        public Client(string person)
        {
            Person = person;
        }

        public void AddContract(Contract contract)
        {
            Contracts.Add(contract);
        }
    }
}
