using System;
using System.Diagnostics;
using Microsoft.Win32;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace criticalbusinessapp
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = "doing critical business things";
            try
            {
                using (RegistryKey key = Registry.LocalMachine.OpenSubKey("SOFTWARE\\CriticalBusinessProcess"))
                {
                    if (key != null)
                   { 
                        
                        Object o = key.GetValue("message");
                        if (o != null)
                        {
                            message = o.ToString();
                        }
                    }
                }
            }
            catch (Exception ex)  
            {
                Console.WriteLine("Exception reading registry {0}", ex.ToString());
                Environment.Exit(1);
            }
            for (;;)
            {

                String timeStamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                Console.WriteLine("{0} {1}", timeStamp, message);
                System.Threading.Thread.Sleep(5000);
            }
        }
    }
}
