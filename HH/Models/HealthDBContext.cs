using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace HH.Models
{
    public class HealthDBContext : DbContext
    {
        public HealthDBContext()
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<HealthDBContext>());
        }
       public DbSet<Exercise> ExerciseList { get; set; }
        public DbSet<WorkoutRoutine> WorkoutRoutineList { get; set;}
    }
}