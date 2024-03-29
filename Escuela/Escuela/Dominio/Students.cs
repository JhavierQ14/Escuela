﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Escuela.Dominio
{
    public class Students
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int StudentsId { get; set; }

        public  string LastName { get; set; }

        public string FirstMidName { get; set; }

        public DateTime EnrrollmentsDate { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
