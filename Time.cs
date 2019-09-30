using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace TimeClass
{
    [Serializable]
    public class Time
    {
        public Time()
        {
           
            Hours = Minutes = Seconds = 0;
        }
        public void SubtractTime(Time time, int HoursValue, int MinutesValue, int SecondsValue)
        {
            // in 24 format
            int totalSec = time.Seconds - SecondsValue;
            int totalMinutes = time.Minutes - MinutesValue;
            int totalHours = time.Hours - HoursValue;
                if (totalSec < 0)
                {
                    totalSec += 60;
                    totalMinutes -= 1;
                }
                if (totalMinutes < 0)
                {
                    totalMinutes += 60;
                    totalHours -= 1;
                }

                if (totalHours < 0)
                    totalHours += 24;
                Hours = totalHours;
                Minutes = totalMinutes;
                Seconds = totalSec;
               
            }
        public void PrintTime()
        {
            Console.WriteLine(Hours.ToString().PadLeft(2, '0') +":"+ Minutes.ToString().PadLeft(2, '0') +":"+
                Seconds.ToString().PadLeft(2, '0'));
        }
        public void SetTime(int h, int m, int s)
        {
            //Validate the user input data
            if (((h >= 0 && h < 24) && (m >= 0 && m < 60) && (s >= 0 && s < 60)))
            {
                Hours = h;
                Minutes = m;
                Seconds = s;
            }
            else
                throw new System.ArgumentException("Invalid Time");
        }
      
        public  int Hours { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }
    }
}
