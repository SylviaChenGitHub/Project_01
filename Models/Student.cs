using System;
using System.Collections.Generic;

#nullable disable

namespace Project_01.Models
{
    public partial class Student
    {
        public string StuId { get; set; }
        public string StuNameC { get; set; }
        public string StuNameE { get; set; }
        public string StuIdno { get; set; }
        public string StuEmail { get; set; }
        public string StuGender { get; set; }
        public DateTime? StuBirthday { get; set; }
        public string StuYear { get; set; }
    }
}
