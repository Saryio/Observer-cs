using System;
using System.Net;
using Services;

namespace Csharp
{
    public class Program
    {
        static void Main(string[] args)
        {
            RockService rock = new RockService();
            
            CientistService cientist = new CientistService(rock);

            rock.setTemperature(190);
        }
    }
}
