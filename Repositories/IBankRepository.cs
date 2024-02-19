using DependencyInjection.Models;

namespace DependencyInjection.Repositories
{
    public interface IBankRepository
    {
        public List<Bank> GetAllBanks();
        public Bank GetBankInfoByRegNo(int regNo);
    }
}

