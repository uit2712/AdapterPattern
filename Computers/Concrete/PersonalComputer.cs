using Computers.Interfaces;
using System;

namespace Computers.Concrete
{
    /// <summary>
    /// Adaptee
    /// </summary>
    class PersonalComputer : IComputer, IKeyboard, IMouse, ISpeakers
    {
        private ISpeakers _speakers;
        private IKeyboard _keyboard;
        private IMouse _mouse;

        public PersonalComputer()
        {
        }

        public PersonalComputer AddSpeakers(ISpeakers speakers)
        {
            _speakers = speakers;
            return this;
        }

        public PersonalComputer AddKeyboard(IKeyboard keyboard)
        {
            _keyboard = keyboard;
            return this;
        }

        public PersonalComputer AddMouse(IMouse mouse)
        {
            _mouse = mouse;
            return this;
        }

        public virtual void Restart()
        {
            Console.WriteLine("Restarting...");
        }

        public virtual void RunSoftware(string softwareName)
        {
            Console.WriteLine(string.Format("Opening '{0}'...", softwareName));
        }

        public virtual void ShutDown()
        {
            Console.WriteLine("Shutting down...");
        }

        public virtual void StartOS()
        {
            Console.WriteLine("Starting OS...");
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
