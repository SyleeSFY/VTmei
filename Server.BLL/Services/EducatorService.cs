using Server.BLL.Services.Inrerfaces;
using Server.DAL.Interfaces;
using Server.DAL.Models.Entities;
using Server.DAL.Models.Entities.Educators;

namespace Server.BLL.Services;

public class EducatorService : IEducatorService
{
    private readonly IEducatorRepository _educatorRepository;

    public EducatorService(IEducatorRepository educatorRepository)
    {
        _educatorRepository = educatorRepository;
    }

    public async Task<Educator> GetByIdAsync(int id)
    {
        return await _educatorRepository.GetByIdAsync(id);
    }
    
    public async Task<Educator> GetByIdAddInfoAsync(int id)
    {
        return await _educatorRepository.GetByIdAddInfoAsync(id);
    }

    public async Task AddEducator(Educator educator)
    {
        await _educatorRepository.AddEducator(educator);
    }
    
}