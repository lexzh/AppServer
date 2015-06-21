namespace Library
{
    using System;
    using System.Text;

    public class ErrorMsg
    {
        public string ClassName;
        public string ErrorText;
        public string FunctionName;

        public ErrorMsg()
        {
            this.ClassName = string.Empty;
            this.FunctionName = string.Empty;
            this.ErrorText = string.Empty;
        }

        public ErrorMsg(string string_0, string string_1, string string_2)
        {
            this.ClassName = string.Empty;
            this.FunctionName = string.Empty;
            this.ErrorText = string.Empty;
            this.ClassName = string_0;
            this.FunctionName = string_1;
            this.ErrorText = string_2;
        }

        public string GetMsg()
        {
            string str = " ";
            StringBuilder builder = new StringBuilder();
            builder.Append("Error:" + str + DateTime.Now.ToString());
            builder.Append(str + this.ClassName);
            builder.Append(str + this.FunctionName);
            builder.Append(str + this.ErrorText);
            builder.Append(str + Environment.NewLine);
            return builder.ToString();
        }
    }
}

