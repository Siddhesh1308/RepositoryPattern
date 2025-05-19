using Pattern.Models;

namespace Pattern.Repositories
{
    public interface IYearLevelRepo
    {
        List<YearLevel> GetAllYearLevels();
        YearLevel GetYearLevelById(int id);
        void AddYearLevel(YearLevel yearLevel);
        void UpdateYearLevel(YearLevel yearLevel);
        void DeleteYearLevel(int id);
    }
}
