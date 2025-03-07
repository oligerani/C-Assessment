using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoInterfaces
{
    interface IFLyable
    {
        void Fly();
    }
     interface  ISWimmable
    {
        void swim();
    }
    class Duck:IFLyable, ISWimmable
    {
        public void Fly()
        {
            Console.WriteLine("Duck is flying");
        }
        public void swim()
        {
            Console.WriteLine("Duck is swimming");
        }
    }
}
