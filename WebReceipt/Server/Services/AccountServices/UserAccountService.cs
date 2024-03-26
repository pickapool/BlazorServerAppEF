using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebReceipt.Models;
using WebReceipt.Server.AppDatabaseContext;

namespace WebReceipt.Server.Services.AccountServices
{
    [Route("UserAccount/[controller]")]
    [ApiController]
    public class UserAccountService(AppDBContext context) : ControllerBase, IUserAccountService
    {
        private readonly AppDBContext _context = context;

        // GET: api/UserAccountService
        [HttpGet]
        public async Task<IEnumerable<UserAccountModel>> GetAccounts()
        {
            return await _context.Accounts.ToListAsync();
        }

        // GET: api/UserAccountService/5
        [HttpGet("{id}")]
        public async Task<ActionResult<UserAccountModel>> GetUserAccountModel(int id)
        {
            var userAccountModel = await _context.Accounts.FindAsync(id);

            if (userAccountModel == null)
            {
                return NotFound();
            }

            return userAccountModel;
        }

        // PUT: api/UserAccountService/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUserAccountModel(int id, UserAccountModel userAccountModel)
        {
            if (id != userAccountModel.UserAccountInt)
            {
                return BadRequest();
            }

            _context.Entry(userAccountModel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UserAccountModelExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/UserAccountService
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<UserAccountModel>> PostUserAccountModel(UserAccountModel userAccountModel)
        {
            _context.Accounts.Add(userAccountModel);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetUserAccountModel", new { id = userAccountModel.UserAccountInt }, userAccountModel);
        }

        // DELETE: api/UserAccountService/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUserAccountModel(int id)
        {
            var userAccountModel = await _context.Accounts.FindAsync(id);
            if (userAccountModel == null)
            {
                return NotFound();
            }

            _context.Accounts.Remove(userAccountModel);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool UserAccountModelExists(int id)
        {
            return _context.Accounts.Any(e => e.UserAccountInt == id);
        }
    }
}
