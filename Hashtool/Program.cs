using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace Hashtool
{
    static class Program
    {
        public static string SrcCodeURL { get { return "https://github.com/chuhei1987/Hashtool_2"; } }
        public static string IntroStr { get { return "Using C# to construct integrity checking gadget, Supporting SHA-2,SHA-3 and SM3"; } }
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainWnd());
        }
    }
}
