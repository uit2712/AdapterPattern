using Computers.Adapters;
using Computers.Concrete;
using Computers.Concrete.Keyboards;
using Computers.Concrete.Mouses;
using Computers.Concrete.Speakers;
using System;

namespace Computers
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonalComputer pc = new PersonalComputer()
                .AddKeyboard(new NormalKeyboard())
                .AddMouse(new NormalMouse())
                .AddSpeakers(new ElectrostaticLoudspeaker());

            Console.WriteLine("Personal Computer:");
            pc.Restart();
            pc.RunSoftware("PUBG Mobile PC");
            pc.ShutDown();
            pc.StartOS();
            pc.UseKeyboard();
            pc.UseMouse();
            pc.UseSpeakers();
            Console.WriteLine();

            Laptop laptop = new Laptop(pc)
                .AddKeyboard(new MechanicalKeyboard())
                .AddMouse(new GamingMouse())
                .AddSpeakers(new ElectrostaticLoudspeaker());

            Console.WriteLine("Laptop:");
            laptop.Restart();
            laptop.RunSoftware("PUBG Mobile PC");
            laptop.ShutDown();
            laptop.StartOS();
            laptop.UseKeyboard();
            laptop.UseMouse();
            laptop.UseSpeakers();
            laptop.Hibernate();
            laptop.Sleep();
            laptop.UseInternalKeyboard();
            laptop.UseInternalMouse();
            laptop.UseInternalSpeakers();
        }
    }
}
