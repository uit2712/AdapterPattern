using Computers.Interfaces;
using System;

namespace Computers.Concrete.Mouses
{
    class GamingMouse : IMouse
    {
        public void UseMouse()
        {
            Console.WriteLine("Gaming mouse...");
        }
    }
}
