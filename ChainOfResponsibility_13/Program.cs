﻿using System;

namespace ChainOfResponsibility_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Handler h1 = new ConcreteHandler1();
            Handler h2 = new ConcreteHandler2();

            h1.Successor = h2;
            
            h1.HandleRequest(1);
            h1.HandleRequest(2);
            h1.HandleRequest(3);

        }
    }
}