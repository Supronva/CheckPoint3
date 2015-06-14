using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ATSCheckPoint3
{
    public class Port
    {
        public StatePort StatePort { get; set; }

        public event EventHandler<CallEventArgs> Call;

        protected virtual void OnCall(object sender, CallEventArgs e)
        {
            StatePort = StatePort.Call;
            if (Call != null)
            {
                Call(this, e);
            }
        }

        public void Conect(Terminal terminal)
        {
            terminal.Call += OnCall;
        }

        public void UnConect(Terminal terminal)
        {
            terminal.Call -= OnCall;
        }
    }
}
