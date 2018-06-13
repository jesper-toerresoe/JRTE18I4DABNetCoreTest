using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MVCDemoApp.Models
{
    public class Employee
    {
        [Column("Employee_id")]
        [Key]
        public int ID { get; set; }
        [Required]
        [Column(TypeName = "varchar(20)")]
        public string Name { get; set; }
        [Required]
        [Column(TypeName = "varchar(6)")]
        public string Gender { get; set; }
        [Required]
        [Column(TypeName = "varchar(20)")]
        public string Department { get; set; }
        [Required]
        [Column(TypeName = "varchar(20)")]
        public string City { get; set; }
    }
}