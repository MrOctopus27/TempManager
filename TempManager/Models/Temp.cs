using System;
using System.ComponentModel.DataAnnotations;

namespace TempManager.Models
{
    public class Temp
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Please enter a date.")]
        public DateTime? Date { get; set; }
        [Required(ErrorMessage = "Please enter a low temp")]
        [Range(-200, 200, ErrorMessage = "Enter temp between -200 and 200")]
        public double? Low { get; set; }
        [Required(ErrorMessage = "Please enter a high temp")]
        [Range(-200, 200, ErrorMessage = "Enter temp between -200 and 200")]
        public double? High { get; set; }
    }
}
