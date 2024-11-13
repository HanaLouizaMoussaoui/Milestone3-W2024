using HPlusSport.Security.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace HPlusSport.Security.Web.Controllers;

public class HomeController : Controller
{

    /*Course: 		Web Programming 3
* Assessment: 	Milestone 3
* Created by: 	Hana Louiza Moussaoui - 2275881
* Date: 		11/11/2024
* Class Name: 	HomeController.cs
* Description: 	Handles the Index and Error views.
* Time Task B):	2 hours for chapter 1 and 2.
    */
    public IActionResult Index()
    {
        var x = 1 / new Random().Next(0, 1);
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
