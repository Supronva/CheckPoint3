using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ATSCheckPoint3
{
    public class Client
    {
        public int IdPerson { get; set; }
        public string Person { get; set; }
        public int Age {
            get { return Age; }
            set
            {
                if(value < 18)
                    throw new Exception("It must be 18 years");
            }
        }
        public List<Contract> Contracts { get; set; }

        public Client(int id,string person, int age)
        {
            Age = age;
            IdPerson = id;
            Person = person;  
        }

        public void AddContract(Contract contract)
        {
            Contracts.Add(contract);
        }
    }
}
