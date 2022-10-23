using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;


namespace StackCalk
{

    class Program
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();

        static void Main(string[] args)
        {

            Context context = new Context();
            Factory factory = new Factory();

            string res = "";

            while (res != "stop")
            {
                if (res == "stop")
                {
                    break;
                }
                res = Console.ReadLine();
                logger.Info(res);
                string[] ress = res.Split();
                try
                {
                    ICommand command = factory.Create(ress[0]);
                    List<string> arg = ress.Skip(1).ToList();
                    command.Execute(context, arg);
                }catch(Exception e)
                {
                    logger.Error(e);
                }
            }
            Console.ReadLine();
        }
    }
}
