﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using examinationSystem2.Models;

namespace examinationSystem2.Context;

public partial class SQL_ProjectContext : DbContext
{
    public SQL_ProjectContext()
    {
    }

    public SQL_ProjectContext(DbContextOptions<SQL_ProjectContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Course> Courses { get; set; }

    public virtual DbSet<Department> Departments { get; set; }

    public virtual DbSet<Exam> Exams { get; set; }

    public virtual DbSet<Instructor> Instructors { get; set; }

    public virtual DbSet<QuesChoice> QuesChoices { get; set; }

    public virtual DbSet<Question> Questions { get; set; }

    public virtual DbSet<StdCourse> StdCourses { get; set; }

    public virtual DbSet<StdExam> StdExams { get; set; }

    public virtual DbSet<Student> Students { get; set; }

    public virtual DbSet<Topic> Topics { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=MERA\\SQLEXPRESS;Initial Catalog=SQL_Project;Integrated Security=True;Encrypt=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Course>(entity =>
        {
            entity.HasKey(e => e.CrsId).HasName("PK__Course__56CAA5F5342B3217");

            entity.ToTable("Course");

            entity.HasIndex(e => e.CrsName, "UQ__Course__E2D24123BC708597").IsUnique();

            entity.Property(e => e.CrsId).HasColumnName("Crs_ID");
            entity.Property(e => e.CrsDuration)
                .HasDefaultValue(25)
                .HasColumnName("Crs_Duration");
            entity.Property(e => e.CrsName)
                .IsRequired()
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("Crs_Name");
            entity.Property(e => e.InsId).HasColumnName("Ins_ID");

            entity.HasOne(d => d.Ins).WithMany(p => p.Courses)
                .HasForeignKey(d => d.InsId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_Course_Instructor");
        });

        modelBuilder.Entity<Department>(entity =>
        {
            entity.HasKey(e => e.DeptId).HasName("PK__Departme__72ABC12C691CA668");

            entity.ToTable("Department");

            entity.HasIndex(e => e.DeptName, "UQ__Departme__B744FF0FD6262392").IsUnique();

            entity.Property(e => e.DeptId).HasColumnName("Dept_ID");
            entity.Property(e => e.DeptName)
                .IsRequired()
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("Dept_Name");
            entity.Property(e => e.ManagerId).HasColumnName("Manager_ID");

            entity.HasOne(d => d.Manager).WithMany(p => p.Departments)
                .HasForeignKey(d => d.ManagerId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_Department_Instructor");

            entity.HasMany(d => d.Crs).WithMany(p => p.Depts)
                .UsingEntity<Dictionary<string, object>>(
                    "DeptCourse",
                    r => r.HasOne<Course>().WithMany()
                        .HasForeignKey("CrsId")
                        .HasConstraintName("FK_DeptCourse_Course"),
                    l => l.HasOne<Department>().WithMany()
                        .HasForeignKey("DeptId")
                        .HasConstraintName("FK_DeptCourse_Department"),
                    j =>
                    {
                        j.HasKey("DeptId", "CrsId").HasName("PK__DeptCour__37C76B735316AE12");
                        j.ToTable("DeptCourse");
                        j.IndexerProperty<int>("DeptId").HasColumnName("Dept_ID");
                        j.IndexerProperty<int>("CrsId").HasColumnName("Crs_ID");
                    });
        });

        modelBuilder.Entity<Exam>(entity =>
        {
            entity.HasKey(e => e.ExamId).HasName("PK__Exam__C782CA7994CE8A16");

            entity.ToTable("Exam");

            entity.Property(e => e.ExamId).HasColumnName("Exam_ID");
            entity.Property(e => e.ExamDuration)
                .HasDefaultValue(60)
                .HasColumnName("Exam_Duration");

            entity.HasMany(d => d.Ques).WithMany(p => p.Exams)
                .UsingEntity<Dictionary<string, object>>(
                    "ExamQuestion",
                    r => r.HasOne<Question>().WithMany()
                        .HasForeignKey("QuesId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_Exam_Question_Question"),
                    l => l.HasOne<Exam>().WithMany()
                        .HasForeignKey("ExamId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_Exam_Question_Exam"),
                    j =>
                    {
                        j.HasKey("ExamId", "QuesId").HasName("PK__Exam_Que__3D00D852AE941201");
                        j.ToTable("Exam_Question");
                        j.IndexerProperty<int>("ExamId").HasColumnName("Exam_ID");
                        j.IndexerProperty<int>("QuesId").HasColumnName("Ques_ID");
                    });
        });

        modelBuilder.Entity<Instructor>(entity =>
        {
            entity.HasKey(e => e.InsSsn).HasName("PK__Instruct__5F8D95E9370769AD");

            entity.ToTable("Instructor");

            entity.Property(e => e.InsSsn).HasColumnName("Ins_SSN");
            entity.Property(e => e.DeptId).HasColumnName("Dept_ID");
            entity.Property(e => e.InsAddress)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Ins_Address");
            entity.Property(e => e.InsFname)
                .IsRequired()
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("Ins_Fname");
            entity.Property(e => e.InsLname)
                .IsRequired()
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("Ins_Lname");
            entity.Property(e => e.InsPhone)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("Ins_Phone");
            entity.Property(e => e.InsSalary).HasColumnName("Ins_Salary");

            entity.HasOne(d => d.Dept).WithMany(p => p.Instructors)
                .HasForeignKey(d => d.DeptId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_Instructor_Department");
        });

        modelBuilder.Entity<QuesChoice>(entity =>
        {
            entity.HasKey(e => new { e.QuesId, e.QuesChoices });

            entity.Property(e => e.QuesId).HasColumnName("Ques_ID");
            entity.Property(e => e.QuesChoices)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("Ques_Choices");

            entity.HasOne(d => d.Ques).WithMany(p => p.QuesChoices)
                .HasForeignKey(d => d.QuesId)
                .HasConstraintName("FK_QuesChoices_Question");
        });

        modelBuilder.Entity<Question>(entity =>
        {
            entity.HasKey(e => e.QuesId).HasName("PK__Question__A82122BE4D6210C6");

            entity.ToTable("Question");

            entity.Property(e => e.QuesId).HasColumnName("Ques_ID");
            entity.Property(e => e.CrsId).HasColumnName("Crs_ID");
            entity.Property(e => e.QuesAnswer)
                .IsRequired()
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("Ques_Answer");
            entity.Property(e => e.QuesBody)
                .IsRequired()
                .HasColumnType("text")
                .HasColumnName("Ques_Body");
            entity.Property(e => e.QuesGrade).HasColumnName("Ques_Grade");
            entity.Property(e => e.QuesType)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Ques_Type");

            entity.HasOne(d => d.Crs).WithMany(p => p.Questions)
                .HasForeignKey(d => d.CrsId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_Question_Course");
        });

        modelBuilder.Entity<StdCourse>(entity =>
        {
            entity.HasKey(e => new { e.StId, e.CrsId }).HasName("PK__StdCours__FC6FE5CCA16E6E7F");

            entity.ToTable("StdCourse");

            entity.Property(e => e.StId).HasColumnName("St_ID");
            entity.Property(e => e.CrsId).HasColumnName("Crs_ID");

            entity.HasOne(d => d.Crs).WithMany(p => p.StdCourses)
                .HasForeignKey(d => d.CrsId)
                .HasConstraintName("FK_StdCourse_Course");

            entity.HasOne(d => d.St).WithMany(p => p.StdCourses)
                .HasForeignKey(d => d.StId)
                .HasConstraintName("FK_StdCourse_Student");
        });

        modelBuilder.Entity<StdExam>(entity =>
        {
            entity.HasKey(e => new { e.ExamId, e.QuesId });

            entity.ToTable("StdExam");

            entity.Property(e => e.ExamId).HasColumnName("Exam_ID");
            entity.Property(e => e.QuesId).HasColumnName("Ques_ID");
            entity.Property(e => e.CrsId).HasColumnName("Crs_ID");
            entity.Property(e => e.StAnswer)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("St_Answer");
            entity.Property(e => e.StSsn).HasColumnName("St_SSN");

            entity.HasOne(d => d.Exam).WithMany(p => p.StdExams)
                .HasForeignKey(d => d.ExamId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_StdExam_Exam");

            entity.HasOne(d => d.Ques).WithMany(p => p.StdExams)
                .HasForeignKey(d => d.QuesId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_StdExam_Question");

            entity.HasOne(d => d.StSsnNavigation).WithMany(p => p.StdExams)
                .HasForeignKey(d => d.StSsn)
                .HasConstraintName("FK_StdExam_Student");
        });

        modelBuilder.Entity<Student>(entity =>
        {
            entity.HasKey(e => e.StId).HasName("PK__Student__B9034F935ADD2437");

            entity.ToTable("Student");

            entity.Property(e => e.StId).HasColumnName("St_ID");
            entity.Property(e => e.DeptId).HasColumnName("Dept_ID");
            entity.Property(e => e.StAddress)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("St_Address");
            entity.Property(e => e.StBd).HasColumnName("St_BD");
            entity.Property(e => e.StFname)
                .IsRequired()
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("St_Fname");
            entity.Property(e => e.StLname)
                .IsRequired()
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("St_Lname");
            entity.Property(e => e.StPhone)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("St_Phone");
            entity.Property(e => e.StSsn)
                .HasMaxLength(14)
                .IsUnicode(false)
                .HasColumnName("St_SSN");

            entity.HasOne(d => d.Dept).WithMany(p => p.Students)
                .HasForeignKey(d => d.DeptId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_Student_Department");
        });

        modelBuilder.Entity<Topic>(entity =>
        {
            entity.HasKey(e => new { e.CrsId, e.TopicId }).HasName("PK__Topic__1E140FB79323CECB");

            entity.ToTable("Topic");

            entity.Property(e => e.CrsId).HasColumnName("Crs_ID");
            entity.Property(e => e.TopicId)
                .ValueGeneratedOnAdd()
                .HasColumnName("Topic_ID");
            entity.Property(e => e.TopicName)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Topic_Name");

            entity.HasOne(d => d.Crs).WithMany(p => p.Topics)
                .HasForeignKey(d => d.CrsId)
                .HasConstraintName("FK_Topic_Course");
        });

        OnModelCreatingGeneratedProcedures(modelBuilder);
        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}