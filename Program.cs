using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Midi;

namespace getMIDIOutDevices
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = OutputDevice.InstalledDevices.Count;
            string[] list = new string[num];

            for (int i = 0; i < num; i++)
            {
                OutputDevice outputdevice = OutputDevice.InstalledDevices[i];
                list[i] = outputdevice.Name;
            }

            Console.WriteLine("MIDI Devices = {0}", num);
            for (int i = 0; i < list.Count(); i++)
            {
                Console.WriteLine("{0} - {1}", i, list[i]);
            }
            
            Console.WriteLine("\nPress any key to exit.");
            Console.ReadKey();
        }
    }
}
