create database Students;

use Students;

create table Stud 
(
	studentID int identity primary key,
	FirstName varchar(20),
	LastName varchar(20),
	Gender varchar(20),
	HobbyID int foreign key references Hobby(HobbyID),
	Address varchar(30),
	BranchID int foreign key references Branch(BranchID),
	StudentImage varchar(max)
);

create table Hobby
(
	HobbyID int primary key identity,
	HobbyName varchar(20),
);

create table Branch
(
	BranchID int primary key identity,
	BranchName varchar(20),
);

Insert into Hobby values 
('Drawing'),
('Writing'),
('Reading'),
('Coding'),
('Art and Craft');

Insert into Branch values
('Computer'),
('Machnical'),
('Civil'),
('Electrical'),
('Transport');

Insert into Stud values
('Keyuri','Modi','Female',4,'Porbandar',1,'https://p.kindpng.com/picc/s/78-785827_user-profile-avatar-login-account-male-user-icon.png');

select * from Stud;
select * from Hobby;
select * from Branch;
