using System.ComponentModel.DataAnnotations;

namespace Holoul.Models
{
    public class AISolutionStep
    {
        [Key]
        public int StepID { get; set; }
        public int ProblemID { get; set; }
        public int StepNumber { get; set; }
        public string StepText { get; set; }
        public string StepImage { get; set; }

        public Problem Problem { get; set; }
    }
}
