using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using System.Text;
using CarBook.Dto.CarDtos;

namespace UdemyCarBook.WebUI.Controllers
{
    public class AdminCarController : Controller
    {
        
        public  IActionResult Index()
        {
           
            return View();
        }
       
    }
}
