using System;

namespace VariableLogger
{
    public class StartUp
    {
        public static void Main()
        {
            VariableConsoleLogger variableLogger = new VariableConsoleLogger();
            variableLogger.Log(true);
        }

        public class VariableConsoleLogger
        {
            public void Log(bool variable)
            {
                string variableAsString = variable.ToString();
                Console.WriteLine(variableAsString);
            }
        }
    }
}
