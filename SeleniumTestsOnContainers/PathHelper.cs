using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTestsOnContainers
{
    public class PathHelper
    {
        public static string CurrentAssemblyPath
        {
            get
            {
                return NUnit.Framework.TestContext.CurrentContext.TestDirectory;
            }
        }

        public static string ResolveLocal(string localPath)
        {
            return Path.Combine(CurrentAssemblyPath, localPath);
        }
    }
}
