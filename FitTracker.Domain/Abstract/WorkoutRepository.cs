using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FitTracker.Domain.Entities;


namespace FitTracker.Domain.Abstract
{
    public interface IWorkoutRepository
    {
        IEnumerable<Workouts> Workouts { get; }
    }
}
