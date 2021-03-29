using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace TimeStruct
{
    namespace TimeStruct
    {
        /// <summary>
        ///  Immutable struct Time that represents the times in 24-hours format without date.
        /// </summary>
        public struct Time : IEquatable<Time>
        {
            public Time(int minutes)
                : this(minutes / 60, minutes % 60)
            {
            }

            public Time(int hours, int minutes)
            {
                hours = (hours + (minutes / 60)) % 24;
                minutes %= 60;
                if (minutes < 0)
                {
                    hours--;
                    minutes += 60;
                }

                this.Minutes = minutes;
                this.Hours = hours >= 0 ? hours : hours + 24;
            }

            public int Hours { get; private set; }

            public int Minutes { get; private set; }

            public static Time operator +(Time left, int addMinutes)
            {
                return new Time(left.Hours, left.Minutes + addMinutes);
            }

            public static Time operator -(Time left, int subMinutes)
            {
                return new Time(left.Hours, left.Minutes - subMinutes);
            }

            public static bool operator ==(Time left, Time right)
            {
                return left.Equals(right);
            }

            public static bool operator !=(Time left, Time right)
            {
                return !left.Equals(right);
            }

            public static Time Add(Time left, int addMinutes)
            {
                return new Time(left.Hours, left.Minutes + addMinutes);
            }

            public static Time Subtract(Time left, int subMinutes)
            {
                return new Time(left.Hours, left.Minutes - subMinutes);
            }

            public new string ToString()
            {
                string strHours = this.Hours > 9 ? this.Hours.ToString(CultureInfo.InvariantCulture) : "0" + this.Hours;
                string strMinutes = this.Minutes > 9 ? this.Minutes.ToString(CultureInfo.InvariantCulture) : "0" + this.Minutes;
                return $"{strHours}:{strMinutes}";
            }

            public override bool Equals(object obj)
            {
                if (obj == null || this.GetType() != obj.GetType())
                {
                    return false;
                }

                return this.Equals((Time)obj);
            }

            public bool Equals(Time other)
            {
                return this.GetHashCode() == other.GetHashCode();
            }

            public override int GetHashCode()
            {
                return (this.Hours * 60) + this.Minutes;
            }
        }
    }
}
