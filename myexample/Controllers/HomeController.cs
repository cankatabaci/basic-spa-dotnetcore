using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Cors;

namespace myexample.Controllers
{
  [EnableCors("MyPolicy")]
  public class HomeController : Controller
    {


    [HttpPost]
    public ActionResult PostEx()
    {
      var result = "Post Edildi!";
      return Json(result);
    }


  }
}
