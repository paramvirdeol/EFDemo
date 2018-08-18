using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstDemo.Models
{
    [Table("tblEmployees")]
    public class Employee
    {
        public int Id { get; set; }

        [Column("First_Name")]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public int Salary { get; set; }
        public int DepartmentId { get; set; }
        public string JobTitle { get; set; }

        [ForeignKey("DepartmentId")]     
        public Department Department { get; set; }
    }
}