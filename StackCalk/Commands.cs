using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackCalk
{
    public class PopCommand : ICommand
    {
        public void Execute(Context context, List<string> arg)
        {
            context.stack.Pop();
        }
    }
    public class PushCommand : ICommand
    {
        public void Execute(Context context, List<string> arg)
        {
            string p = arg[0];
            if (!double.TryParse(p, out double res))
            {
                res = context.dict[p];
            }
            context.stack.Push(res);
        }
    }
    public class PlusCommand : ICommand
    {
        public void Execute(Context context, List<string> arg)
        {
            double a,b;
            a = context.stack.Pop();
            b = context.stack.Pop();
            context.stack.Push(a + b);
        }
    }
    public class MinusCommand : ICommand
    {
        public void Execute(Context context, List<string> arg)
        {
            double a, b;
            a = context.stack.Pop();
            b = context.stack.Pop();
            context.stack.Push(a - b);
        }
    }
    public class MultiplicationCommand : ICommand
    {
        public void Execute(Context context, List<string> arg)
        {
            double a, b;
            a = context.stack.Pop();
            b = context.stack.Pop();
            context.stack.Push(a * b);
        }
    }
    public class DivisionCommand : ICommand
    {
        public void Execute(Context context, List<string> arg)
        {
            double a, b;
            a = context.stack.Pop();
            b = context.stack.Pop();
            context.stack.Push(a / b);
        }
    }
    public class SqrtCommand : ICommand
    {
        public void Execute(Context context, List<string> arg)
        {
            double a;
            a = context.stack.Pop();
            context.stack.Push(Math.Sqrt(a));
        }
    }
    public class DefineCommand : ICommand
    {
        public void Execute(Context context, List<string> arg)
        {
            context.dict.Add(arg[0], double.Parse(arg[1]));
        }
    }
    public class PrintCommand : ICommand
    {
        public void Execute(Context context, List<string> arg)
        {
            Console.WriteLine(context.stack.Peek());
        }
    }

}
