﻿using System;

namespace PINCODE
{
    class Program
    {
        static void Main(string[] args)
        {
            Patterns pattern = new Patterns();
            Console.WriteLine(pattern.validatePinCode("421203"));
        }
    }
}
