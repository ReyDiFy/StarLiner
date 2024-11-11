using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace frmTrackThread
{
    internal class MyThreadClass
    {
        public static void Thread1() {
            for (int i = 1; i < 3; i++) {;
                Thread thread = Thread.CurrentThread;
                Debug.WriteLine("Name of Thread: " + thread.Name + " = " + (i));
                Thread.Sleep(500);
            }
        }
        public static void Thread2() {
            for (int o = 1; o < 7; o++) {
                Thread thread = Thread.CurrentThread;
                Debug.WriteLine("Name of Thread: " + thread.Name + " = " + (o));
                Thread.Sleep(1500);
            }

        }
    }
}
