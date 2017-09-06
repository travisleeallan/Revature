--create database SchedulerAppDB
--go

use SchedulerAppDB;
go

create table Courses
(
  ID int primary key
  ,SubjectCode nchar(8) NULL
  ,CourseName nchar(100) NULL
  ,InstructorID int NULL
  ,DWstring nchar(5) NULL
  ,StartTime nchar(7) NULL
  ,EndTime nchar(7) NULL
  ,TotalSpots int NULL
  ,SpotsAvail int NULL
  ,CreditHours int NULL
);
go

create table Students
(
  ID int primary key
  ,Fname nchar(30) NULL
  ,Lname nchar(30) NULL
  ,Classification nchar(10) NULL
  ,Major nchar(100) NULL
  ,NumClasses int NULL
);
go

create table Instructors
(
  ID int primary KEY
  ,Fname nchar(30) NULL
  ,Lname nchar(30) NULL
  ,NumClasses int NULL
);
GO

create table StudentEnrollment
(
  StudentID int NULL
  ,CourseID int NULL
  ,CourseSpot int NULL
);

create table InstructorEnrollment
(
  InstructorID int NULL
  ,CourseID int NULL
);

insert into Courses(
  ID
  ,SubjectCode
  ,CourseName
  ,InstructorID
  ,DWstring
  ,StartTime
  ,EndTime
  ,TotalSpots
  ,SpotsAvail
  ,CreditHours)
values (1, 'CSCE2100', 'Computer Foundations 2', NULL, 'MWF', '8:00am', '9:20am', 25, 25, 3);

insert into Students(
  ID
  ,Fname
  ,Lname
  ,Classification
  ,Major
  ,NumHours
)
values (1, 'Travis', 'Allan', 'Senior', 'Computer Science', 0);

insert into StudentEnrollment(StudentID, CourseID, CourseSpot)
values(1, 1, 1);

update Courses
set SpotsAvail = SpotsAvail - 1
where ID = 1;

update Students
set Students.NumClasses = Students.NumClasses + 1
where Students.ID = 1;

insert into InstructorEnrollment(InstructorID, CourseID)
values(1,1);

update Courses
set InstructorID = 1;
where ID = 1; 

go 

select * from Courses;
select * from Students;
