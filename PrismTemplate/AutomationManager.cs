using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrismTemplate
{
    public class AutomationManager : IAutomationManager
    {
        public AutomationManager(string name)
        {
            Name = name;
        }
        public void CskENomerEndo()
        {
            Console.WriteLine("CSKA e Nomer edno");
        }

        public string Name { get; set; }
    }
}
