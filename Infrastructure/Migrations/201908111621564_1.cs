namespace Infrastructure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Class",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        ClassID = c.String(nullable: false),
                        ClassName = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Student",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        StudentID = c.String(nullable: false),
                        StudnetName = c.String(nullable: false),
                        HomeAddress = c.String(),
                        PhoneNumber = c.String(),
                        FatherName = c.String(),
                        MotherName = c.String(),
                        ClassGUID = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Class", t => t.ClassGUID, cascadeDelete: true)
                .Index(t => t.ClassGUID);
            
            CreateTable(
                "dbo.StudentSubjectLists",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        StudentSubjectListID = c.Int(nullable: false),
                        SubjectListGUID = c.Guid(nullable: false),
                        StudentGUID = c.Guid(nullable: false),
                        Student_ID = c.Guid(),
                        SubjectList_ID = c.Guid(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Student", t => t.Student_ID)
                .ForeignKey("dbo.SubjectLists", t => t.SubjectList_ID)
                .Index(t => t.Student_ID)
                .Index(t => t.SubjectList_ID);
            
            CreateTable(
                "dbo.SubjectLists",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        SubjectListID = c.String(nullable: false),
                        CourseGUID = c.Guid(nullable: false),
                        TeacherGUIID = c.Guid(nullable: false),
                        ClassroomGUIID = c.Guid(nullable: false),
                        Classroom_ID = c.Guid(),
                        Course_ID = c.Guid(),
                        Teacher_ID = c.Guid(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Classrooms", t => t.Classroom_ID)
                .ForeignKey("dbo.Courses", t => t.Course_ID)
                .ForeignKey("dbo.Teachers", t => t.Teacher_ID)
                .Index(t => t.Classroom_ID)
                .Index(t => t.Course_ID)
                .Index(t => t.Teacher_ID);
            
            CreateTable(
                "dbo.Classrooms",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        ClassroomID = c.String(nullable: false),
                        ClassroomName = c.String(nullable: false),
                        SeatCount = c.Int(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Courses",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        CourseID = c.String(nullable: false),
                        CourseName = c.String(nullable: false),
                        CourseTime = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Teachers",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        TeacherID = c.String(nullable: false),
                        TeacherName = c.String(nullable: false),
                        Address = c.String(),
                        PhoneNumber = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Student", "ClassGUID", "dbo.Class");
            DropForeignKey("dbo.SubjectLists", "Teacher_ID", "dbo.Teachers");
            DropForeignKey("dbo.StudentSubjectLists", "SubjectList_ID", "dbo.SubjectLists");
            DropForeignKey("dbo.SubjectLists", "Course_ID", "dbo.Courses");
            DropForeignKey("dbo.SubjectLists", "Classroom_ID", "dbo.Classrooms");
            DropForeignKey("dbo.StudentSubjectLists", "Student_ID", "dbo.Student");
            DropIndex("dbo.SubjectLists", new[] { "Teacher_ID" });
            DropIndex("dbo.SubjectLists", new[] { "Course_ID" });
            DropIndex("dbo.SubjectLists", new[] { "Classroom_ID" });
            DropIndex("dbo.StudentSubjectLists", new[] { "SubjectList_ID" });
            DropIndex("dbo.StudentSubjectLists", new[] { "Student_ID" });
            DropIndex("dbo.Student", new[] { "ClassGUID" });
            DropTable("dbo.Teachers");
            DropTable("dbo.Courses");
            DropTable("dbo.Classrooms");
            DropTable("dbo.SubjectLists");
            DropTable("dbo.StudentSubjectLists");
            DropTable("dbo.Student");
            DropTable("dbo.Class");
        }
    }
}
