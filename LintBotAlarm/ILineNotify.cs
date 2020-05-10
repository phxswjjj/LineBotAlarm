using System;
using System.Collections.Generic;
using System.Text;

namespace LintBotAlarm
{
    interface ILineNotify
    {
        void SendMessage(string message);
    }
}
