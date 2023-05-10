using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SleepHours
{
    public class SleepPeriods
    {
        static string FormatTime(int[] time)
        {
            return $"{time[0]:00}:{time[1]:00}";
        }

        public List<string> Garps(int[] startTime, int[] endTime)
        {
            List<string> result = new List<string>();
            int[] currentHours = startTime;
            string lastGarps;
            if (endTime[1] > startTime[1])
            {
                result = MakeGarps(currentHours, endTime[0]);
                result.Add(MakeLastPeriod(startTime[1], endTime[0], endTime));
            }
            else if (endTime[1] < startTime[1])
            {
                result = MakeGarps(currentHours, (endTime[0] - 1));
                result.Add(MakeLastPeriod(startTime[1], (endTime[0] - 1), endTime));
            }
            else if (endTime[1] == startTime[1])
            {
                result = MakeGarps(currentHours, endTime[0]);
            }
            return result;
        }

        static string MakeLastPeriod(int start, int end, int[] endTime)
        {
            int[] firstLastGarp = new int[] { end, start };
            return $"{FormatTime(firstLastGarp)}-{FormatTime(endTime)}";
        }

        static List<string> MakeGarps(int[] currentHours, int end)
        {
            List<string> periods = new List<string>();
            while (currentHours[0] != end)
            {
                string firstGarp = FormatTime(currentHours);
                if (currentHours[0] == 24) currentHours[0] = 0;
                currentHours[0]++;
                string secondGarp = FormatTime(currentHours);
                string resultValue = $"{firstGarp}-{secondGarp}";
                periods.Add(resultValue);
            }
            return periods;
        }

        public void СonsoleОutput(List<string> garps)
        {

            Console.WriteLine("Your sleep periods:");

            foreach (string garp in garps)
            {
                Console.WriteLine(garp);
            }
        }
    }
}
