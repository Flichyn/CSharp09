using System;
using System.Collections.Generic;

class Program {
  public static void Main (string[] args) {
    List<string> stringCollection = new List<string>();

    stringCollection.Add("Bonjour ");
    stringCollection.Add("je m'appelle ");
    stringCollection.Add("Nicolas");
    
    Console.WriteLine(stringCollection[0] + stringCollection[1] + stringCollection[2]);

    stringCollection.RemoveAt(0);
    stringCollection.Remove("Nicolas");

    // La valeur originellement placée sur l'index 1 devient l'index 0 maintenant que la valeur originellement placée sur l'index 0 a été supprimée.
    Console.WriteLine(stringCollection[0]);
    
    stringCollection[0] = "Je suis développeur";

    Console.WriteLine(stringCollection[0]);
  }
}
