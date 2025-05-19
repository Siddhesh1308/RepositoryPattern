using Pattern.Models;
using StudentManagement.Data;

namespace Pattern.Repositories
{
    public class YearLevelRepo(ApplicationDbContext context) : IYearLevelRepo
    {
        public List<YearLevel> GetAllYearLevels()
        {
            return context.YearLevel.Where(x => x.IsActive == true).ToList();
        }
        public YearLevel GetYearLevelById(int id)
        {
            return context.YearLevel.FirstOrDefault(x => x.YearLevelId == id);

        }
        public void AddYearLevel(YearLevel YL)
        {
            context.YearLevel.Add(YL);
            context.SaveChanges();
        }
        public void UpdateYearLevel(YearLevel YL)
        {
            var yearUpdate = context.YearLevel.Find(YL.YearLevelId);
            if (yearUpdate != null)
            {
                yearUpdate.YearLevelTitle = YL.YearLevelTitle;
                context.SaveChanges();
            }

        }
        public void DeleteYearLevel(int id)
        {
            var result = context.YearLevel.Find(id);
            if (result != null)
            {
                result.IsActive = false;
                context.SaveChanges();
            }
        }
    }
 
}
