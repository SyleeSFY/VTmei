using Server.BLL.Services.Inrerfaces;
using Server.DLL.Interfaces;
using Server.DLL.Models.Entities;

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
}