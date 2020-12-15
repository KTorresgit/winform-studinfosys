--/// <summary>
--/// Coded by       : Kim Dave Torres
--/// Activity Title : Student Information System
--/// Subject        : DBMS
--/// </summary>
USE SIS
GO

CREATE PROCEDURE sp_stud_report
AS
	SELECT 
	 "Contact"."HomeAddress", 
	 "Contact"."District", 
	 "Contact"."ZipCode",
	 "Contact"."Email", 
	 "Contact"."ContactNumber", 
	 "Parent"."MotherName",
	 "Parent"."MotherOccupation",
	 "Parent"."MotherMobileNumber",
	 "Parent"."FatherName",
	 "Parent"."FatherOccupation", 
	 "Parent"."FatherMobileNumber",
	 "Parent"."PreferredContact",
	 "School"."SchoolLastAttended",
	 "School"."YearGraduated", 
	 "School"."AddressOfSchool",
	 "Students"."Stud_ID",
	 "Students"."TrackOrStrand", 
	 "Students"."LRN_Number",
	 "Students"."Firstname", 
	 "Students"."Middlename",
	 "Students"."Lastname", 
	 "Students"."ExtraName", 
	 "Students"."Sex", 
	 "Students"."Age",
	 "Students"."DOB",
	 "Students"."Citizenship",
	 "Students"."CivilStatus"
	 FROM   
	 (("SIS"."dbo"."Students" "Students" INNER JOIN "SIS"."dbo"."Contact" "Contact" ON "Students"."Stud_ID"="Contact"."Contact_ID")
	 INNER JOIN "SIS"."dbo"."Parent" "Parent" ON "Students"."Stud_ID"="Parent"."Parent_ID")
	 INNER JOIN "SIS"."dbo"."School" "School" ON "Students"."Stud_ID"="School"."School_ID"
GO

 
