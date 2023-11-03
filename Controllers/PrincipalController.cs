using Microsoft.AspNetCore.Mvc;

namespace Portafolio_I;

public class PrincipalController : Controller{
    
    [HttpGet]
    [Route("")]
    public ViewResult Index(){
        return View("Index");
    }

    [HttpGet]
    [Route("projects")]
    public ViewResult projects(){
        return View("projects");
    }

    [HttpGet]
    [Route("contact")]
    public ViewResult contact(){
        return View("contact");
    }

}