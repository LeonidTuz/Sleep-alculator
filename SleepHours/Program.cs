using SleepHours;
using System.Diagnostics.CodeAnalysis;
using System.Threading.Channels;

Console.Write("sleep_hours: ");

string time = Console.ReadLine();
string[] timePeriods = time.Split(" ");

HowTimeSleep(time);
SleepPeriodResult(time);

static void HowTimeSleep(string time)
{
    string[] timePeriods = time.Split(" ");
    ParseTime parseTime = new ParseTime();
    int[] startTime = parseTime.HowTime(timePeriods[0]);
    int[] endTime = parseTime.HowTime(timePeriods[1]);
    Console.WriteLine(parseTime.ResultTime(startTime, endTime));
}

static void SleepPeriodResult(string time)
{
    string[] timePeriods = time.Split(" ");
    SleepPeriods sleepPeriods = new SleepPeriods();
    ParseTime parseTime = new ParseTime();
    int[] startTime = parseTime.HowTime(timePeriods[0]);
    int[] endTime = parseTime.HowTime(timePeriods[1]);
    List<string> garps = sleepPeriods.Garps(startTime, endTime);
    sleepPeriods.СonsoleОutput(garps);
}