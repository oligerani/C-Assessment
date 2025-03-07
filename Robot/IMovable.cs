using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot
{
    interface IMovable
    {
        void Move();
    }
    class Machine : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Machine is moving");
        }
        public void start()
        {
            Console.WriteLine("Machine is moving");
        }
    }
    class Robot :  IMovable
    {
        public void Move()
        {
            Console.WriteLine("Robot is moving");
        }
    }
}
