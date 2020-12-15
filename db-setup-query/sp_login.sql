--/// <summary>
--/// Coded by       : Kim Dave Torres
--/// Activity Title : Student Information System
--/// Subject        : DBMS
--/// </summary>
USE SIS
GO

CREATE PROCEDURE sp_login
	@Username varchar(45),
	@Password varchar(45)
AS
	SELECT * FROM Admin WHERE Username = @Username AND Password = @Password
GO