using System;
using System.Collections.Generic;

namespace ParkSpace
{
  // public int idAssigner = 0;

  class Dinosaur
  {
    private string _species;
    private int _id;
    private string _weight;
    private bool _carnivore;
    private int _hungerLevel;
    private Paddock _location;
    private bool _alive;

    public Dinosaur (string species, int id, string weight, bool carnivore, Paddock location)
    {
      _species = species;
      _id = id;
      _weight = weight;
      _carnivore = carnivore;
      _hungerLevel = 50;
      _location = location;
      _alive = true;
    }
    public string GetSpecies()
    {
      return _species;
    }
    public string GetWeight()
    {
      return _weight;
    }
    public bool GetIsCarnivore()
    {
      return _carnivore;
    }
    public string GetLocation()
    {
       return _location.GetName(); 
    }
    public int GetId()
    {
      return _id;
    }
  }

  class Paddock
  {
    private int _id;
    private string _name;
    private bool _nearCarnivores;
    private bool _nearHerbivores;
    private bool _nearAtrium;
    private bool _nearRaptors;
    private bool _nearHotel;
    // private List<Inhabitants> _inhabitantsList;


    public Paddock(int id, string name, bool nearCarnivores, bool nearHerbivores, bool nearAtrium, bool nearRaptors, bool nearHotel)
    {
      _id = id;
      _name = name;
      _nearCarnivores = nearCarnivores;
      _nearHerbivores = nearHerbivores;
      _nearAtrium = nearAtrium;
      _nearRaptors = nearRaptors;
      _nearHotel= nearHotel;
      // _inhabitantsList= new List<Inh>{}
    }
    public string GetName()
    {
      return _name;
    }
  }
}

