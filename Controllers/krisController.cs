using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using kris.Models;

namespace kris.Controllers;

public class krisController : Controller
{
    public IActionResult personalinfo()
    {
        return View();
    }

     public IActionResult education()
    {
        return View();
    }

     public IActionResult dreamjob()
    {
        return View();
    }

}
