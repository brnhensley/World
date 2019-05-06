using Microsoft.AspNetCore.Mvc;
using System;
using World.Models;
using System.Collections.Generic;

namespace World.Controllers
{
  public class CountryController : Controller
  {
    [HttpGet("/countries")]
    public ActionResult Index()
    {
      return View(Country.GetAll());
    }

  }
}
