﻿using DependencyInjection.Models;
using DependencyInjection.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace DependencyInjection.Controllers
{
    public class ConstructorLevelDIBankController : Controller
    {
        //With DI Implementation
        private readonly IBankRepository _bankRepository;
        private readonly ITestBankRepo _testBankRepository;

<<<<<<< HEAD:Controllers/BankController.cs
        public BankController(IBankRepository bankRepository,ITestBankRepo testBankRepo)
=======
        public ConstructorLevelDIBankController(IBankRepository bankRepository)
>>>>>>> fdd5b2830417fce78f01fd98917bf7d4ff1f60da:Controllers/ConstructorLevelDIBankController.cs
        {
            _bankRepository = bankRepository;
            _testBankRepository= testBankRepo;
        }
        public JsonResult GetAllBanksInformation()
        {
            _testBankRepository.GetBanksInfoFromTestBankRepo();
            return Json(_bankRepository.GetAllBanks());
        }

        public JsonResult GetBankInfoByRegNo(int regNo) 
        { 
            return Json(_bankRepository.GetBankInfoByRegNo(regNo));
        }





        //WithOut DI Implementation
        public JsonResult GetAllBanksInformationWithOutDI()
        {
            BankRepository bankRepository = new BankRepository();
            List<Bank> bankList = bankRepository.GetAllBanks();
            return Json(bankList);
        }

        public JsonResult GetBankInfoByRegNoWithoutDI(int BankRegNo)
        {
            //No need to create the object here , instead we will create the obj in the constructer
            BankRepository bankRepository = new BankRepository();

            return Json(bankRepository.GetBankInfoByRegNo(BankRegNo));

        }
    }
}
