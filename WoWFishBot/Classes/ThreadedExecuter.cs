using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WoWFishBot.Classes
{
    class ThreadedExecuter<T> where T : class
    {
        public delegate void CallBackDelegate(T returnValue);
        public delegate T MethodDelegate();
        private CallBackDelegate callback;
        private MethodDelegate method;

        private Thread t;

        public ThreadedExecuter(MethodDelegate method, CallBackDelegate callback)
        {
            this.method = method;
            this.callback = callback;
            t = new Thread(Process);
        }
        public void Start()
        {
            t.Start();
        }
        public void Abort()
        {
            t.Abort();
            callback(null); //can be left out depending on your needs
        }
        private void Process()
        {
            T stuffReturned = method();
            callback(stuffReturned);
        }
    }
}
