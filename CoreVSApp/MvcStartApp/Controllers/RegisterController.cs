using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MvcStartApp.Models;
using MvcStartApp.Models.Db;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MvcStartApp.Controllers
{
    public class RegisterController : Controller
    {
        // ссылка на репозиторий
        private readonly IBlogRepository _repo;

        public RegisterController(IBlogRepository repo)
        {
            _repo = repo;
        }

        public async Task<IActionResult> Index()
        {
            return View();
        }
    }
}
