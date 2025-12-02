using Microsoft.EntityFrameworkCore;
using Server.DAL.Context.ApplicationDbContext;
using Server.DAL.Models.Entities.Educators;

namespace Server.DAL.Templates;

public class EducatorsBD
{
    private readonly EducatorDbContext _context;

    public EducatorsBD(EducatorDbContext context)
        => _context = context;
    
    private List<Educator> _educators = new()
    {
        new Educator
        {
            Profession = "Заведующий кафедрой вычислительной техники",
            FullName = "Борисов Вадим Владимирович",
            AcademicDegree = "Доктор технических наук",
            EducatorAdditionalInfo = new EducatorAdditionalInfo
            {
                EducationLevel = "Специалитет",
                AcademicTitle = "Профессор",
                SpecialtyOrFieldOfStudy = "Конструирование и производство электронно-вычислительной аппаратуры",
                Qualification = "Инженер-конструктор-технолог ЭВА",
                AdditionalInfo = "тест",
                Image = null,
                EducatorDisciplines = new List<EducatorDiscipline>
                {
                    new EducatorDiscipline
                    {
                        DisciplineId = 5
                    }
                }
            }
        },

    };
    
    public void AddEducator()
    {
        
    }

    private List<EducatorDiscipline> GetEducatorDisciplines()
    {

        return _context.EducatorDisciplines
            .Include(ed => ed.Discipline) 
            .ToList();
        
    }
}