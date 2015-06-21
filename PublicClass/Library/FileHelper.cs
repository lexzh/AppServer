namespace Library
{
    using System;
    using System.Collections;
    using System.Configuration;
    using System.Data;
    using System.IO;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using System.Text;
    using System.Threading;

    public class FileHelper : Base
    {
        private static int _Day;
        private static ArrayList _list;
        private static int fielNum;
        protected static string FilePath;
        private const int fileSiza = 0x493e0;
        private static DataSet m_ParamData;
        private const string prxFilename = "-sLog.txt";

        static FileHelper()
        {
            old_acctor_mc();
        }

        private static string GetAssemblyPath()
        {
            string codeBase = Assembly.GetExecutingAssembly().CodeBase;
            string[] strArray = codeBase.Substring(8, codeBase.Length - 8).Split(new char[] { '/' });
            string str2 = "";
            for (int i = 0; i < (strArray.Length - 1); i++)
            {
                str2 = str2 + strArray[i] + "/";
            }
            return str2;
        }

        private static string GetFileName()
        {
            if ((FileName == null) || (FileName.Length <= 0))
            {
                InitFileName();
            }
            if (_Day != DateTime.Today.Day)
            {
                fielNum = 0;
                _Day = DateTime.Today.Day;
                InitFileName();
            }
            FileInfo info = new FileInfo(FileName);
            if (!info.Exists || (info.Length < 0x493e0L))
            {
                goto Label_0105;
            }
            int num = 0;
        Label_008F:;
            FileName = FilePath + @"\" + DateTime.Today.ToString("yyyy-MM-dd") + "-" + num.ToString() + "-sLog.txt";
            info = new FileInfo(FileName);
            if (info.Exists && (!info.Exists || (info.Length >= 0x493e0L)))
            {
                num++;
                goto Label_008F;
            }
            fielNum = num;
        Label_0105:
            return FileName;
        }

        private static void InitFileName()
        {
            FileName = FilePath + @"\" + DateTime.Today.ToString("yyyy-MM-dd") + "-" + fielNum.ToString() + "-sLog.txt";
        }

        private static DataSet LoadParamData()
        {
            DataSet set = new DataSet();
            set.ReadXml(GetAssemblyPath() + @"\param.xml");
            return set;
        }

        private static void old_acctor_mc()
        {
            m_ParamData = LoadParamData();
            _Day = DateTime.Today.Day;
            _list = new ArrayList(200);
            FilePath = ReadParamFromXml("logPath");
            fielNum = 0;
            if (string.IsNullOrEmpty(FilePath))
            {
                FilePath = @"d:\GpsAppServerLog";
            }
            if (!Directory.Exists(FilePath))
            {
                Directory.CreateDirectory(FilePath);
            }
            Thread thread = new Thread(new ThreadStart(FileHelper.StartWrite)) {
                IsBackground = true
            };
            thread.Priority = ThreadPriority.AboveNormal;
            thread.Start();
        }

        public static DataSet ReadDataXml(string string_0)
        {
            DataSet set = new DataSet();
            set.ReadXml(GetAssemblyPath() + @"\" + string_0);
            return set;
        }

        public static string ReadParamFromXml(string string_0)
        {
            string str = string.Empty;
            try
            {
                if (m_ParamData == null)
                {
                    m_ParamData = LoadParamData();
                }
                str = Convert.ToString(m_ParamData.Tables[0].Rows[0][string_0]);
            }
            catch (Exception exception)
            {
                throw new Exception("读取配置参数错误，错误信息为：" + exception.Message);
            }
            return str;
        }

        public string ReadText()
        {
            return this.ReadText(FilePath + FileName);
        }

        public string ReadText(string string_0)
        {
            StreamReader reader = null;
            StringBuilder builder = new StringBuilder();
            try
            {
                reader = new StreamReader(string_0, true);
                while (reader.Peek() >= 0)
                {
                    builder.Append(reader.ReadLine());
                }
                reader.Close();
            }
            catch
            {
            }
            finally
            {
                reader.Close();
            }
            return builder.ToString();
        }

        public string ReadWebConfigFile(string string_0)
        {
            string str = ConfigurationSettings.AppSettings[string_0];
            return base.ConvertNullToEmpty(str);
        }

        public static string ReadXmlEveryOne(string string_0)
        {
            string str = string.Empty;
            try
            {
                str = Convert.ToString(LoadParamData().Tables[0].Rows[0][string_0]);
            }
            catch (Exception exception)
            {
                throw new Exception("读取配置参数错误，错误信息为：" + exception.Message);
            }
            return str;
        }

        public static void StartWrite()
        {
            while (true)
            {
                try
                {
                    StringBuilder builder = new StringBuilder();
                    while (_list.Count > 0)
                    {
                        builder.Append(_list[0]);
                        _list.RemoveAt(0);
                    }
                    if (builder.Length > 0)
                    {
                        write(builder.ToString());
                    }
                }
                catch
                {
                }
                Thread.Sleep(0x2710);
            }
        }

        private static void write(string string_0)
        {
            StreamWriter writer = null;
            try
            {
                writer = new StreamWriter(GetFileName(), true);
                writer.WriteLine(string_0);
            }
            catch (Exception exception)
            {
                StreamWriter writer2 = null;
                try
                {
                    writer2 = new StreamWriter(FilePath + @"\" + DateTime.Today.ToShortDateString() + "-Temp.txt", true);
                    writer2.WriteLine("Error： 写日志发生错误：" + exception.Message);
                    writer2.WriteLine(string_0);
                }
                catch
                {
                }
                finally
                {
                    if (writer2 != null)
                    {
                        writer2.Close();
                    }
                }
            }
            finally
            {
                if (writer != null)
                {
                    writer.Close();
                }
            }
        }

        public void WriteText(string string_0)
        {
            _list.Add(string_0);
        }

        protected static string FileName
        {
            get;
            set;
            //[CompilerGenerated]
            //get
            //{
            //    return <FileName>k__BackingField;
            //}
            //[CompilerGenerated]
            //set
            //{
            //    <FileName>k__BackingField = value;
            //}
        }
    }
}

