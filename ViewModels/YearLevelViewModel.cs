using Pattern.Models;

namespace Pattern.ViewModels
{
    public class YearLevelViewModel
    {
        public List<YearLevel> YearLevels { get; set; }
        public int YearLevelId { get; set; }
        public string YearLevelTitle { get; set; }
        public bool IsActive { get; set; } = true;
    }
}
