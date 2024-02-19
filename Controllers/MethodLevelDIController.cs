using DependencyInjection.Models;
using DependencyInjection.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace DependencyInjection.Controllers
{
    public class MethodLevelDIController : Controller
    {
        public JsonResult Index([FromServices] IBankRepository bankRepository)
        {
            return Json(bankRepository.GetAllBanks().ToList());
        }

        public JsonResult Index2([FromServices] IBankRepository bankRepository, string BankName)
        {

            return Json(bankRepository.GetAllBanks().Where(x => x.BankName == BankName).SingleOrDefault() ?? new Bank());
        }
    }
}