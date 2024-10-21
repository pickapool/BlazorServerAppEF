using Microsoft.AspNetCore.Mvc;
using WebReceipt.Models;

namespace WebReceipt.Server.Services.ReportServices
{
    public interface IReportService
    {
        IActionResult GetMasterListReport([FromBody] ReceiptModel receipt);
        IActionResult GetRecordReport([FromBody] List<ReceiptModel> receipt);
        IActionResult GetCedulaReport([FromBody] List<CedulaModel> cedula);
        IActionResult GetForm56Report([FromBody] List<Form56Model> cedula);
        IActionResult GetReceiptHistoryReport([FromBody] List<ReceiptModel> receipts);
    }
}
