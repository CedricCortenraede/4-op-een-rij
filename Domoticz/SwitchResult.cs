using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4opeenrij.Domoticz
{
    class SwitchResult
    {
        public long ActTime { get; set; }
        public string AppVersion { get; set; }
        public Switch[] Result { get; set; }
        public string Status { get; set; }
        public string Title { get; set; }
    }
}
