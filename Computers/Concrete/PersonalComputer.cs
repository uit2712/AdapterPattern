using Computers.Interfaces;
using System;

namespace Computers.Concrete
{
    /// <summary>
    /// Adaptee
    /// </summary>
    class PersonalComputer : IComputer
    {
        public PersonalComputer()
        {
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
    }
}
