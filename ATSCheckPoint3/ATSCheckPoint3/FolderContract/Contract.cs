using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ATSCheckPoint3
{
    public class Contract
    {
        public Subscriber TheSubscriber { get; set; }
        public double StateOfBalance { get; set; }
        public HistoryTariffPlan HistoryTariff { get; set; }

        public void CreatePlanHistory(DateTime date, TariffPlan plan)
        {
            HistoryTariff = new HistoryTariffPlan(TheSubscriber, date, plan);
        }

        public Contract(Subscriber subscriber)
        {
            TheSubscriber = subscriber;
        }
    }
}