namespace Client.Core.Shared.Models;

public class EducatorDiscipline
{
    public int Id { get; set; }
    public int EducatorAdditionalInfoId { get; set; } 
    public int DisciplineId { get; set; }
    public Discipline Discipline { get; set; }
}