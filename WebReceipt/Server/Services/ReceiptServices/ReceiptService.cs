using System.Data.Entity;
using Microsoft.AspNetCore.Mvc;
using WebReceipt.Models;
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
            return _context.Receipts.ToList();
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
    }
}