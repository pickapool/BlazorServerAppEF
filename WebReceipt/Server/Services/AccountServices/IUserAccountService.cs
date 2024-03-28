using Microsoft.AspNetCore.Mvc;
using WebReceipt.Models;

namespace WebReceipt.Server.Services.AccountServices
{
    public interface IUserAccountService
    {
        Task<IEnumerable<UserAccountModel>> GetAccounts();
        Task<ActionResult<UserAccountModel>> AddUser(UserAccountModel userAccountModel);
        bool Authenticated(string username, string password);
    }
}
