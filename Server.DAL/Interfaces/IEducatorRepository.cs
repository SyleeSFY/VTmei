using Server.DAL.Models.Entities;
using Server.DAL.Models.Entities.Educators;

namespace Server.DAL.Interfaces;

public interface IEducatorRepository
{
    Task<Educator> GetByIdAsync(int id);
    Task<Educator?> GetByIdAddInfoAsync(int id);
    Task AddEducator(Educator educator);
}