using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProj
{
    public class LogAnalyzer
    {
        private IExtensionManager manager;

        public LogAnalyzer()
        {
            manager = ExtensionManagerFactory.Create();
        }

        public LogAnalyzer(IExtensionManager mgr)
        {
            manager = mgr;
        }

        public IExtensionManager ExtensionManager
        {
            get { return manager; }
            set { manager = value; }
        }






        private bool wasLastFileNameValid;

        public bool WasLastFileNameValid
        {
            get { return wasLastFileNameValid; }
            set { wasLastFileNameValid = value; }
        }


        //public bool IsValidLogFileName(string fileName)
        //{
        //    if(string.IsNullOrEmpty(fileName))
        //    {
        //        throw new ArgumentException("No filename provided!");
        //    }

        //   if(!fileName.ToLower().EndsWith(".slf"))
        //   {
        //       wasLastFileNameValid = false;
        //       return false;
        //   }

        //   wasLastFileNameValid = true;
        //   return true;
        //}

        public bool IsValidLogFileName(string fileName)
        {
            //读取配置文件
            
            return manager.IsValid(fileName)&&
                Path.GetFileNameWithoutExtension(fileName).Length > 5;

            //如果配置中声明支持该扩展名，则返回true
        }




    }
}
