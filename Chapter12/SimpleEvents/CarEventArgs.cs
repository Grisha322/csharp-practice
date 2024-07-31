using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleEvents
{
    public class CarEventArgs: EventArgs
    {
        public readonly string Message;

        public CarEventArgs(string message)
        {
            Message = message;
        }
    }
}
