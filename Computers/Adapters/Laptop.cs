using Computers.Interfaces;
using System;

namespace Computers.Adapters
{
    /// <summary>
    /// Object Adapter: composition
    /// </summary>
    class Laptop : IComputer, ISpeakers, IKeyboard, ILaptop, IMouse
    {
        protected IComputer _computer;
        protected ISpeakers _speakers;
        protected IKeyboard _keyboard;
        protected IMouse _mouse;

        public Laptop(IComputer computer)
        {
            _computer = computer;
        }

        public Laptop AddSpeakers(ISpeakers speakers)
        {
            _speakers = speakers;
            return this;
        }

        public Laptop AddKeyboard(IKeyboard keyboard)
        {
            _keyboard = keyboard;
            return this;
        }

        public Laptop AddMouse(IMouse mouse)
        {
            _mouse = mouse;
            return this;
        }

        public void Hibernate()
        {
            Console.WriteLine("Hibernating...");
        }

        public void Restart()
        {
            _computer?.Restart();
        }

        public void RunSoftware(string softwareName)
        {
            _computer?.RunSoftware(softwareName);
        }

        public void ShutDown()
        {
            _computer?.ShutDown();
        }

        public void Sleep()
        {
            Console.WriteLine("Sleeping...");
        }

        public void StartOS()
        {
            _computer?.StartOS();
        }

        public void UseInternalKeyboard()
        {
            Console.WriteLine("Internal keyboard");
        }

        public void UseInternalMouse()
        {
            Console.WriteLine("Internal mouse");
        }

        public void UseInternalSpeakers()
        {
            Console.WriteLine("Internal speakers");
        }

        public void UseKeyboard()
        {
            _keyboard?.UseKeyboard();
        }

        public void UseMouse()
        {
            _mouse?.UseMouse();
        }

        public void UseSpeakers()
        {
            _speakers?.UseSpeakers();
        }
    }
}
