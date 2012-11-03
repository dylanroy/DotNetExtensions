using System;
using System.Collections.Generic;
using System.Text;
using DotNetExtensions;

namespace DotNetExtensionsExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            String initialString = "It's a whole new world!";
            String helloWorldString = "Hello " + initialString.SubString("world", "!");
            Console.WriteLine(helloWorldString);
            Console.ReadLine();
        }
    }
}
