using System.ComponentModel.DataAnnotations;

namespace Legacy.View.Request
{
    public class BaseFilterRequest
    {
        [Required]
        [Range(1,int.MaxValue-1)]
        public int Page { get; set; }

        [Required]
        [Range(1, int.MaxValue - 1)]
        public int Size { get; set; }

        [Required]
        public string OrderBy { get; set; }
        public string SearchByText { get; set; }
        public string SearchByValue { get; set; }
    }
}
