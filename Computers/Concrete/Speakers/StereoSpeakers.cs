using Computers.Interfaces;
using System;

namespace Computers.Concrete.Speakers
{
    /// <summary>
    /// Loa kép
    /// </summary>
    class StereoSpeakers : ISpeakers
    {
        public virtual void UseSpeakers()
        {
            Console.WriteLine("Stereo speaker");
        }
    }
}
