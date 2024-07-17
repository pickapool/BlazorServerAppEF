using Microsoft.AspNetCore.Mvc;
using WebReceipt.Models;
using Microsoft.EntityFrameworkCore;
using WebReceipt.Server.AppDatabaseContext;

namespace WebReceipt.Server.Services.ReceiptService
{
    public class ReceiptService : ControllerBase, IReceiptService
    {
        private readonly AppDBContext _context;

        public ReceiptService(AppDBContext context)
        {
            _context = context;
        }
        [HttpPost]
        public async Task<List<ReceiptModel>> GetListOfReceipt(FilterParameter param)
        {
            List<ReceiptModel> current = _context.Receipts.Include( e => e.ListOfNatures).Include( e => e.PaymentType).ToList();
            if (param.IsDate)
            {
                current = current.Where(sa => sa.DateRecorded >= param._dateRange.Start && sa.DateRecorded <= param._dateRange.End).ToList();
            }
            if(param.IsPayor)
            {
                current = current.Where( e => e.Payor.Contains(param.PayorName, StringComparison.InvariantCultureIgnoreCase)).ToList();
            }
            if(param.IsORNumber)
            {
                current = current.Where( e => e.Number.Contains(param.ORNumber, StringComparison.InvariantCultureIgnoreCase)).ToList();
            }
            if(param.IsTransactionType)
            {
               current = current.Where( e => param.ListOfPayments.Any( b => e.PaymentTypeId == b.PaymentTypeId)).ToList();
            }
            return current;
        }
        [HttpPost]
        public async Task<ActionResult<ReceiptModel>> AddReceipt(ReceiptModel receipt)
        {
            _context.Receipts.Add(receipt);
            await _context.SaveChangesAsync();
            return receipt;
        }
        [HttpPost]
        public async Task<ActionResult<ReceiptModel>> RemoveReceipt(ReceiptModel receipt)
        {
            _context.Receipts.Remove(receipt);
            await _context.SaveChangesAsync();
            return receipt;
        }
        [HttpPut]
        public async Task<ActionResult<ReceiptModel>> UpdateReceipt(ReceiptModel receipt)
        {
            _context.Entry(receipt).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return receipt;
        }
    }
}