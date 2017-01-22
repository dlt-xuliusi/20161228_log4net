using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using log4net;
using System.Reflection;
using System.Diagnostics;
using System.IO;
using log4net.Config;

namespace test1
{
    public class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
       public static void Main(string[] args)
        {
            Console.Title = "日志程序" + "Test"+DateTime.Now.ToString();
            ILog log = log4net.LogManager.GetLogger("Test");
            log.Error("错误", new Exception("发生了一个异常"));//错误
            log.Fatal("严重错误", new Exception("发生了一个致命错误"));//严重错误
            log.Info("信息"); //记录一般信息
            log.Debug("调试信息");//记录调试信息
            log.Warn("警告");//记录警告信息
            Console.WriteLine("日志记录完毕。______-hahahah");
            Console.Read();
        }
    }
}
