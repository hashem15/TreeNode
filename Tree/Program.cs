using System;
using System.Xml.Linq;

class Program
{
    static void Main()
    {
        XDocument document = XDocument.Load("/Users/hashem/RiderProjects/Tree/Tree/gegevens.xml");

        string naam = document.Root.Element("persoon").Element("naam").Value;
        string leeftijd = document.Root.Element("persoon").Element("leeftijd").Value;

        Console.WriteLine("Naam: " + naam);
        Console.WriteLine("Leeftijd: " + leeftijd);
    }
}