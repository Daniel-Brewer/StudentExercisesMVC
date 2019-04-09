using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudentExercisesMVC.Models
{
    public class Exercise
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Language { get; set; }

        public int Id { get; set; }

        public List<Student> assignedStudents { get; set; }

    }
}
