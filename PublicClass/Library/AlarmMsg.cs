namespace Library
{
    using System;
    using System.Text;

    public class AlarmMsg
    {
        public string AlarmText;
        public string ClassName;
        public string Code;
        public string FunctionName;

        public AlarmMsg()
        {
            this.ClassName = string.Empty;
            this.FunctionName = string.Empty;
            this.AlarmText = string.Empty;
            this.Code = string.Empty;
        }

        public AlarmMsg(string string_0, string string_1, string string_2)
        {
            this.ClassName = string.Empty;
            this.FunctionName = string.Empty;
            this.AlarmText = string.Empty;
            this.Code = string.Empty;
            this.ClassName = string_0;
            this.FunctionName = string_1;
            this.AlarmText = string_2;
        }

        public string GetMsg()
        {
            string str = " ";
            StringBuilder builder = new StringBuilder();
            builder.Append("Alarm:" + str + DateTime.Now.ToString() + str + this.Code);
            builder.Append(str + this.ClassName);
            builder.Append(str + this.FunctionName);
            builder.Append(str + this.AlarmText);
            builder.Append(str + Environment.NewLine);
            return builder.ToString();
        }
    }
}

