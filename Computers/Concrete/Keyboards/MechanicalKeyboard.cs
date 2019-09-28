using Computers.Interfaces;
using System;

namespace Computers.Concrete.Keyboards
{
    class MechanicalKeyboard : IKeyboard
    {
        public void UseKeyboard()
        {
            Console.WriteLine("Mechanical keyboard");
        }
    }
}
