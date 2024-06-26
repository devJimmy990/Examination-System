﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace examinationSystem2.Models;

public partial class Student
{
    public int StId { get; set; }

    public string StFname { get; set; }

    public string StLname { get; set; }

    public string StPhone { get; set; }

    public string StAddress { get; set; }

    public DateOnly? StBd { get; set; }

    public int? DeptId { get; set; }

    public string StSsn { get; set; }

    public virtual Department Dept { get; set; }

    public virtual ICollection<StdCourse> StdCourses { get; set; } = new List<StdCourse>();

    public virtual ICollection<StdExam> StdExams { get; set; } = new List<StdExam>();
}