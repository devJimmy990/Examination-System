﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace examinationSystem2.Models;

public partial class Topic
{
    public int CrsId { get; set; }

    public int TopicId { get; set; }

    public string TopicName { get; set; }

    public virtual Course Crs { get; set; }
}