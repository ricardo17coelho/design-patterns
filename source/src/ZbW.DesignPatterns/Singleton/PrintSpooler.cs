using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZbW.DesignPatterns.Singleton
{
    public class PrintSpooler
    {
        private static PrintSpooler _instance;

        private Queue<PrintJob> _printJobs = new Queue<PrintJob>();

        public static PrintSpooler getInstance()
        {
            if (_instance == null)
            {
                _instance = new PrintSpooler();
            }

            return _instance;
        }

        public void Enqueue(PrintJob printJob)
        {
            this._printJobs.Enqueue(printJob);
        }

        public void Dequeue()
        {
            this._printJobs.Dequeue();
        }
    }
}
