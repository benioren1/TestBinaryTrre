using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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

        public ThreatsNode()
        {
        
        }
        public ThreatsNode(string threatType, int volume, int sophistication, string target)
        { 
           ThreatType = threatType;
            Volume = volume;
           Sophistication = sophistication;
            Target = target;
        
        }


    }
}
