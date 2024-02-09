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
        public string Name { get; set; }
        public byte[] Images { get; set; }
        public string Description { get; set; }
        public string DifficultyLevel { get; set; }
        public string EquipmentRequired { get; set; }
        public string TargetedMuscles { get; set; }
        public string Instructions { get; set; }
    }
}