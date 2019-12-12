using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using RazorBlazor.Models;

namespace RazorBlazor
{
    public class TestService
    {
        private readonly ILogger<TestService> _logger;
        private readonly DataContext _db;

        public TestService(ILogger<TestService> logger, DataContext db)
        {
            _logger = logger;
            _db = db;

            _logger.LogInformation("TestService created");
        }

        public async Task AddDataAsync(string name)
        {
            _db.Add(new Example
            {
                Name = name,
            });
            await _db.SaveChangesAsync();
        }

        public async Task<IList<Example>> GetDataAsync()
        {
            return await _db.Examples.ToListAsync();
        }
    }
}
