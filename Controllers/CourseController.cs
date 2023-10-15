using basics.Models;
using Microsoft.AspNetCore.Mvc;

namespace basics.Controllers;


public class CourseController : Controller
{

    public IActionResult Index()
    {

        var kurs = new Course();
        kurs.Id = 1;
        kurs.Title = "Asp.net Core 7.0 Kursu";
        kurs.Description = "Güzel bir kurs";
        kurs.Image = "1.jpg";
        return View(kurs);
    }

    public IActionResult Details(int? id)
    {
        if(id==null){
            // return Redirect("/course/list");
            return RedirectToAction("List","Course");
        }

        var kurs = Respostory.GetById(id);
        return View(kurs);
    }


    public IActionResult List()
    {


        return View(Respostory.Courses);
    }
}