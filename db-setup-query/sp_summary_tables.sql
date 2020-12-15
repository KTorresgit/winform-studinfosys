--/// <summary>
--/// Coded by       : Kim Dave Torres
--/// Activity Title : Student Information System
--/// Subject        : DBMS
--/// </summary>
USE SIS
GO

CREATE PROCEDURE sp_join
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
		CivilStatus,
		Contact_ID,
		HomeAddress, 
		District, 
		ZipCode, 
		Email, 
		ContactNumber,
		Parent_ID,
		MotherName, 
		MotherOccupation, 
		MotherMobileNumber, 
		FatherName, 
		FatherOccupation, 
		FatherMobileNumber,
		PreferredContact,
		School_ID,
		SchoolLastAttended,
		YearGraduated,
		AddressOfSchool
	FROM 
	Students s 
	INNER JOIN Contact c ON s.Stud_ID = c.Contact_ID 
	INNER JOIN Parent p ON s.Stud_ID = p.Parent_ID 
	INNER JOIN School sc ON s.Stud_ID = sc.School_ID
GO