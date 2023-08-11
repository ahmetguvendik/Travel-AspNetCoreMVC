using System.Diagnostics;
using Application.Repositories;
using Microsoft.AspNetCore.Mvc;
using Travel.Presentation.Models;

namespace Travel.Presentation.Controllers;

public class HomeController : Controller
{
    private readonly IFirstAreaReadRepository _firstAreaReadRepository;
    public HomeController(IFirstAreaReadRepository firstAreaReadRepository)
    {
        _firstAreaReadRepository = firstAreaReadRepository;
    }

    public IActionResult Index()
    {
        var values = _firstAreaReadRepository.GetAll();
        return View(values);
    }

   
}

