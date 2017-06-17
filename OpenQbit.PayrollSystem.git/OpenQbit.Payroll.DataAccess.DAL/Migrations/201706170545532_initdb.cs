namespace OpenQbit.Payroll.DataAccess.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initdb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Advances",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EmployeeId = c.Int(nullable: false),
                        Date = c.DateTime(nullable: false),
                        Aount = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Employees", t => t.EmployeeId, cascadeDelete: true)
                .Index(t => t.EmployeeId);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PersonId = c.Int(nullable: false),
                        DepartmentId = c.Int(nullable: false),
                        GradeId = c.Int(nullable: false),
                        RoleId = c.Int(nullable: false),
                        BankId = c.Int(nullable: false),
                        BankAccount = c.String(),
                        JoinedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Banks", t => t.BankId, cascadeDelete: true)
                .ForeignKey("dbo.Departments", t => t.DepartmentId, cascadeDelete: true)
                .ForeignKey("dbo.Grades", t => t.GradeId, cascadeDelete: true)
                .ForeignKey("dbo.People", t => t.PersonId, cascadeDelete: true)
                .ForeignKey("dbo.Roles", t => t.RoleId, cascadeDelete: true)
                .Index(t => t.PersonId)
                .Index(t => t.DepartmentId)
                .Index(t => t.GradeId)
                .Index(t => t.RoleId)
                .Index(t => t.BankId);
            
            CreateTable(
                "dbo.Attendances",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EmployeeId = c.Int(nullable: false),
                        Date = c.DateTime(nullable: false),
                        InTime = c.DateTime(nullable: false),
                        OutTime = c.DateTime(nullable: false),
                        ShortLeaveInTime = c.DateTime(nullable: false),
                        ShortLeaveOutTime = c.DateTime(nullable: false),
                        OTHourse = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Employees", t => t.EmployeeId, cascadeDelete: true)
                .Index(t => t.EmployeeId);
            
            CreateTable(
                "dbo.Banks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BankName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Deductions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EmployeeId = c.Int(nullable: false),
                        Date = c.DateTime(nullable: false),
                        Description = c.String(),
                        DamageCost = c.Double(nullable: false),
                        MonthlyDeduction = c.Double(nullable: false),
                        TimePeriod = c.String(),
                        DueDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Employees", t => t.EmployeeId, cascadeDelete: true)
                .Index(t => t.EmployeeId);
            
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DepartmentName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Grades",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        GradeName = c.String(),
                        MaxLoanAmount = c.Double(nullable: false),
                        MaxAdvanceRate = c.Double(nullable: false),
                        WeekEndOTAmount = c.Double(nullable: false),
                        NormalOTAmount = c.Double(nullable: false),
                        VehicleAllowance = c.Boolean(nullable: false),
                        NoPayRate = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Bonus",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        GradeId = c.Int(nullable: false),
                        TypeId = c.Int(nullable: false),
                        Date = c.DateTime(nullable: false),
                        Amount = c.Double(nullable: false),
                        BonusType_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.BonusTypes", t => t.BonusType_Id)
                .ForeignKey("dbo.Grades", t => t.GradeId, cascadeDelete: true)
                .Index(t => t.GradeId)
                .Index(t => t.BonusType_Id);
            
            CreateTable(
                "dbo.BonusTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Type = c.String(),
                        Amount = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Leaves",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EmployeeId = c.Int(nullable: false),
                        Date = c.DateTime(nullable: false),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Employees", t => t.EmployeeId, cascadeDelete: true)
                .Index(t => t.EmployeeId);
            
            CreateTable(
                "dbo.Loans",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EmployeeId = c.Int(nullable: false),
                        LoanAmount = c.Double(nullable: false),
                        MonthlyInstallement = c.Double(nullable: false),
                        Date = c.DateTime(nullable: false),
                        DueTime = c.DateTime(nullable: false),
                        TimePeriod = c.Double(nullable: false),
                        Description = c.String(),
                        GuaranterName = c.String(),
                        GuaranterNic = c.String(),
                        GuaranterMobile = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Employees", t => t.EmployeeId, cascadeDelete: true)
                .Index(t => t.EmployeeId);
            
            CreateTable(
                "dbo.People",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        GlobalId = c.String(),
                        FirstName = c.String(),
                        MidName = c.String(),
                        LastName = c.String(),
                        NIC = c.String(),
                        Mobile = c.Int(nullable: false),
                        DateofBirth = c.DateTime(nullable: false),
                        Gender = c.String(),
                        Address = c.String(),
                        Email = c.String(),
                        MaritalStatus = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SystemUsers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PersonId = c.Int(nullable: false),
                        UserName = c.String(),
                        Password = c.String(),
                        UserType = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.People", t => t.PersonId, cascadeDelete: true)
                .Index(t => t.PersonId);
            
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RoleName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Salaries",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EmployeeId = c.Int(nullable: false),
                        Date = c.DateTime(nullable: false),
                        Transport = c.Double(nullable: false),
                        OT = c.Double(nullable: false),
                        Tax = c.Double(nullable: false),
                        EPF = c.Double(nullable: false),
                        EF = c.Double(nullable: false),
                        NoPay = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Employees", t => t.EmployeeId, cascadeDelete: true)
                .Index(t => t.EmployeeId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Salaries", "EmployeeId", "dbo.Employees");
            DropForeignKey("dbo.Employees", "RoleId", "dbo.Roles");
            DropForeignKey("dbo.SystemUsers", "PersonId", "dbo.People");
            DropForeignKey("dbo.Employees", "PersonId", "dbo.People");
            DropForeignKey("dbo.Loans", "EmployeeId", "dbo.Employees");
            DropForeignKey("dbo.Leaves", "EmployeeId", "dbo.Employees");
            DropForeignKey("dbo.Employees", "GradeId", "dbo.Grades");
            DropForeignKey("dbo.Bonus", "GradeId", "dbo.Grades");
            DropForeignKey("dbo.Bonus", "BonusType_Id", "dbo.BonusTypes");
            DropForeignKey("dbo.Employees", "DepartmentId", "dbo.Departments");
            DropForeignKey("dbo.Deductions", "EmployeeId", "dbo.Employees");
            DropForeignKey("dbo.Employees", "BankId", "dbo.Banks");
            DropForeignKey("dbo.Attendances", "EmployeeId", "dbo.Employees");
            DropForeignKey("dbo.Advances", "EmployeeId", "dbo.Employees");
            DropIndex("dbo.Salaries", new[] { "EmployeeId" });
            DropIndex("dbo.SystemUsers", new[] { "PersonId" });
            DropIndex("dbo.Loans", new[] { "EmployeeId" });
            DropIndex("dbo.Leaves", new[] { "EmployeeId" });
            DropIndex("dbo.Bonus", new[] { "BonusType_Id" });
            DropIndex("dbo.Bonus", new[] { "GradeId" });
            DropIndex("dbo.Deductions", new[] { "EmployeeId" });
            DropIndex("dbo.Attendances", new[] { "EmployeeId" });
            DropIndex("dbo.Employees", new[] { "BankId" });
            DropIndex("dbo.Employees", new[] { "RoleId" });
            DropIndex("dbo.Employees", new[] { "GradeId" });
            DropIndex("dbo.Employees", new[] { "DepartmentId" });
            DropIndex("dbo.Employees", new[] { "PersonId" });
            DropIndex("dbo.Advances", new[] { "EmployeeId" });
            DropTable("dbo.Salaries");
            DropTable("dbo.Roles");
            DropTable("dbo.SystemUsers");
            DropTable("dbo.People");
            DropTable("dbo.Loans");
            DropTable("dbo.Leaves");
            DropTable("dbo.BonusTypes");
            DropTable("dbo.Bonus");
            DropTable("dbo.Grades");
            DropTable("dbo.Departments");
            DropTable("dbo.Deductions");
            DropTable("dbo.Banks");
            DropTable("dbo.Attendances");
            DropTable("dbo.Employees");
            DropTable("dbo.Advances");
        }
    }
}
