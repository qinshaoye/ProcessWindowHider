using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace hider
{
    class Program
    {
        System.Diagnostics.Process pro = new System.Diagnostics.Process();
        System.Diagnostics.ProcessStartInfo strx=new System.Diagnostics.ProcessStartInfo();

       public void runner(String cmds,String argx,bool k)
        {
            strx.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            strx.FileName = cmds;
           if(k==true) 
           strx.Arguments = argx;
            pro.StartInfo = strx;
            pro.Start();
        }
     
        static void Main(string[] args)
        {
            Program q = new Program();
            int i; String a = "", b; bool k = false;
            if (args.Length == 0) Console.Out.WriteLine("  Arguments pks!!!");
            else
            {

                b = args[0]; a = null;
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Out.WriteLine(args.Length);
                if (args.Length >1)
                {
                    k = true;
                    //System.Console.Out.WriteLine(a);
                  a = args[1];
                    if(args.Length>1)
                    for (i = 2; i < args.Length; i++)
                        a = a + " " + args[i];
                }

                q.runner(b, a,k);
            }
            
        }
    }
}
