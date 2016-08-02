using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EventTypeModel
{
    public class myEventArgs : EventArgs
    {
        public int EventType { get; private set; }
        public myEventArgs(int EventType)
        {
            this.EventType = EventType;
        }
    }
}
