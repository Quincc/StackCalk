using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackCalk
{
    public class Context
    {
        public Stack<double> stack = new Stack<double>();
        public Dictionary<string, double> dict = new Dictionary<string, double>();
    }
}
