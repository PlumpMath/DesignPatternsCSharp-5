using System;

namespace Lesson04
{
    public class AquosCommand
    {
        protected const int CommandMaxLength = 4;
        protected const int ParamMaxLength = 4;

        public string Command { get; private set; }
        public string Parameter { get; private set; }

        private AquosCommand(string command, string parameters = null)
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
        }

        public static AquosCommand Volume(int value)
        {
            return new AquosCommand("VOLM", Convert.ToString(value));
        }

        public static AquosCommand Power(PowerSetting setting)
        {
            return new AquosCommand("POWR", Convert.ToString((int)setting));
        }

        public override string ToString()
        {
            return string.Format("{0}{1}", Command, Parameter);
        }
    }
}
