using System;

namespace Library
{
    public static class Format
    {
        public static string Output(this String name)
        {
            if (String.IsNullOrWhiteSpace(name))
            {
                return "Error, input data is null or whitespace";
            }
            else
            {
                return DateTime.Now.ToString() + " Hello, " + name;
            }
        }
    }
}
