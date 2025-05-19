using Pattern.Models;

namespace Pattern.Repositories
{
    public interface IDegreeProgramRepo
    {
        List<DegreeProgram> GetAllDegreePrograms();
        DegreeProgram GetDegreeProgramById(int id);
        void AddDegreeProgram(DegreeProgram degreeProgram);
        void UpdateDegreeProgram(DegreeProgram degreeProgram);
        void DeleteDegreeProgram(int id);
    }
}
