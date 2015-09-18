using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProj
{
    public class ExtensionManagerFactory
    {
        static IExtensionManager extensionManager;

        public static IExtensionManager Create()
        {
            return extensionManager ?? new FileExtensionManager();
        }


        public static void SetManager(IExtensionManager extManager)
        {
            ExtensionManagerFactory.extensionManager = extManager;
        }


    }
}
