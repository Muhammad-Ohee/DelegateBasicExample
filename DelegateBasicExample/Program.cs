//Console.WriteLine("Hello, OS");

namespace DelegateBasicExample
{
    class Program
    {
        //delegate void LogDel(string message, DateTime dateTime);
        delegate void LogDel(string message);

        //delegate void LogDel_For_Instance(string message, DateTime dateTime);
        //delegate void LogDel_For_Instance(string message);


        static void Main(string[] args)
        {
            /*
            LogDel logDel = new LogDel(LogTextToScreeen);
            LogDel logDel = new LogDel(LogTextToFile);

            LogDel logDel = new LogDel(LogTextToScreeen);

            Console.WriteLine("Enter your name");
            string name = Console.ReadLine();

            logDel(name);
            */


            /*
            Log log = new Log();
            LogDel_For_Instance logDel_for_instance = new LogDel_For_Instance(log.LogTextToFile);

            Console.WriteLine("Enter your name");
            string name = Console.ReadLine();

            //logDel_for_instance(name, DateTime.Now);
            logDel_for_instance(name);
            */


            /*
            //chain
            Log log = new Log();
            LogDel LogTextToScreeen, LogTextToFile;
            LogTextToScreeen = new LogDel(log.LogTextToScreeen);
            LogTextToFile = new LogDel(log.LogTextToFile);

            LogDel multiLogDel = LogTextToScreeen + LogTextToFile;
            Console.WriteLine("Enter your name");
            string name = Console.ReadLine();
            multiLogDel(name);
            */



            //pass delegates as an argument in a method
            Log log = new Log();
            LogDel LogTextToScreeen, LogTextToFile;
            LogTextToScreeen = new LogDel(log.LogTextToScreeen);
            LogTextToFile = new LogDel(log.LogTextToFile);

            LogDel multiLogDel = LogTextToScreeen + LogTextToFile;
            Console.WriteLine("Enter your name");
            string name = Console.ReadLine();
            
            //LogText(multiLogDel, name);
            //LogText(LogTextToScreeen, name);
            LogText(LogTextToFile, name);



        }

        static void LogText (LogDel logDel, string message)
        {
            logDel(message);
        }

        /*
        static void LogTextToScreeen(string message, DateTime dateTime)
        {
            Console.WriteLine($"{DateTime.Now}, and my name is {message}"); // This DateTime.Now is not the method object
            Console.WriteLine($"{dateTime}, and my name is {message}");
        }

        static void LogTextToFile(string message)
        {
            using (StreamWriter sw = new StreamWriter(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Log.txt"), true))
            {
                sw.WriteLine($"{DateTime.Now}, and my name is {message}");
            }
        }
        */
    }

    class Log
    {
        public void LogTextToScreeen(string message)
        {
            Console.WriteLine($"{DateTime.Now}, and my name is {message}"); // This DateTime.Now is not the method object
            //Console.WriteLine($"{dateTime}, and my name is {message}");
        }

        public void LogTextToFile(string message)
        {
            using (StreamWriter sw = new StreamWriter(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Log.txt"), true))
            {
                sw.WriteLine($"{DateTime.Now}, and my name is {message}");
            }
        }
    }
}