using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProj
{
    public class FileExtensionManager : IExtensionManager
    {
        public bool IsValid(string fileName)
        {
            return true;
        }
    }

    public class StubExtensionManager: IExtensionManager
    {
        public bool IsValid(string fileName)
        {
            return ShouldExtensionBeValid;
        }

        public bool ShouldExtensionBeValid{get;set;}
    }



    public interface IExtensionManager
    {
        bool IsValid(string fileName);
    }


}
