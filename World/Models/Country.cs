using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System;

namespace World.Models
{
  public class Country
  {
    public string Name {get;}
    public string Code {get;}
    public int Population {get;}
    public string Continent {get;}


    public Country (string name, string code, int population, string continent)
    {
      Name = name;
      Code = code;
      Population = population;
      Continent = continent;

    }
    public static List<Country> GetAll()
    {

      List<Country> allCountries = new List<Country> {};
      MySqlConnection conn = DB.Connection();
      conn.Open();
      MySqlCommand cmd = conn.CreateCommand() as MySqlCommand;
      cmd.CommandText = @"SELECT * FROM country;";
      MySqlDataReader rdr = cmd.ExecuteReader() as MySqlDataReader;
      while(rdr.Read())
      {
        string countryName = rdr.GetString(1);
        string countryCode = rdr.GetString(0);
        int countryPopulation = rdr.GetInt32(6);
        string countryContinent = rdr.GetString(2);


        Country newCountry = new Country(countryName, countryCode, countryPopulation, countryContinent);
        allCountries.Add(newCountry);
      }
      conn.Close();
      if (conn != null)
      {
        conn.Dispose();
      }
      return allCountries;
    }

    public static List<Country> FindContinent(string searchContinent)
    {
      List<Country> countryList = GetAll();

      List<Country> matchedCountries = new List<Country>{};
      Console.WriteLine("Djubuti");
      foreach (var country in countryList)
      {
        Console.WriteLine(country.Name);
        if (country.Continent == searchContinent)
        {
          Console.WriteLine(country.Name);
          Console.WriteLine("Djubuti");
          matchedCountries.Add(country);
        }
      }
      return matchedCountries;
    }

  }
}
