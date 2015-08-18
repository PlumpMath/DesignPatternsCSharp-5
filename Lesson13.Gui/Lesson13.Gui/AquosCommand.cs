using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson13.Gui
{
    // concrete command
    public class AquosCommand : ICommand
    {
        protected const int CommandMaxLength = 4;
        protected const int ParamMaxLength = 4;

        public string Command { get; private set; }
        public string Parameter { get; private set; }
        public Television Television { get; set; }

        private AquosCommand(string command, string parameters = null, Television television = null)
        {
            if (string.IsNullOrEmpty(command))
            {
                throw new ArgumentNullException("command");
            }

            command = command.Trim();

            if (command.Length > CommandMaxLength)
            {
                throw new ArgumentException("Command cannot be more than four characters");
            }

            if (string.IsNullOrEmpty(parameters))
            {
                parameters = string.Empty;
            }

            parameters = parameters.Trim();

            if (parameters.Length > ParamMaxLength)
            {
                throw new ArgumentException("Command parameters cannot be more than four characters");
            }

            Command = command;
            Parameter = parameters.PadRight(ParamMaxLength);
            Television = television;
        }

        public static AquosCommand Volume(int value, Television television = null)
        {
            return new AquosCommand("VOLM", Convert.ToString(value), television);
        }

        public static AquosCommand Power(PowerSetting setting, Television television = null)
        {
            return new AquosCommand("POWR", Convert.ToString((int)setting), television);
        }

        public override string ToString()
        {
            return string.Format("{0}{1}", Command, Parameter);
        }

        public void Execute()
        {
            if (Television == null)
            {
                throw new NullReferenceException("Television cannot be null.");
            }

            Television.Send(ToString());
        }
    }
}
