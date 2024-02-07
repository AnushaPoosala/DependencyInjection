using DependencyInjection.Models;

namespace DependencyInjection.Repositories
{
    public class BankRepository : IBankRepository
    {
        public BankRepository()
        {
            //string filePath = @"E:\\ASPNET7\\ASP.NET-Core-7-MVC-Topics\\DependencyInjectionCoreApp\\Logs\\ServiceLifeTimeLog.txt";//
                                
            string filePath = @"C:\Users\Sures\OneDrive\Desktop\AnushaLearnings\DependencyInjection\Logs\ServiceLifeTimeLog.txt";
            string dataOfMsg = $"Bank repo Object is created :@{DateTime.Now.ToString()}";

            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                writer.WriteLine(dataOfMsg);
            }

        }
        public List<Bank> AllBanksInfo()
        {
            List<Bank> bankInfo = new List<Bank>();
            bankInfo.Add(new Bank { BankRegId = 1, BankAddress = "Hyd", BankName = "HDFC", BankType = "Savings" });
            bankInfo.Add(new Bank { BankRegId = 2, BankAddress = "Karimnagar", BankName = "SBI", BankType = "current" });
            bankInfo.Add(new Bank { BankRegId = 3, BankAddress = "Vizag", BankType = "ICICI", BankName = "student" });
            return bankInfo;
        }
        public List<Bank> GetAllBanks()
        {
            return AllBanksInfo();
        }

        public Bank GetBankInfoByRegNo(int regNo)
        {
            return AllBanksInfo().Where(w => w.BankRegId == regNo).FirstOrDefault() ?? new Bank();
        }
    }
}
