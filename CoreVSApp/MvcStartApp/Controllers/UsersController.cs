﻿using Microsoft.AspNetCore.Mvc;
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
    public class UsersController : Controller
    {
        // ссылка на репозиторий
        private readonly IBlogRepository _repo;

        public UsersController(IBlogRepository repo)
        {
            _repo = repo;
        }

        [HttpPost]
        public async Task<IActionResult> Register(User newUser)
        {
            await _repo.AddUser(newUser);
            return View(newUser);
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }


    }
}
