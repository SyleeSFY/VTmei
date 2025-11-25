using Server.DLL.Models.Entities;

namespace Server.DLL.Interfaces;

public interface IEducatorRepository
{
    Task<Educator> GetByIdAsync(int id);
}