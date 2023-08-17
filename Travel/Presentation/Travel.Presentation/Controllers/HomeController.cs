using System.Diagnostics;
using System.Web.Mvc;
using Application.Repositories;
using Microsoft.AspNetCore.Mvc;
using Travel.Presentation.Models;

namespace Travel.Presentation.Controllers;

public class HomeController : Microsoft.AspNetCore.Mvc.Controller
{
    private readonly IFirstAreaReadRepository _firstAreaReadRepository;
    private readonly ISecondAreaReadRepository _secondAreaReadRepository;
    public HomeController(IFirstAreaReadRepository firstAreaReadRepository, ISecondAreaReadRepository secondAreaReadRepository)
    {
        _firstAreaReadRepository = firstAreaReadRepository;
        _secondAreaReadRepository = secondAreaReadRepository;
    }


    public IActionResult Index()
    {
        return View();
    }

 
    public IActionResult _NewsPartial()
    {
        return View();
    }


    public IActionResult SecondArea()
    {
        var values = _secondAreaReadRepository.GetAll();
        return View(values);
        
    }

  
    public IActionResult FirstArea()
    {
        var values = _firstAreaReadRepository.GetAll();
        return View(values);

    }


}

