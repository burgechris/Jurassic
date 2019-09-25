using System;
using System.Collections.Generic;

namespace ParkSpace
{


    class Park 
  {
    private List<Dinosaur> _DinosaursInPark;
    private List<Paddock> _ParkLocations;
    public int AnimalidAssigner;
    public int LocationIdAssigner;

    public Park ()
    {
    _DinosaursInPark = new List<Dinosaur>(0);
    _ParkLocations = new List<Paddock>(0);
    AnimalidAssigner = 0;
    LocationIdAssigner = 0;
    }
    public List<Dinosaur> GetDinoList()
    {
      return _DinosaursInPark;
    }
    public List<Paddock> GetPaddockList()
    {
      return _ParkLocations;
    }
    public Paddock GetLocationbyName(string name)
    {
      for (int i = 0; i < _ParkLocations.Count; i++)
      {
        if (_ParkLocations[i].GetName() == name) 
        {
          return _ParkLocations[i];
        } 
        else{
          Console.WriteLine("Sorry");
        }
      }
    }

    public void AddNewDino(string species, string weight, bool carnivore, Paddock location)
    {
    AnimalidAssigner++;
    Dinosaur dino = new Dinosaur(species, AnimalidAssigner, weight, carnivore, location);
    _DinosaursInPark.Add(dino);
    }
    public void AddNewPaddock(string name, bool nearCarnivores, bool nearHerbivores, bool nearAtrium, bool nearRaptors, bool nearHotel)
    {
    LocationIdAssigner++;
    Paddock pen = new Paddock(LocationIdAssigner, name, nearCarnivores, nearHerbivores, nearAtrium, nearRaptors, nearHotel);
     _ParkLocations.Add(pen);
    }
  }
}