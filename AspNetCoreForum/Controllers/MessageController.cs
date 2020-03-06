using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreForum.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreForum.Controllers
{
    public class MessageController : Controller
    {
        public IActionResult Index()
        {
            return View(DapperORM.ReturnList<Message>("messageall"));
        }
    }
}