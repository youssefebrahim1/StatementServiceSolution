using StatementServiceAPI.Models;

namespace StatementServiceAPI.Services
{
    public interface IStatementService
    {
        Task<List<Statement>> GetStatementsByAccountIdAsync(int accountId);
    }
}
