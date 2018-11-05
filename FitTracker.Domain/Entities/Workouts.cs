using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;w

namespace FitTracker.Domain.Entities
{
    public class Workouts
    {
        public string WorkoutName { get; set; }

        public string WorkoutCategory { get; set; }

        public int WorkoutWeight { get; set; }

        public int WorkoutSets { get; set; }

        public int WorkoutReps { get; set; }
    }
}
