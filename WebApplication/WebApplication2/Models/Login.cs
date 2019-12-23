using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class Login
    {
        public int Id { get; set; }

        [Required]
        [StringLength(20)]
        [Display(Name = "用户账号")]
        public string Account { get; set; }


        [Required]
        [StringLength(20)]
        [Display(Name = "用户名")]
        public string Name { get; set; }

        [Required]
        [StringLength(20)]
        [Display(Name = "密码")]
        [DataType(DataType.Password)]
        public string Pwd { get; set; }

        public string Verify { get; set; }


    }
}