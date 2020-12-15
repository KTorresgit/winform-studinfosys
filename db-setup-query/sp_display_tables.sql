--/// <summary>
--/// Coded by       : Kim Dave Torres
--/// Activity Title : Student Information System
--/// Subject        : DBMS
--/// </summary>
USE SIS
GO

CREATE PROCEDURE sp_display_student
AS
	SELECT 
		Stud_ID,
		ProfileImage,
		TrackOrStrand,
		LRN_Number, 
		Firstname,
		Middlename,
		Lastname,
		ExtraName,
		Sex,
		Age,
		DOB, 
		Citizenship, 
		CivilStatus
	FROM Students
GO

CREATE PROCEDURE sp_display_contact
AS
	SELECT 
		Contact_ID,
		HomeAddress, 
		District, 
		ZipCode, 
		Email, 
		ContactNumber
	FROM Contact
GO

CREATE PROCEDURE sp_display_parent
AS
	SELECT 
		Parent_ID,
		MotherName, 
		MotherOccupation, 
		MotherMobileNumber, 
		FatherName, 
		FatherOccupation, 
		FatherMobileNumber,
		PreferredContact
	FROM Parent
GO

CREATE PROCEDURE sp_display_school
AS
	SELECT 
		School_ID,
		SchoolLastAttended,
		YearGraduated,
		AddressOfSchool
	FROM School
GO