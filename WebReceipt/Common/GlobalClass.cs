using WebReceipt.Models;

namespace WebReceipt.Common
{
    public class GlobalClass
    {
        public static bool IsLogin = false;
        public static string Title = string.Empty;
        public static UserAccountModel UserAccount = new();
    }
}