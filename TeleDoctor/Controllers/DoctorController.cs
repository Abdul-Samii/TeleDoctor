﻿using Microsoft.AspNetCore.Mvc;

namespace TeleDoctor.Controllers
{
  public class DoctorController : Controller
  {
    public IActionResult Index()
    {
      return View();
    }
  }
}
