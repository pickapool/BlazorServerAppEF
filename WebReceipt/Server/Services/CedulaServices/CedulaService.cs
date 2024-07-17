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
            if (param.IsDate)
            {
               current = current.Where(sa => sa.DateIssued >= param._dateRange.Start && sa.DateIssued <= param._dateRange.End).ToList();
            }
            if(param.IsPayor)
            {
               current = current.Where( e =>
                e.FirstName.Contains(param.PayorName, StringComparison.InvariantCultureIgnoreCase) ||
                e.MiddleName.Contains(param.PayorName, StringComparison.InvariantCultureIgnoreCase) ||
                e.SureName.Contains(param.PayorName, StringComparison.InvariantCultureIgnoreCase)
                ).ToList();
            }
            if(param.IsORNumber)
            {
               current = current.Where( e => e.ORNumber.ToString().Contains(param.ORNumber, StringComparison.InvariantCultureIgnoreCase)).ToList();
            }
            if(param.IsTransactionType)
            {
               current = current.Where( e => param.ListOfPayments.Any( b => e.PaymentTypeId == b.PaymentTypeId)).ToList();
            }
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