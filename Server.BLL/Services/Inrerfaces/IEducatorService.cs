using Server.DAL.Models.Entities;
using Server.DAL.Models.Entities.Educators;

namespace Server.BLL.Services.Inrerfaces;

public interface IEducatorService
{
    Task<Educator> GetByIdAsync(int id);
    Task<Educator> GetByIdAddInfoAsync(int id);

    Task AddEducator(Educator educator);

}