using DependencyInjection.Models;
<<<<<<< HEAD
using DependencyInjection.Repositories;
=======
>>>>>>> fdd5b2830417fce78f01fd98917bf7d4ff1f60da
using Microsoft.AspNetCore.Mvc;

namespace DependencyInjection.Controllers
{
    public class MethodLevelDIController : Controller
    {
<<<<<<< HEAD
        public JsonResult Index([FromServices] IBankRepository bankRepository)
=======
        public JsonResult Index([FromServices]IBankRepository bankRepository)
>>>>>>> fdd5b2830417fce78f01fd98917bf7d4ff1f60da
        {
            return Json(bankRepository.GetAllBanks().ToList());
        }

<<<<<<< HEAD
        public JsonResult Index2([FromServices] IBankRepository bankRepository, string BankName)
=======
        public JsonResult Index2([FromServices]IBankRepository bankRepository,string BankName)
>>>>>>> fdd5b2830417fce78f01fd98917bf7d4ff1f60da
        {

            return Json(bankRepository.GetAllBanks().Where(x => x.BankName == BankName).SingleOrDefault() ?? new Bank());
        }
    }
<<<<<<< HEAD
}
=======
}
>>>>>>> fdd5b2830417fce78f01fd98917bf7d4ff1f60da
