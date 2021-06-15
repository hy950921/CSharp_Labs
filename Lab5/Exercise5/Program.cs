using System;

namespace Exercise5
{
    public class Myclass
    {
        public delegate void LogHandlerv(string message);
        public void Process(LogHandlerv logHandler)
        {
            if (logHandler != null)
            {
                logHandler("begin");
            }
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
