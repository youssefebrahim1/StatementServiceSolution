using Microsoft.AspNetCore.Mvc;
using StatementServiceAPI.Models;
using StatementServiceAPI.Services;

namespace StatementServiceAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StatementController : ControllerBase
    {
        private readonly IStatementService _statementService;

        public StatementController(IStatementService statementService)
        {
            _statementService = statementService;
        }

        [HttpPost("GetStatement")]
        public async Task<IActionResult> GetStatement([FromBody] AccountRequest request)
        {
            if (request == null || request.AccountId <= 0)
                return BadRequest("Invalid account ID.");

            var data = await _statementService.GetStatementsByAccountIdAsync(request.AccountId);

            if (data == null || !data.Any())
                return NotFound($"No statements found for Account ID {request.AccountId}");

            return Ok(data);
        }
    }

    public class AccountRequest
    {
        public int AccountId { get; set; }
    }
}
