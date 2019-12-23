namespace WebApplication2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Course")]
    public partial class Course
    {
        public int Id { get; set; }

        [Required]
        [StringLength(20)]
        [Display(Name ="ÐÕÃû")]
        public string Name { get; set; }

        public int? ClassId { get; set; }

        public int? TeacherId { get; set; }

        public int? SubjectId { get; set; }
    }
}
