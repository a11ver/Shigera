using System.ComponentModel.DataAnnotations;

namespace laba_2
{
    public class Student : IValidateble
    {
        [Required]
        [MaxLength(20)]
        public string Name { get; set; }
        [Range(1111, 3333)]
        public int Id { get; set; }
    }
}
