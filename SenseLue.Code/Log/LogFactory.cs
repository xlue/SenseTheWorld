/*******************************************************************************
 * Copyright © 2016 SenseLue.Framework 版权所有
 * Author: SenseLue
 * Description: SenseLue快速开发平台
 * Website：http://www.SenseLue.cn
*********************************************************************************/
using log4net;
using System;
using System.IO;
using System.Web;

namespace SenseLue.Code
{
    public class LogFactory
    {
        static LogFactory()
        {
            FileInfo configFile = new FileInfo(HttpContext.Current.Server.MapPath("/Configs/log4net.config"));
            log4net.Config.XmlConfigurator.Configure(configFile);
        }
        public static ILog GetLogger(Type type)
        {
            return LogManager.GetLogger(type);
        }
        public static ILog GetLogger(string str)
        {
            return LogManager.GetLogger(str);
        }
    }
}
