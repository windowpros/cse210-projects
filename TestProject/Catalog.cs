using System;
using System.Collections.Generic;
using System.IO;

public class Catalog
{
    private List<Flyers> _flyers = new List<Flyers>();

    public void AddFlyer(Flyers flyer)
    {
        _flyers.Add(flyer);
    }

    public List<Flyers> GetFlyers()
    {
        return _flyers;
    }

    public void DisplayFlyers()
    {
        foreach (var flyer in _flyers)
        {
            Console.WriteLine(flyer.GetModel());
        }
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter sw = new StreamWriter(filename))
        {
            foreach (var flyer in _flyers)
            {
                sw.WriteLine(flyer.Serialize());
            }
        }
    }

    public void LoadFromFile(string filename)
    {
        _flyers.Clear();
        foreach (var line in File.ReadAllLines(filename))
        {
            string[] parts = line.Split('#');
            if (parts[0] == "Plane")
            {
                Plane p = new Plane(parts[1], int.Parse(parts[2]), int.Parse(parts[3]), int.Parse(parts[4]), parts[5], int.Parse(parts[6]));
                _flyers.Add(p);
            }
            else if (parts[0] == "Helicopter")
            {
                Helicopter h = new Helicopter(parts[1], int.Parse(parts[2]), int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[5]), int.Parse(parts[6]));
                _flyers.Add(h);
            }
        }
    }
}
