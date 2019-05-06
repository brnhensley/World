using Microsoft.AspNetCore.Mvc;
using System;
using World.Models;
using System.Collections.Generic;

namespace World.Controllers
{
  public class CountryController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View(Country.GetAll());
    }

    [HttpGet("/countries/{continent}")]
    public ActionResult Show(string continent)
    {
      // List<Country> searchContinent = Country.FindContinent();
      return View(Country.FindContinent(continent));
      // return View(continent);
    }

  }
}
