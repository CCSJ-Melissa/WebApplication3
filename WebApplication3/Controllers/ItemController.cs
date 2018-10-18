using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MidtermExam2.Models;

namespace MidtermExam2.Controllers
{
    public class ItemController : Controller { 
    
        public ViewResult ItemRepository()
        {
            return View("View");
        }
            
    }
}
