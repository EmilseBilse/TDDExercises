using System;

namespace GradingScale
{
    public class Grading : IGrading
    {
        public int ToGrade(int percentage)
        {
            if (percentage is < 0 or > 100)
            {
                throw new ArgumentException();
            }
            if (percentage < 6)
            {
                return -3;
            }
            if (percentage < 50)
            {
                return 0;
            }
            if (percentage < 60)
            {
                return 2;
            }
            if (percentage < 80)
            {
                return 4;
            }
            if (percentage < 85)
            {
                return 7;
            }
            if (percentage < 95)
            {
                return 10;
            }
            return 12;
        }
    }
}