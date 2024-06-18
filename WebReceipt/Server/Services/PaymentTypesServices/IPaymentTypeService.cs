using Microsoft.AspNetCore.Mvc;
using WebReceipt.Models;

namespace WebReceipt.Server.Services.PaymentTypeServices
{
    public interface IPaymentTypeService
    {
        Task<IEnumerable<PaymentTypeModel>> GetPayments();
        Task<ActionResult<PaymentTypeModel>> GetPaymentModel(int id);
        Task<IActionResult> PutUserAccountModel(int id, PaymentTypeModel p);
        Task<ActionResult<PaymentTypeModel>> AddPayment(PaymentTypeModel p);
        Task<IActionResult> DeletePayment(int id);
    }
}
