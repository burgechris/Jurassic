using System;
using System.Collections.Generic;
using ParkSpace;

namespace Parkspace
{

  public class Program
  {
    static void Main()
    {

      Park jurassic = new Park ();

      jurassic.AddNewPaddock("Carnivore Paddock", true, false, true, false, true);
      jurassic.AddNewPaddock("Atrium", true, true, true, false, false);
      jurassic.AddNewPaddock("Herbivore Paddock", false, true, true, true, false);
      jurassic.AddNewPaddock("Raptor Lounge", false, true, false, true, true);
      jurassic.AddNewPaddock("Hotel", true, false, false, true, true);
      
      Paddock location = jurassic.GetLocationbyName("carnivore");
      jurassic.AddNewDino("T-Rex", "20,000 lbs", true, location);
      // jurassic.AddNewDino("Brachiosaurus", "124, 000 lbs", false, GetLocationbyName("herbivore"));
      // jurassic.AddNewDino("Pterodactyl", "550 lbs", true, GetLocationbyName("atrium"));
      // jurassic.AddNewDino("Velociraptor", "33 lbs", true, GetLocationbyName("raptorPen"));
      // jurassic.AddNewDino("Sam", "170 lbs", false, GetLocationbyName("hotel"));
      
      foreach(Dinosaur dino in jurassic.GetDinoList())
      {
        Console.WriteLine("Species: " + dino.GetSpecies());
        Console.WriteLine("Location: " + dino.GetLocation());
        Console.WriteLine("TrampStamp: " + dino.GetId());
      }

      foreach(Paddock pen in jurassic.GetPaddockList())
      {
        Console.WriteLine("Paddock: " + pen.name);
      }
          
    }
  }
}

