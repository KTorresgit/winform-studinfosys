--/// <summary>
--/// Coded by       : Kim Dave Torres
--/// Activity Title : Student Information System
--/// Subject        : DBMS
--/// </summary>
USE SIS
GO

--students insert
CREATE PROCEDURE sp_students
	@ProfileImage Image,
	@TrackOrStrand varchar(55),
	@LRN_Number varchar(55),
	@Firstname varchar(55),
	@Middlename varchar(55),
	@Lastname varchar(55),
	@ExtraName varchar(20),
	@Sex varchar(20),
	@Age int,
	@DOB varchar(25),
	@Citizenship varchar(55),
	@CivilStatus varchar(55)
AS
	INSERT INTO Students VALUES (
		@ProfileImage,
		@TrackOrStrand,
		@LRN_Number, 
		@Firstname,
		@Middlename,
		@Lastname,
		@ExtraName,
		@Sex,
		@Age,
		@DOB, 
		@Citizenship, 
		@CivilStatus 	
	)
GO
--end

--contact insert
CREATE PROCEDURE sp_contact
	@HomeAddress varchar(55),
	@District varchar(55),
	@ZipCode varchar(25),
	@Email varchar(55),
	@ContactNumber varchar(55)
AS
	INSERT INTO Contact VALUES (
		@HomeAddress, 
		@District, 
		@ZipCode, 
		@Email, 
		@ContactNumber 
	)
GO
--end

--contact insert
CREATE PROCEDURE sp_parent
	@MotherName varchar(55),
	@MotherOccupation varchar(55),
	@MotherMobileNumber varchar(55),
	@FatherName varchar(55),
	@FatherOccupation varchar(55),
	@FatherMobileNumber varchar(55),
	@PreferredContact varchar(55)
AS
	INSERT INTO Parent VALUES (
		@MotherName, 
		@MotherOccupation, 
		@MotherMobileNumber, 
		@FatherName, 
		@FatherOccupation, 
		@FatherMobileNumber,
		@PreferredContact	
	)
GO
--end

--school insert
CREATE PROCEDURE sp_school	
		@SchoolLastAttended varchar(55),
		@YearGraduated varchar(15),
		@AddressOfSchool varchar(55)
AS
	INSERT INTO School VALUES (
		@SchoolLastAttended,
		@YearGraduated,
		@AddressOfSchool
	)
GO
--end

