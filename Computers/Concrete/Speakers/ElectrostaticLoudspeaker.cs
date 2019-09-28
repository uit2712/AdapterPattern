using Computers.Interfaces;
using System;

namespace Computers.Concrete.Speakers
{
    /// <summary>
    /// Loa tĩnh điện
    /// </summary>
    class ElectrostaticLoudspeaker : ISpeakers
    {
        public void UseSpeakers()
        {
            Console.WriteLine("Electrostatic Loudspeaker");
        }
    }
}
