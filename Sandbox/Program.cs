using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
    class Program
    {
        static void Main()
        {
            Logger logger = new Logger();
            WriterDelegate writer = new WriterDelegate(logger.WriteMessage);
            writer("This is NOT A TEST!!!");
        }
    }

    public class Logger
    {
        public void WriteMessage(String message)
        {
            Console.WriteLine(message);
        }
    }
}
