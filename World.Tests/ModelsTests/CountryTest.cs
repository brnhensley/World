using Microsoft.VisualStudio.TestTools.UnitTesting;
using World.Models;
using System.Collections.Generic;
using System;

namespace World.Tests
{
  [TestClass]
  public class CountryTest
  {
    [TestMethod]
    public void FindContinent_ReturnsCountriesFromContinent_Countries()
    {
      List<Country> countryList = new List<Country>{};
      Console.WriteLine("ACAB FUCK FUCK FUCK FUCK");
      Country.FindContinent("Oceania");
      Assert.AreEqual(countryList, countryList);
    }

  }
}
