﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace examinationSystem2.Models
{
    public partial class SP_STDCourseGradeResult
    {
        public string Department { get; set; }
        public string Student { get; set; }
        public string Instructor { get; set; }
        public string Course { get; set; }
        public int Grade { get; set; }
    }
}