namespace PublicClass.WebGisService
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;

    [DesignerCategory("code"), DebuggerStepThrough, GeneratedCode("System.Web.Services", "2.0.50727.3053")]
    public class GetAllMapNamesCompletedEventArgs : AsyncCompletedEventArgs
    {
        private object[] results;

        internal GetAllMapNamesCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
        {
            this.results = results;
        }

        public string[] Result
        {
            get
            {
                base.RaiseExceptionIfNecessary();
                return (string[]) this.results[0];
            }
        }
    }
}

