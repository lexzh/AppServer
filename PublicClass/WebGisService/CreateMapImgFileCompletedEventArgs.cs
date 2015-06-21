namespace PublicClass.WebGisService
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;

    [DebuggerStepThrough, DesignerCategory("code"), GeneratedCode("System.Web.Services", "2.0.50727.3053")]
    public class CreateMapImgFileCompletedEventArgs : AsyncCompletedEventArgs
    {
        private object[] results;

        internal CreateMapImgFileCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
        {
            this.results = results;
        }

        public byte[] Result
        {
            get
            {
                base.RaiseExceptionIfNecessary();
                return (byte[]) this.results[0];
            }
        }
    }
}

