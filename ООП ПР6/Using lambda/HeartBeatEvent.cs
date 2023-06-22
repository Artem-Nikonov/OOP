using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeasuringDevice 
{
    public class HeartBeatEventArgs: EventArgs
    {
        public HeartBeatEventArgs() : base()
        {
            TimeStamp = DateTime.Now;
        }
        public DateTime TimeStamp { get; }

    }

    public delegate void HeartBeatEventHandler(object sender, HeartBeatEventArgs args);
}
