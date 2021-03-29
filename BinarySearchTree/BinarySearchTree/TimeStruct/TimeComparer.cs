using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;
using TimeStruct.TimeStruct;

namespace TimeStruct
{
    public class TimeComparer : IComparer<Time>
    {
        public int Compare([AllowNull] Time x, [AllowNull] Time y)
        {
            if ((x.Hours * 60) + x.Minutes == (y.Hours * 60) + y.Minutes)
            {
                return 0;
            }
            else if ((x.Hours * 60) + x.Minutes > (y.Hours * 60) + y.Minutes)
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }
    }
}
