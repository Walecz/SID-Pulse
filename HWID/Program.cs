using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWID
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetHWID());
            Console.ReadKey();
        }
        public static string GetHWID()
        {
            return System.Security.Principal.WindowsIdentity.GetCurrent().User.Value;
        }
    }
}
