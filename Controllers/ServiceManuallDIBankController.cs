using DependencyInjection.Models;
<<<<<<< HEAD
using DependencyInjection.Repositories;
=======
>>>>>>> fdd5b2830417fce78f01fd98917bf7d4ff1f60da
using Microsoft.AspNetCore.Mvc;

namespace DependencyInjection.Controllers
{
    public class ServiceManuallDIBankController : Controller
    {
<<<<<<< HEAD

=======
      
>>>>>>> fdd5b2830417fce78f01fd98917bf7d4ff1f60da
        //We can get the service manually(not like Constructor DI nor the Method DI nor PropertyDI nor by creating Object manually) when ever it is required
        //To create service manually we need to use the RequestServices property of HttpContext .
        public JsonResult Index(string bankName)
        {
<<<<<<< HEAD
            var services = this.HttpContext.RequestServices;

            IBankRepository? bankRepository = services.GetService<IBankRepository>();
=======
            var services=this.HttpContext.RequestServices;

            IBankRepository? bankRepository=services.GetService<IBankRepository>();
>>>>>>> fdd5b2830417fce78f01fd98917bf7d4ff1f60da
            Bank? bank = bankRepository.GetAllBanks().FirstOrDefault(b => b.BankName == bankName);

            return Json(bank);
        }
    }
<<<<<<< HEAD
}
=======
}
>>>>>>> fdd5b2830417fce78f01fd98917bf7d4ff1f60da
