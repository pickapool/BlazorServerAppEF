using Microsoft.AspNetCore.Mvc;
using WebReceipt.Models;

namespace WebReceipt.Server.Services.ReportServices
{
    public interface IReportService
    {
        IActionResult GetMasterListReport([FromBody] ReceiptModel receipt);
    }
}
