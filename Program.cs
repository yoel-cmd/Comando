using System;
using DotNetEnv;




namespace Comando
{
    internal class Program
    {
    
        static void Main(string[] args)
        {
            Env.Load();
            string apiKey = Environment.GetEnvironmentVariable("_API");
            Console.WriteLine(apiKey);
            
           








        }
    }
}
