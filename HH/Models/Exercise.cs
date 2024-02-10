using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HH.Models
{
    public class Exercise
    {
        [Key]
        public int ExerciseID { get; set; }

        [Required(ErrorMessage ="The Name of Exercise can't be Empty")]
        public string Name { get; set; }

        [Required (ErrorMessage = "The Image Should be Selected")]
        public string Images { get; set; }
        public string Video { get; set; }

        [Required (ErrorMessage = "Description Can't be Empty")]
        public string Description { get; set; }
        public string DifficultyLevel { get; set; }
        public string EquipmentRequired { get; set; }
        public string TargetedMuscles { get; set; }
        public string Instructions { get; set; }
    }
}