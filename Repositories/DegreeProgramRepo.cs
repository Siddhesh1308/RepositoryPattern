using Microsoft.EntityFrameworkCore;
using Pattern.Models;
using StudentManagement.Data;

namespace Pattern.Repositories
{
    public class DegreeProgramRepo(ApplicationDbContext context) : IDegreeProgramRepo
    {
        //private readonly ApplicationDbContext _context;

        //public DegreeProgramRepo(ApplicationDbContext context)
        //{
        //    _context = context;
        //}
        public List<DegreeProgram> GetAllDegreePrograms()
        {
            return context.DegreeProgram.Where(x =>x.IsActive == true).ToList();
        }

        public DegreeProgram GetDegreeProgramById(int id)
        {
            return context.DegreeProgram.FirstOrDefault(x => x.DegreeProgramId == id);
        }

        public void AddDegreeProgram(DegreeProgram DM)
        {
            context.DegreeProgram.Add(DM);
            context.SaveChanges();
        }

        public void UpdateDegreeProgram(DegreeProgram DM)
        {
            var degreeUpdate = context.DegreeProgram.Find(DM.DegreeProgramId);
            if(degreeUpdate != null)
            {
                degreeUpdate.DegreeProgramTitle = DM.DegreeProgramTitle;
                context.SaveChanges();
            }
        
        }

        public void DeleteDegreeProgram(int id)
        {
            var result = context.DegreeProgram.Find(id);
            if (result != null)
            {
                result.IsActive = false;
                context.SaveChanges();
            }
        }
    }
}
