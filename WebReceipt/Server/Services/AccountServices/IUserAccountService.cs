using WebReceipt.Models;

namespace WebReceipt.Server.Services.AccountServices
{
    public interface IUserAccountService
    {
        Task<IEnumerable<UserAccountModel>> GetAccounts();
    }
}
