namespace Library
{
    using System;
    using System.Text;

    public class LogMsg
    {
        public string ClassName;
        public string FunctionName;
        public string Msg;

        public LogMsg()
        {
            this.ClassName = string.Empty;
            this.FunctionName = string.Empty;
            this.Msg = string.Empty;
        }

        public LogMsg(string string_0, string string_1, string string_2)
        {
            this.ClassName = string.Empty;
            this.FunctionName = string.Empty;
            this.Msg = string.Empty;
            this.ClassName = string_0;
            this.FunctionName = string_1;
            this.Msg = string_2;
        }

        public string GetMsg()
        {
            string str = " ";
            StringBuilder builder = new StringBuilder();
            builder.Append("Log:" + str + DateTime.Now.ToString());
            builder.Append(str + this.ClassName);
            builder.Append(str + this.FunctionName);
            builder.Append(str + this.Msg);
            builder.Append(str + Environment.NewLine);
            return builder.ToString();
        }
    }
}

