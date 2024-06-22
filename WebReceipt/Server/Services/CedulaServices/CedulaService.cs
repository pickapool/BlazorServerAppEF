using Microsoft.AspNetCore.Mvc;
using WebReceipt.Models;
using Microsoft.EntityFrameworkCore;
using WebReceipt.Server.AppDatabaseContext;

namespace WebReceipt.Server.Services.CedulaServices
{
    public class CedulaService : ControllerBase, ICedulaService
    {
        private readonly AppDBContext _context;

        public CedulaService(AppDBContext context)
        {
            _context = context;
        }
        [HttpPost]
        public async Task<List<CedulaModel>> GetListOfCedula(FilterParameter param)
        {
            List<CedulaModel> current = _context.Cedulas.Include( e => e.PaymentType).ToList();
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
        public async Task<ActionResult<CedulaModel>> AddCedula(CedulaModel receipt)
        {
            _context.Cedulas.Add(receipt);
            await _context.SaveChangesAsync();
            return receipt;
        }
        [HttpPost]
        public async Task<ActionResult<CedulaModel>> RemoveCedula(CedulaModel receipt)
        {
            _context.Cedulas.Remove(receipt);
            await _context.SaveChangesAsync();
            return receipt;
        }
        [HttpPut]
        public async Task<ActionResult<CedulaModel>> UpdateCedula(CedulaModel receipt)
        {
            _context.Entry(receipt).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return receipt;
        }
    }
}