using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Project_01.Models
{
    public partial class Student
    {
        public string StuId { get; set; }
        [DisplayName("中文姓名")]
        [StringLength(20)]
        public string StuNameC { get; set; }
        [DisplayName("英文姓名")]
        [StringLength(50)]
        public string StuNameE { get; set; }
        [DisplayName("身分證字號")]
        [StringLength(10)]
        [Required(ErrorMessage = "必填")]
        public string StuIdno { get; set; }
        [DisplayName("電子信箱")]
        [StringLength(50)]
        [DataType(DataType.EmailAddress, ErrorMessage = "請輸入有效的電子信箱")]
        public string StuEmail { get; set; }
        [DisplayName("性別")]
        [StringLength(1)]
        public string StuGender { get; set; }
        [DisplayName("出生日期")]
        [StringLength(10)]
        [DataType(DataType.Date)]
        public string StuBirthday { get; set; }
        [DisplayName("入學年份")]
        [StringLength(4)]
        [Required(ErrorMessage = "必填")]
        public string StuYear { get; set; }

        public enum Gender
        {
            [Display(Name = "男")]
            M,
            [Display(Name = "女")]
            F,
            [Display(Name = "其他")]
            O
        }
    }
}
