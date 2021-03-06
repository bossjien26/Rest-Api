using System.ComponentModel.DataAnnotations;

namespace RestApi.Models.Requests
{
    public class CreateSpecificationContentRequest
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public int SpecificationId { get; set; }
    }
}