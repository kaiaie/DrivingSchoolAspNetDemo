using System;

namespace Kaia.DrivingSchool.Common
{
    public class SystemClock : IClock
    {
        public DateTime Now
        {
            get
            {
                return DateTime.UtcNow;
            }
        }
    }
}
