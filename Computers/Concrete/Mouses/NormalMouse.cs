using Computers.Interfaces;
using System;

namespace Computers.Concrete.Mouses
{
    class NormalMouse : IMouse
    {
        public void UseMouse()
        {
            Console.WriteLine("Normal mouse...");
        }
    }
}
