using DependencyInjection.Models;
namespace DependencyInjection.Repositories
{
    public interface ITestBankRepo
    {
        List<Bank> GetBanksInfoFromTestBankRepo();
    }
}
