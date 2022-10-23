using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackCalk
{
    public interface ICommand
    {
        void Execute(Context context, List<string> arg);
    }
}
