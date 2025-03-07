using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpecFlow_DMQAutomation.Utils
{
    public class WebDriverConfig
    {
        //This implementation defines a default wait for all elements in the project
        public static readonly TimeSpan DefaultTimeout = TimeSpan.FromSeconds(10);
    }
}