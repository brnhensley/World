using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace World.Models
{
  public class Country
  {
    public string Name {get;}
    public string Code {get;}
    public int Population {get;}


    public Country (string name, string code, int population)
    {
      Name = name;
      Code = code;
      Population = population;

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


        Country newCountry = new Country(countryName, countryCode, countryPopulation);
        allCountries.Add(newCountry);
      }
      conn.Close();
      if (conn != null)
      {
        conn.Dispose();
      }
      return allCountries;
    }

  }
}
