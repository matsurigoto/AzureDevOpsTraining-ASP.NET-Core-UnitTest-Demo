using System;

namespace Demo
{
    public class Greet
    {
        public string SayHello()
        {
            var today = GetToday();
            if (today.Month == 1 && today.Day == 1)
            {
                return "Happy New Year";
            }

            return "Today is not New Year";
        }

        protected virtual DateTime GetToday()
        {
            return DateTime.Today;
        }
    }

}
