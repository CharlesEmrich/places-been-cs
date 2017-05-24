using System.Collections.Generic;

namespace PlacesBeen.Objects
{
  public class Place
  {
    private int    _id;
    private string _name;
    private string _season;
    private int    _duration; //in days
    private static List<Place> _instances = new List<Place>{};

    public Place(string name, string season, int duration)
    {
      _id       = _instances.Count;
      _name     = name;
      _season   = season;
      _duration = duration;

      _instances.Add(this);
    }

    public int GetId()
    {
      return _id;
    }
    public string GetName()
    {
      return _name;
    }
    public void SetName(string newName)
    {
      _name = newName;
    }
    public string GetSeason()
    {
      return _season;
    }
    public void SetSeason(string newSeason)
    {
      _season = newSeason;
    }
    public int GetDuration()
    {
      return _duration;
    }
    public void SetDuration(int newDuration)
    {
      _duration = newDuration;
    }

    public static List<Place> GetAll()
    {
      return _instances;
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }
    public static Place Find(int searchId)
    {
      return _instances[searchId];
    }
  }
}
