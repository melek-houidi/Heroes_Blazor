using Domain;
using GenericRepository.Interdace;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MRPanel.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MRPanel.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUnitOfWork<Person> unitOfWork;

        public HomeController(IUnitOfWork<Person> unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public async Task <IActionResult> Index()
        {
            var list = await unitOfWork.Repository.All();
            return View(list);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
