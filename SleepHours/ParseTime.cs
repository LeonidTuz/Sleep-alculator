using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SleepHours
{
    public class ParseTime
    {
        public int[] HowTime(string time)
        {
            string[] timeArray = time.Split(":");
            int hours;
            int minutes;

            if (timeArray.Length < 2)
            {
                hours = int.Parse(timeArray[0]);
                minutes = 0;
            }
            else
            {
                hours = int.Parse(timeArray[0]);
                minutes = int.Parse(timeArray[1]);
            }
            int[] result = new int[] { hours, minutes };
            return result;
        }

        public string ResultTime(int[] start, int[] end)
        {
            if (start[0] > end[0])
            {
                end[0] += 24;
            }
            if (start[1] > end[1])
            {
                end[1] += 60;
            }
            int[] timeDelta = new int[] { (end[0] - start[0]), (end[1] - start[1]) };

            return $"All your sleep lasted: {timeDelta[0]} hours, {timeDelta[1]} minutes";
        }
    }
}
