CREATE DATABASE TeachersAndPupils;
go

use TeachersAndPupils

CREATE TABLE Teacher(
    Id int IDENTITY(1,1) PRIMARY KEY,
    FirstName nvarchar(50), 
    LastName nvarchar(50), 
    Gender nvarchar(8), 
    [Subject] nvarchar(20) 
);

CREATE TABLE Pupil(
    Id int IDENTITY(1,1) PRIMARY KEY,
    FirstName nvarchar(50), 
    LastName nvarchar(50), 
    Gender nvarchar(8), 
    Class nvarchar(20) 
);

Create Table TeacherPupil(
  TeacherId int FOREIGN KEY REFERENCES Teacher(Id),
  PupilId int FOREIGN KEY REFERENCES Pupil(Id),
  constraint PK_D primary key (TeacherId , PupilId)
);

GO

INSERT INTO [dbo].[Pupil]
           ([FirstName]
           ,[LastName]
           ,[Gender]
           ,[Class])
     VALUES
           ('giorgi'
           ,'giorgadze'
           ,'kaci'
           ,'english')

INSERT INTO [dbo].[Teacher]
           ([FirstName]
           ,[LastName]
           ,[Gender]
           ,[Subject])
     VALUES
           ('nino'
           ,'ninodze'
           ,'qali'
           ,'english')

INSERT INTO [dbo].[TeacherPupil]
           ([TeacherId]
           ,[PupilId])
     VALUES
           (1
           ,1)
GO

SELECT Teacher.FirstName , Teacher.LastName 
FROM Teacher 
INNER JOIN TeacherPupil ON TeacherPupil.TeacherId = Teacher.Id
INNER JOIN Pupil on Pupil.Id = TeacherPupil.PupilId and Pupil.FirstName = 'giorgi'