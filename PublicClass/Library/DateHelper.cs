namespace Library
{
    using System;

    public class DateHelper : Base
    {
        public DateTime DateTimeFormat(string string_0)
        {
            DateTime time;
            try
            {
                time = DateTime.ParseExact(string_0, "yyyyMMddHHmmss", null);
            }
            catch (Exception exception)
            {
                throw exception;
            }
            return time;
        }

        public string GetCurrentDate()
        {
            return DateTime.Now.ToString("yyyy-MM-dd");
        }

        public string GetCurrentDateTime()
        {
            return DateTime.Now.ToString("yyyy-MM-dd hh:ss:ff");
        }
    }
}

