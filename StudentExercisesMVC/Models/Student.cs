using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudentExercisesMVC.Models
{

    public class Student
    {

        public int Id { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 2)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 2)]
        public string LastName { get; set; }
        [Required]
        [StringLength(20, MinimumLength = 2)]
        public string SlackHandle { get; set; }

        public int CohortId { get; set; }

        public Cohort Cohort { get; set; }


        public List<Exercise> StudentExercises { get; set; }
    }
}
