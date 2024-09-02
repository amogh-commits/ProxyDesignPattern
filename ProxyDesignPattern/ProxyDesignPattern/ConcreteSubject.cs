﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyDesignPattern
{
    public class ConcreteSubject:Subject
    {
        public override void DoSomeWork()
        {
            Console.WriteLine("This is coming from ConcreteSubject Method");
        }
    }
}
