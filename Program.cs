using InstrumentLibrary.Models;
using System;

namespace InstrumentLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Guitar myGuitar=new Guitar("Gibson");
            Mandolin myMandolin = new Mandolin("Kentucky KM-140");
            Ukele myUkele = new Ukele("Ortega");

            myUkele.serialNumber = "abc123";

            myMandolin.Play();
            myGuitar.Play();
            myUkele.Play();
        }
    }
}
