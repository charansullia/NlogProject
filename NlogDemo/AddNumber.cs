using System;
using System.Collections.Generic;
using System.Text;
using NLog;

namespace NlogDemo
{
    class AddNumber
    {
        static NLog nlog = new NLog();
        public int Addition(int firstnumber, int secondnumber)
        {

            if (firstnumber == 0 || secondnumber == 0)
            {

                nlog.LogInfo("Sub method");
                nlog.LogDebug("Debug Successful");
                nlog.LogError("First number or second number is zero");
                return 0;
            }
            int result = firstnumber + secondnumber;
            nlog.LogInfo("Sub method");
            nlog.LogDebug("Debug Successful");
            nlog.LogWarn("Warning");
            Console.WriteLine(result);
            return result;
        }
    }
}
    
