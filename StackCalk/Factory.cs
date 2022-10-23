using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IniParser;
using IniParser.Model;
using System.Reflection;

namespace StackCalk
{
    public class Factory
    {
        private IniData data;
        public Factory()
        {
            var parser = new FileIniDataParser();
            data = parser.ReadFile("Config.ini");
        }
        public ICommand Create(string operation)
        {
            operation = operation.ToUpper();
            string classname = data["MainSettings"][operation];
            Type type = Assembly.GetExecutingAssembly().GetTypes().FirstOrDefault(t => t.Name == classname);
            ICommand command = (ICommand)Activator.CreateInstance(type);
            
            return command;
        }
    }
}
