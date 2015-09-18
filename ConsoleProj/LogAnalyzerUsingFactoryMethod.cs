using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProj
{
    public class LogAnalyzerUsingFactoryMethod
    {
        public bool IsValidLogFileName(string fileName)
        {
            int len = fileName.Length;
            return this.isva
        }

        protected virtual IExtensionManager GetManager()
        {
            //返回硬编码的值
            return new FileExtensionManager();
        }
    }

    public class TestableLogAnalyzer : LogAnalyzerUsingFactoryMethod
    {
        public IExtensionManager Manager;

        protected override IExtensionManager GetManager()
        {
            return Manager;
        }

    }
}
