using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace ATSCheckPoint3
{
    public class Terminal : INotifyPropertyChanged
    {
        private StateTerminal stateTerminal;

        public StateTerminal StateTerminal
        {
            get { return stateTerminal; }
            set
            {
                stateTerminal = value;
                NotifyPropertyChanged("StateTerminal");
            }
        }

        protected virtual void NotifyPropertyChanged(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public event EventHandler<CallEventArgs> Call;

        public void ToBeginCall(SubscriberNumber number)
        {
            StateTerminal = StateTerminal.Call; 
            
            if (Call != null)
            {
                Call(this, new CallEventArgs(number));
            }
        }
    }
}
