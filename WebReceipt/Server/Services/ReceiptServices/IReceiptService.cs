using Microsoft.AspNetCore.Mvc;
using WebReceipt.Models;

namespace WebReceipt.Server.Services.ReceiptService
{
    public interface IReceiptService
    {
        Task<ActionResult<ReceiptModel>> AddReceipt(ReceiptModel receipt);
         Task<List<ReceiptModel>> GetListOfReceipt(FilterParameter param);
         Task<ActionResult<ReceiptModel>> RemoveReceipt(ReceiptModel receipt);
    }
}