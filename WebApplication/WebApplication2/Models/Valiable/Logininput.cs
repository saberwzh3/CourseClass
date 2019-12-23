using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication2.Models.Valiable
{
    public class Logininput
    {
        [Required]
        [Display(Name = "用户账号")]
        public string Account { get; set; }

        [Required]
        [Display(Name = "用户密码")]
        [DataType(DataType.Password)]
        public string Passwd { get; set; }

        [Display(Name = "验证码", Description = "请输入图片中的验证码。")]
        [Required(ErrorMessage = "×")]
        [StringLength(6, MinimumLength = 6, ErrorMessage = "×")]
        public string VerificationCode { get; set; }
    }
}