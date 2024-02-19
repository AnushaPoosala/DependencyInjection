using DependencyInjection.Models;
using DependencyInjection.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace DependencyInjection.Controllers
{
    public class ServiceManuallDIBankController : Controller
    {

        //We can get the service manually(not like Constructor DI nor the Method DI nor PropertyDI nor by creating Object manually) when ever it is required
        //To create service manually we need to use the RequestServices property of HttpContext .
        public JsonResult Index(string bankName)
        {
            var services = this.HttpContext.RequestServices;

            IBankRepository? bankRepository = services.GetService<IBankRepository>();
            Bank? bank = bankRepository.GetAllBanks().FirstOrDefault(b => b.BankName == bankName);

            return Json(bank);
        }
    }
}
