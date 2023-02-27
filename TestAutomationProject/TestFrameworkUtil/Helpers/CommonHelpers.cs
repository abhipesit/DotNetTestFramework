using System;
using System.IO;

namespace TestFrameworkUtil.Helpers
{
    public class CommonHelpers
    {
        public CommonHelpers()
        {

        }

        public static string GetPath()
        {
            string pth = System.Reflection.Assembly.GetCallingAssembly().CodeBase;
            string actualPath = pth.Substring(0, pth.LastIndexOf("bin"));
            return new Uri(actualPath).LocalPath;
        }

        public static void CreateFolderIfMissing(string folderPath)
        {
            if (!Directory.Exists(folderPath))
                Directory.CreateDirectory(folderPath);
        }
    }
}
