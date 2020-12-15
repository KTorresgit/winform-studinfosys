--/// <summary>
--/// Coded by       : Kim Dave Torres
--/// Activity Title : Student Information System
--/// Subject        : DBMS
--/// </summary>
USE SIS
GO

--delete student
CREATE PROCEDURE sp_student_delete
	@Stud_ID int
AS
	DELETE FROM Students WHERE Stud_ID=@Stud_ID
GO
--end

--contact delete
CREATE PROCEDURE sp_contact_delete
	@Contact_ID int
AS
	DELETE FROM Contact WHERE Contact_ID = @Contact_ID
GO
--end

--parent delete
CREATE PROCEDURE sp_parent_delete 
	@Parent_ID int
AS
	DELETE FROM Parent WHERE Parent_ID = @Parent_ID
GO
--end

--school delete
CREATE PROCEDURE sp_school_delete
	@School_ID int

AS
	DELETE FROM School WHERE School_ID = @School_ID
GO
--end