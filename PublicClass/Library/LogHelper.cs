namespace Library
{
    using System;
    using System.IO;

    public class LogHelper : FileHelper
    {
        private const bool IsWriteFlag = true;

        public void DeleteOldRecord(int int_0)
        {
            try
            {
                DirectoryInfo info = new DirectoryInfo(FileHelper.FilePath);
                if (!info.Exists)
                {
                    return;
                }
                foreach (FileInfo info2 in info.GetFiles())
                {
                    if (info2.CreationTime.AddDays((double) int_0).Date < DateTime.Now.Date)
                    {
                        File.Delete(info2.FullName);
                    }
                }
            }
            catch (Exception exception)
            {
                ErrorMsg msg = new ErrorMsg("LogHelper", "清除旧日志文件", exception.Message);
                new LogHelper().WriteError(msg);
                return;
            }
            LogMsg msg2 = new LogMsg("LogHelper", "清除旧日志文件", "成功");
            new LogHelper().WriteLog(msg2);
        }

        public void WriteAlarm(AlarmMsg alarmMsg_0)
        {
            base.WriteText(alarmMsg_0.GetMsg());
        }

        public void WriteAlarm(AlarmMsg alarmMsg_0, string string_0)
        {
            alarmMsg_0.FunctionName = string_0;
            base.WriteText(alarmMsg_0.GetMsg());
        }

        public void WriteError(ErrorMsg errorMsg_0)
        {
            base.WriteText(errorMsg_0.GetMsg());
        }

        public void WriteError(ErrorMsg errorMsg_0, Exception exception_0)
        {
            base.WriteText(errorMsg_0.GetMsg() + "\r\n" + exception_0.Message + "\r\n" + exception_0.StackTrace);
        }

        public void WriteError(ErrorMsg errorMsg_0, Exception exception_0, string string_0)
        {
            errorMsg_0.FunctionName = string_0;
            base.WriteText(errorMsg_0.GetMsg() + "\r\n" + exception_0.Message + "\r\n" + exception_0.StackTrace);
        }

        public void WriteLog(LogMsg logMsg_0)
        {
            base.WriteText(logMsg_0.GetMsg());
        }

        public void WriteLog(LogMsg logMsg_0, string string_0)
        {
            logMsg_0.Msg = string_0;
            base.WriteText(logMsg_0.GetMsg());
        }

        public void WriteLog(LogMsg logMsg_0, string string_0, string string_1)
        {
            logMsg_0.FunctionName = string_0;
            logMsg_0.Msg = string_1;
            base.WriteText(logMsg_0.GetMsg());
        }
    }
}

