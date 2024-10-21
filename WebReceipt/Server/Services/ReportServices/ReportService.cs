using Microsoft.AspNetCore.Mvc;
using Microsoft.Reporting.NETCore;
using System.Reflection;
using WebReceipt.Models;

namespace WebReceipt.Server.Services.ReportServices
{
    public class ReportService : ControllerBase, IReportService
    {
        [HttpPost]
        [Route(template: "GetMasterListReport")]
        public IActionResult GetMasterListReport([FromBody] ReceiptModel receipt)
        {
            List<ReceiptModel> list = new List<ReceiptModel>();
            list.Add(receipt);

            using var rs = Assembly.GetExecutingAssembly().GetManifestResourceStream("WebReceipt.Reports.ReceiptReport.rdlc");

            LocalReport report = new();
            report.LoadReportDefinition(rs);
            report.DataSources.Add(new ReportDataSource("ReceiptDataset", list));
            report.DataSources.Add(new ReportDataSource("NatureDataset", receipt.ListOfNatures));
            return File(report.Render("PDF"), "application/pdf", "report." + "pdf");
        }
        [HttpPost]
        [Route(template: "GetRecordReport")]
        public IActionResult GetRecordReport([FromBody] List<ReceiptModel> receipt)
        {
            using var rs = Assembly.GetExecutingAssembly().GetManifestResourceStream("WebReceipt.Reports.RecordsReport.rdlc");

            LocalReport report = new();
            report.LoadReportDefinition(rs);
            report.DataSources.Add(new ReportDataSource("ReceiptDataset", receipt));
            return File(report.Render("PDF"), "application/pdf", "report." + "pdf");
        }
        [HttpPost]
        [Route(template: "GetCedulareport")]
        public IActionResult GetCedulaReport([FromBody] List<CedulaModel> cedula)
        {
            using var rs = Assembly.GetExecutingAssembly().GetManifestResourceStream("WebReceipt.Reports.ReportCedula.rdlc");

            LocalReport report = new();
            report.LoadReportDefinition(rs);
            report.DataSources.Add(new ReportDataSource("CedulaDataset", cedula));
            return File(report.Render("PDF"), "application/pdf", "report." + "pdf");
        }
        [HttpPost]
        [Route(template: "GetCedulareport")]
        public IActionResult GetForm56Report([FromBody] List<Form56Model> cedula)
        {
            using var rs = Assembly.GetExecutingAssembly().GetManifestResourceStream("WebReceipt.Reports.ReportForm56.rdlc");

            LocalReport report = new();
            report.LoadReportDefinition(rs);
            report.DataSources.Add(new ReportDataSource("Form56Dataset", cedula));
            report.DataSources.Add(new ReportDataSource("Form56DetailDataset",(cedula.FirstOrDefault()?? new()).Details));
            return File(report.Render("PDF"), "application/pdf", "report." + "pdf");
        }
        [HttpPost]
        [Route(template: "GetReceiptHistoryReport")]
        public IActionResult GetReceiptHistoryReport([FromBody] List<ReceiptModel> receipts)
        {
            using var rs = Assembly.GetExecutingAssembly().GetManifestResourceStream("WebReceipt.Reports.PaymentHistoryReport.rdlc");

            LocalReport report = new();
            report.LoadReportDefinition(rs);
            report.DataSources.Add(new ReportDataSource("receiptdatasest", receipts));
            return File(report.Render("PDF"), "application/pdf", "report." + "pdf");
        }
    }
}
