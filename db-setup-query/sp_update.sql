--/// <summary>
--/// Coded by       : Kim Dave Torres
--/// Activity Title : Student Information System
--/// Subject        : DBMS
--/// </summary>
USE SIS
GO

--update student
CREATE PROCEDURE sp_student_update
	@Stud_ID int,
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
	UPDATE Students
	SET 
		ProfileImage=@ProfileImage,
		TrackOrStrand=@TrackOrStrand,
		LRN_Number=@LRN_Number, 
		Firstname=@Firstname,
		Middlename=@Middlename,
		Lastname=@Lastname,
		ExtraName=@ExtraName,
		Sex=@Sex,
		Age=@Age,
		DOB=@DOB, 
		Citizenship=@Citizenship, 
		CivilStatus=@CivilStatus
	WHERE Stud_ID=@Stud_ID
GO
--end

--contact update
CREATE PROCEDURE sp_contact_update
	@Contact_ID int,
	@HomeAddress varchar(55),
	@District varchar(55),
	@ZipCode varchar(25),
	@Email varchar(55),
	@ContactNumber varchar(55)
AS
	UPDATE Contact
	SET
		HomeAddress=@HomeAddress,
		District=@District,
		ZipCode=@ZipCode,
		Email=@Email,
		ContactNumber=@ContactNumber
	WHERE Contact_ID = @Contact_ID
GO
--end

--parent update
CREATE PROCEDURE sp_parent_update 
	@Parent_ID int,
	@MotherName varchar(55),
	@MotherOccupation varchar(55),
	@MotherMobileNumber varchar(55),
	@FatherName varchar(55),
	@FatherOccupation varchar(55),
	@FatherMobileNumber varchar(55),
	@PreferredContact varchar(55)

AS
	UPDATE Parent 
	SET
		MotherName=@MotherName,
		MotherOccupation=@MotherOccupation,
		MotherMobileNumber=@MotherMobileNumber,
		FatherName=	@FatherName,
		FatherOccupation=@FatherOccupation,
		FatherMobileNumber=@FatherMobileNumber,
		PreferredContact=@PreferredContact
	WHERE Parent_ID = @Parent_ID
GO
--end

--school update
CREATE PROCEDURE sp_school_update 
	@School_ID int,
	@SchoolLastAttended varchar(55),
	@YearGraduated varchar(15),
	@AddressOfSchool varchar(55)
AS
	UPDATE School
	SET 
		SchoolLastAttended=@SchoolLastAttended,
		YearGraduated=@YearGraduated,
		AddressOfSchool=@AddressOfSchool
	WHERE School_ID = @School_ID
GO
--end