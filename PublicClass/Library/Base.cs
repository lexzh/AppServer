namespace Library
{
    using System;
    using System.Diagnostics;

    public class Base
    {
        protected string ConvertNullToEmpty(string string_0)
        {
            if (string_0 == null)
            {
                string_0 = string.Empty;
            }
            return string_0;
        }

        public string GetCallFunction()
        {
            string name = string.Empty;
            StackFrame frame = new StackTrace().GetFrame(2);
            if (frame != null)
            {
                name = frame.GetMethod().Name;
            }
            return name;
        }

        public string GetExceptionMsg(Exception exception_0)
        {
            return (exception_0.Message + exception_0.StackTrace);
        }
    }
}

