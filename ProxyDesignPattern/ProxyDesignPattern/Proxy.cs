using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyDesignPattern
{
    public class Proxy:Subject
    {
        private ConcreteSubject _concreteSubject;

        public override void DoSomeWork()
        {
            if (_concreteSubject == null)
            {
                _concreteSubject = new ConcreteSubject();
            }

            Console.WriteLine("Proxy: Logging the time of request.");
            _concreteSubject.DoSomeWork();
            Console.WriteLine("Proxy: Request has been handled.");
        }
    }
}
