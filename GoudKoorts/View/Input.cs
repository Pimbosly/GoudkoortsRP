﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool
//     Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Input
{
    public string askInputString(string question)
    {
        Console.WriteLine(question);
        return Console.ReadLine();
    }

    public ConsoleKeyInfo askInputKey(string question)
    {
        Console.WriteLine(question);
        return Console.ReadKey();
    }
}
