using System.ComponentModel.DataAnnotations;

namespace MyTasks.Core.Models
{
    public class FilterTasks
    {
        public string Title { get; set; }

        public int CategoryID { get; set; }

        [Display(Name="Tylko zrealizowane")]
        public bool IsExecuted { get; set; }
    }
}
