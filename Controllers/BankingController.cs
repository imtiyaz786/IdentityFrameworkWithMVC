using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bankingAppMVC.Controllers
{
    [Authorize]
    public class BankingController : Controller
    {
        [AllowAnonymous]
        public IActionResult BankingInfo()
        {
            return View();
        }
        [AllowAnonymous]
        public IActionResult ContactBanking()
        {
            return View();
        }

        public IActionResult TransferFunds()
        {
            return View();
        }

        public IActionResult DownloadStatements()
        {
            return View();
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
