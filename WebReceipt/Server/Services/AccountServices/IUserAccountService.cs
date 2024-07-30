using Microsoft.AspNetCore.Mvc;
using WebReceipt.Models;

namespace WebReceipt.Server.Services.AccountServices
{
    public interface IUserAccountService
    {
        Task<IEnumerable<UserAccountModel>> GetAccounts();
        Task<ActionResult<UserAccountModel>> AddUser(UserAccountModel userAccountModel);
        Task<IActionResult> PutUserAccountModel(int id, UserAccountModel userAccountModel);
        Task<IActionResult> DeleteUserAccountModel(int id);
        UserAccountModel Authenticated(string username, string password);
    }
}
