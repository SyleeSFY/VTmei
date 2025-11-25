using Server.DLL.Models.Entities;

namespace Server.BLL.Services.Inrerfaces;

public interface IEducatorService
{
    Task<Educator> GetByIdAsync(int id);
}