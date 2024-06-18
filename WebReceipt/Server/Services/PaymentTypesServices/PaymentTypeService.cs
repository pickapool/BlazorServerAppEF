using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebReceipt.Models;
using WebReceipt.Server.AppDatabaseContext;

namespace WebReceipt.Server.Services.PaymentTypeServices
{
    [Route("PaymentType/[controller]")]
    [ApiController]
    public class PaymentTypeService: ControllerBase, IPaymentTypeService
    {
        private readonly AppDBContext _context;
        public PaymentTypeService(AppDBContext context)
        {
            _context = context;
        }

        // GET: api/PaymentTypeService
        [HttpGet]
        public async Task<IEnumerable<PaymentTypeModel>> GetPayments()
        {
            return await _context.PaymentTypes.ToListAsync();
        }

        // GET: api/PaymentTypeService/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PaymentTypeModel>> GetPaymentModel(long id)
        {
            var p = await _context.PaymentTypes.FindAsync(id);

            if (p == null)
            {
                return NotFound();
            }

            return p;
        }

        // PUT: api/PaymentTypeService/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPayment(long id, PaymentTypeModel p)
        {
            if (id != p.PaymentTypeId)
            {
                return BadRequest();
            }

            _context.Entry(p).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                throw;
            }

            return NoContent();
        }

        // POST: api/PaymentTypeService
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<PaymentTypeModel>> AddPayment(PaymentTypeModel p)
        {
            _context.PaymentTypes.Add(p);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPaymentModel", new { id = p.PaymentTypeId }, p);
        }

        // DELETE: api/PaymentTypeService/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePayment(long id)
        {
            var p = await _context.PaymentTypes.FindAsync(id);
            if (p == null)
            {
                return NotFound();
            }

            _context.PaymentTypes.Remove(p);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
