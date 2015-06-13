using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ATSCheckPoint3
{
    public class HistoryTariffPlan
    {
        public Subscriber TheSubscriber { get; set; }
        private Dictionary<DateTime, TariffPlan> History { get; set; }

        private KeyValuePair<DateTime, TariffPlan> LastChangeHistory
        {
            get { return History.Last(); }
        }

        public string ChangePlan(DateTime date, TariffPlan plan)
        {
            if (date.Month - LastChangeHistory.Key.Month > 0)
            {
                History.Add(date,plan);
                return "You change the tariff";
            }
            else
            {
                return "Tariff change can be once a month";
            }
        }

        public HistoryTariffPlan(Subscriber subscriber, DateTime date, TariffPlan plan)
        {
            History.Add(date, plan);
            this.TheSubscriber = subscriber;
        }

    }
}
