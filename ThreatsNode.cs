using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFinalFirstWeek
{
    public class ThreatsNode
    {
    
        public string ThreatType { get; set; }
        public int Volume { get; set; }
        public int Sophistication { get; set; }

        public string Target { get; set; }

        public ThreatsNode(string threatType, int volume, int sophistication, string target)
        { 
            this.ThreatType = threatType;
            this.Volume = volume;
            this.Sophistication = sophistication;
            this.Target = target;
        
        }

    }
}
