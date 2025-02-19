using Microsoft.EntityFrameworkCore;
using StatementServiceAPI.Data;
using StatementServiceAPI.Models;

namespace StatementServiceAPI.Services
{
    public class StatementService : IStatementService
    {
        private readonly AppDbContext _context;

        public StatementService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Statement>> GetStatementsByAccountIdAsync(int accountId)
        {
            return await _context.Statements
                                 .Where(s => s.AccountId == accountId)
                                 .ToListAsync();
        }
    }
}
