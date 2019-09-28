namespace Computers.Interfaces
{
    interface IComputer
    {
        void StartOS();
        void RunSoftware(string softwareName);
        void Restart();
        void ShutDown();
    }
}
