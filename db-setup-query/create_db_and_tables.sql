--/// <summary>
--/// Coded by       : Kim Dave Torres
--/// Activity Title : Student Information System
--/// Subject        : DBMS
--/// </summary>
CREATE DATABASE SIS
USE SIS

CREATE TABLE Admin (
	Admin_ID int IDENTITY(1,1) NOT NULL,
	Username varchar(45) NOT NULL,
	Password varchar(45) NOT NULL,
	PRIMARY KEY (Admin_ID)
)
INSERT INTO Admin (Username, Password) VALUES ('Admin','123')


CREATE TABLE Students (
	Stud_ID int IDENTITY(1,1) NOT NULL,
	ProfileImage Image NOT NULL,
	TrackOrStrand varchar(55) NOT NULL,
	LRN_Number varchar(55) NOT NULL,
	Firstname varchar(55) NOT NULL,
	Middlename varchar(55) NOT NULL,
	Lastname varchar(55) NOT NULL,
	ExtraName varchar(20),
	Sex varchar(20) NOT NULL,
	Age int NOT NULL,
	DOB varchar(25) NOT NULL,
	Citizenship varchar(55) NOT NULL,
	CivilStatus varchar(55),
	PRIMARY KEY(Stud_ID)
);

CREATE TABLE Parent (
	Parent_ID int IDENTITY(1,1) NOT NULL,
	MotherName varchar(55),
	MotherOccupation varchar(55),
	MotherMobileNumber varchar(55),
	FatherName varchar(55),
	FatherOccupation varchar(55),
	FatherMobileNumber varchar(55),
	PreferredContact varchar(55) NOT NULL,
	PRIMARY KEY(Parent_ID)
);

CREATE TABLE School (
	School_ID int IDENTITY(1,1) NOT NULL,
	SchoolLastAttended varchar(55) NOT NULL,
	YearGraduated varchar(15) NOT NULL,
	AddressOfSchool varchar(55) NOT NULL,
	PRIMARY KEY(School_ID)
);

CREATE TABLE Contact (
	Contact_ID int IDENTITY(1,1) NOT NULL,
	HomeAddress varchar(55),
	District varchar(55),
	ZipCode varchar(25),
	Email varchar(55),
	ContactNumber varchar(55),
	PRIMARY KEY (Contact_ID)
);