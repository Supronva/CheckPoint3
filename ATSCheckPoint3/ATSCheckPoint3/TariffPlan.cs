using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ATSCheckPoint3
{
    public abstract class TariffPlan
    {
        public string NameTariffPlan { get; set; }

        protected TariffPlan(string name)
        {
            NameTariffPlan = name;
        }
    }
}
