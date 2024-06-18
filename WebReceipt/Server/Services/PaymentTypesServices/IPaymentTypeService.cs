using Microsoft.AspNetCore.Mvc;
using WebReceipt.Models;

namespace WebReceipt.Server.Services.PaymentTypeServices
{
    public interface IPaymentTypeService
    {
        Task<IEnumerable<PaymentTypeModel>> GetPayments();
        Task<ActionResult<PaymentTypeModel>> GetPaymentModel(long id);
        Task<IActionResult> PutPayment(long id, PaymentTypeModel p);
        Task<ActionResult<PaymentTypeModel>> AddPayment(PaymentTypeModel p);
        Task<IActionResult> DeletePayment(long id);
    }
}
