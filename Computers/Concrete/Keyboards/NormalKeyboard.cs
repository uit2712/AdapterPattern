using Computers.Interfaces;
using System;

namespace Computers.Concrete.Keyboards
{
    class NormalKeyboard : IKeyboard
    {
        public void UseKeyboard()
        {
            Console.WriteLine("Normal keyboard");
        }
    }
}
