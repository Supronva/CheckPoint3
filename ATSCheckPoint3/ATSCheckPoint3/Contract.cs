using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ATSCheckPoint3
{
    public class Contract
    {
        public Subscriber TheSubscriber { get; set; }




        public Contract(Subscriber subscriber)
        {
            this.TheSubscriber = subscriber;
        }

    }
}