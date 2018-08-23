using System;
using System.Collections.Generic;

namespace GuidsGuidsGuids.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var guids = new List<Guid>() { Guid.NewGuid(), Guid.NewGuid() };
            foreach (var guid in guids)
                System.Console.WriteLine($"{guid}");

            System.Console.ReadLine();
        }
    }
}
