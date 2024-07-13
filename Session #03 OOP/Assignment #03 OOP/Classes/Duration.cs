using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment__03_OOP.Classes
{
    public class Duration
    {
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }
        public Duration() { }

        public Duration(int hours, int minutes, int seconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
        }

        public Duration(int seconds)
        {
            Hours = seconds / 3600;
            seconds %= 3600;
            Minutes = seconds / 60;
            Seconds = seconds % 60;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            Duration other = (Duration)obj;
            return (Hours == other.Hours) && (Minutes == other.Minutes) && (Seconds == other.Seconds);
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(Hours, Minutes, Seconds);
        }
        public override string ToString()
        {
            if(Hours > 0)
                return $"Hours: {Hours}, Minutes: {Minutes}, Seconds: {Seconds}";
            return $"Minutes: {Minutes}, Seconds: {Seconds}";

        }
        public static Duration operator + (Duration a, Duration b)
        {
            return new Duration
            {
                Hours = a.Hours + b.Hours,
                Minutes = a.Minutes + b.Minutes,
                Seconds = a.Seconds + b.Seconds
            };
        }
        public static Duration operator + (Duration a, int seconds)
        {
            int H = seconds / 3600;
            seconds %= 3600;
            int M = seconds / 60;
            int S = seconds % 60;

            return new Duration
            {
                Hours = a.Hours + H,
                Minutes = a.Minutes + M,
                Seconds = a.Seconds + S
            };
        }
        public static Duration operator + ( int seconds, Duration a)
        {
            int H = seconds / 3600;
            seconds %= 3600;
            int M = seconds / 60;
            int S = seconds % 60;

            return new Duration
            {
                Hours = a.Hours + H,
                Minutes = a.Minutes + M,
                Seconds = a.Seconds + S
            };
        }
        public static Duration operator ++ (Duration a)
        {
            return new Duration
            {
                Hours = a.Hours,
                Minutes = a.Minutes + 1,
                Seconds = a.Seconds
            };
        }
        public static Duration operator -- (Duration a)
        {
            return new Duration
            {
                Hours = a.Hours,
                Minutes = a.Minutes - 1,
                Seconds = a.Seconds
            };
        }
        public static Duration operator - (Duration a, Duration b)
        {
            return new Duration
            {
                Hours = Math.Abs(a.Hours - b.Hours),
                Minutes = Math.Abs(a.Minutes - b.Minutes),
                Seconds = Math.Abs(a.Seconds - b.Seconds)
            };
        }
        public static bool operator > (Duration a, Duration b)
        {
            if (a.Hours > b.Hours) return true;
            else if (a.Hours == b.Hours)
                if (a.Minutes > b.Minutes)
                    return true;
                else if (a.Minutes == b.Minutes)
                    if (a.Seconds > b.Seconds)
                        return true;
            return false;
        }
        public static bool operator <(Duration a, Duration b)
        {
            if (a.Hours < b.Hours) return true;
            else if (a.Hours == b.Hours)
                if (a.Minutes < b.Minutes)
                    return true;
                else if (a.Minutes == b.Minutes)
                    if (a.Seconds < b.Seconds)
                        return true;
            return false;
        }
        public static bool operator >=(Duration a, Duration b)
        {
            if (a.Hours >= b.Hours) return true;
            else if (a.Hours == b.Hours)
                if (a.Minutes >= b.Minutes)
                    return true;
                else if (a.Minutes == b.Minutes)
                    if (a.Seconds >= b.Seconds)
                        return true;
            return false;
        }
        public static bool operator <=(Duration a, Duration b)
        {
            if (a.Hours <= b.Hours) return true;
            else if (a.Hours == b.Hours)
                if (a.Minutes <= b.Minutes)
                    return true;
                else if (a.Minutes == b.Minutes)
                    if (a.Seconds <= b.Seconds)
                        return true;
            return false;
        }

        public static implicit operator bool(Duration a)
        {
            return a != null && (a.Hours != 0 || a.Minutes != 0 || a.Seconds != 0);
        }

        public static explicit operator DateTime(Duration d)
        {
            return new DateTime(1, 1, 1, d.Hours, d.Minutes, d.Seconds);
        }

    }
}
