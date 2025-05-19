using Pattern.Models;

namespace Pattern.ViewModels
{
    public class DegreeProgramViewModel
    {
        public List<DegreeProgram> DegreePrograms { get; set; }
        public int DegreeProgramId { get; set; }
        public string DegreeProgramTitle { get; set; }
        public bool IsActive { get; set; } = true;

    }
}
