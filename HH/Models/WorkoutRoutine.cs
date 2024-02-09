using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HH.Models
{
    public class WorkoutRoutine
    {
        [Key]
        public int RoutineID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Duration { get; set; }
        
       public Exercise Exercise { get; set; }
        public WorkoutRoutine() { }
    }
}