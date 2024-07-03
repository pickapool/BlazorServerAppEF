using Microsoft.AspNetCore.Mvc;
using WebReceipt.Models;
using Microsoft.EntityFrameworkCore;
using WebReceipt.Server.AppDatabaseContext;

namespace WebReceipt.Server.Services.Form56Services
{
    public class Form56Service : ControllerBase, IForm456Service
    {
        private readonly AppDBContext _context;

        public Form56Service(AppDBContext context)
        {
            _context = context;
        }
        [HttpPost]
        public async Task<List<Form56Model>> GetListOfForm56(FilterParameter param)
        {
            List<Form56Model> current = _context.Form56s.Include( e => e.Details).Include( c => c.PaymentType).ToList();
            //if (param.IsDate)
            //{
            //    current = current.Where(sa => sa.DateRecorded >= param._dateRange.Start && sa.DateRecorded <= param._dateRange.End).ToList();
            //}
            //if(param.IsPayor)
            //{
            //    current = current.Where( e => e.Payor.Contains(param.PayorName, StringComparison.InvariantCultureIgnoreCase)).ToList();
            //}
            //if(param.IsORNumber)
            //{
            //    current = current.Where( e => e.Number.Contains(param.ORNumber, StringComparison.InvariantCultureIgnoreCase)).ToList();
            //}
            //if(param.IsTransactionType)
            //{
            //    current = current.Where( e => param.ListOfTransaction.Any( b => e.TransactionType == b)).ToList();
            //}
            return current;
        }
        [HttpPost]
        public async Task<ActionResult<Form56Model>> AddForm56(Form56Model receipt)
        {
            _context.Form56s.Add(receipt);
            await _context.SaveChangesAsync();
            return receipt;
        }
        [HttpPost]
        public async Task<ActionResult<Form56Model>> RemoveForm56(Form56Model receipt)
        {
            _context.Form56s.Remove(receipt);
            await _context.SaveChangesAsync();
            return receipt;
        }
        [HttpPut]
        public async Task<ActionResult<Form56Model>> UpdateForm56(Form56Model receipt)
        {
            _context.Entry(receipt).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return receipt;
        }
    }
}