using Server.DLL.Context.ApplicationDbContext;
using Server.DLL.Interfaces;
using Server.DLL.Models.Entities;

namespace Server.DLL.Repositories;

public class EducatorRepository : IEducatorRepository
{
    private readonly ApplicationDbContext _context;

    public EducatorRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<Educator> GetByIdAsync(int id)
    {
        return await _context.Educators.FindAsync(id);
    }
}