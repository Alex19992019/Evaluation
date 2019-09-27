using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebEval.Models
{
    public class student
    {
        [Key]
        [Required]
        public int StudentID { get; set; }
        [Required]
        public string Name { get; set; }
        public enum gender
        {
            masculino,
            femenino
        }
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime BirthDate { get; set; }

        [Required]
        [Range(0, 100)]
        public int Califications { get; set; }

        public enum studentStatus
        {
            Aprobado,
            Reprobado

        }
        [Required]

        public studentStatus Status { get; set; }

        public gender Gender { get; set; }
    }
}