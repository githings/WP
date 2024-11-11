﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Remoting.Contexts;
using System.Windows.Forms;
using System.Xml.Linq;

namespace pr3
{
    public class Repository
    {
        public ApplicationDbContext context;

        public Repository(String dbName)
        {
            InitDB(dbName);
        }

        private void InitDB(String dbName)
        {

            // db 생성 경로 지정 (레거시이다. 이전 네이티브 방식에서 쓰던 것)
            string exeDirPathString = Application.StartupPath;
            exeDirPathString = Directory.GetParent(exeDirPathString).ToString();
            exeDirPathString = Directory.GetParent(exeDirPathString).ToString();
            var dbPath = $"{exeDirPathString}\\{dbName}.sqlite";

            context = new ApplicationDbContext();

            // 이하 DDL
            context.Database.Initialize(force: true);

            // todo 자동 생성에 문자가 있어서 테이블을 수동 생성한다.
            // context.Database.ExecuteSqlCommand(@"
            //     CREATE TABLE IF NOT EXISTS Students (
            //     StudentID INTEGER PRIMARY KEY AUTOINCREMENT,  -- 학번 (자동 증가)
            //     Name VARCHAR(100) NOT NULL,                          -- 이름
            //     DateOfBirth Date NULL,                   -- 생년월일 (YYYY-MM-DD 형식)
            //     Department VARCHAR(250) NOT NULL,                    -- 학과
            //     Grade INTEGER CHECK(Grade BETWEEN 0 AND 20) NOT NULL,    -- 학년 (0~10학년)
            //     PhoneNumber VARCHAR(20) NULL,                            -- 전화번호
            //     Email VARCHAR(250) UNIQUE NULL,                           -- 이메일 (중복 불가)
            //     Address VARCHAR(500) NULL                               -- 주소
            // );");


            // todo 클래스 생성 순서 때문인지 아래 쿼리보다 더미데이터가 먼저 생성되는 듯.
            // 학번은 pk로 쓸 것이기 때문에 숫자타입으로 정의한다.
            // context.Database.ExecuteSqlCommand(@"
            //     UPDATE sqlite_sequence 
            //     SET seq=20240000
            //     WHERE name ='Students'
            //     ");

            context.Database.ExecuteSqlCommand(@"
                CREATE TABLE IF NOT EXISTS Students (
                    StudentID INTEGER PRIMARY KEY AUTOINCREMENT,  -- 학번 (자동 증가)
                    Name VARCHAR(100) NOT NULL,                   -- 이름
                    DateOfBirth DATE NULL,                        -- 생년월일 (YYYY-MM-DD 형식)
                    Department VARCHAR(250) NOT NULL,             -- 학과
                    Grade INTEGER CHECK(Grade BETWEEN 0 AND 20) NOT NULL, -- 학년 (0~20학년)
                    PhoneNumber VARCHAR(20) NULL,                 -- 전화번호
                    Email VARCHAR(250) UNIQUE NULL,               -- 이메일 (중복 불가)
                    Address VARCHAR(500) NULL                     -- 주소
                );

                -- Students 테이블에 데이터가 없으면 기본값 삽입
                INSERT INTO Students (Name, Department, Grade) 
                SELECT 'Placeholder', 'Default', 1
                WHERE NOT EXISTS (SELECT 1 FROM Students);

                -- 시퀀스 값 업데이트 (학번 초기값 설정)
                UPDATE sqlite_sequence 
                SET seq = 20240000
                WHERE name = 'Students';

                -- Placeholder 데이터 삭제
                DELETE FROM Students WHERE Name = 'Placeholder';
            ");


        }

        public void CreateStudentsDummy()
        {

            if (context.Students.ToList().Count >= 2) return;

            // 더미 데이터 생성
            Random rand = new Random();

            List<Student> studentsList = new List<Student>();
            for (int i = 0; i < 200; i++)
            {
                studentsList.Add(new Student
                {
                    Name = "김" + rand.Next(0, 999),
                    DateOfBirth = new DateTime(rand.Next(1955, 2026), rand.Next(1, 13), rand.Next(1, 29)),
                    Department = "제 " + rand.Next(1, 53) + "번 째 통합된 학과명",
                    Grade = rand.Next(0, 15),
                    Address = "한국 집주소 " + rand.Next(-999999, 999999) + " 번지 하이앤드수퍼클래스팰리스타운",
                    Email = "fakeda" + rand.Next(0, 212121212) + "@domain.com",
                    PhoneNumber = "010-" + rand.Next(1000, 9999) + "-" + rand.Next(1000, 9999)
                });
            }

            // 데이터 추가
            context.Students.AddRange(studentsList);
            context.SaveChanges();
        }
    }

    public class ApplicationDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }

        public ApplicationDbContext() : base("DefaultConnection")
        {
            // 파일 존재 여부는 여기서 처리해준다.
            Database.SetInitializer(new CreateDatabaseIfNotExists<ApplicationDbContext>());

        }
    }



    // 이하 테이블

    [Table("Students")]
    public class Student
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int StudentID { get; set; }  // 학번 (자동 증가)

        [Required]
        [StringLength(100)]
        public string Name { get; set; }  // 이름

        public DateTime? DateOfBirth { get; set; }  // 생년월일 (Nullable)

        [Required]
        [StringLength(250)]
        public string Department { get; set; }  // 학과

        [Required]
        [Range(0, 20)]
        public int Grade { get; set; }  // 학년 (0~20학년)

        [StringLength(20)]
        public string PhoneNumber { get; set; }  // 전화번호

        [StringLength(250)]
        [EmailAddress]
        public string Email { get; set; }  // 이메일 (중복 불가)

        [StringLength(500)]
        public string Address { get; set; }  // 주소
    }
}
